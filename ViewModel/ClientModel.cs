using System;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text.Json;
using System.Windows.Forms;

namespace LicenseGenerator.ViewModel
{
    public class ClientModel : ViewModel
    {
        private string _email;
        private DateTime _date;
        private string _macAddress;
        private string _publicKey;
        private string _license;

        public string Email
        {
            get => _email;
            set => SetProperty(ref _email, value);
        }

        public DateTime Date
        {
            get => _date;
            set => SetProperty(ref _date, value);
        }

        public string MACAddress
        {
            get => _macAddress;
            set => SetProperty(ref _macAddress, value);
        }

        public string PublicKey
        {
            get => _publicKey;
            set => SetProperty(ref _publicKey, value);
        }

        public string License
        {
            get => _license;
            set => SetProperty(ref _license, value);
        }

        /// <summary>
        /// 获取本机MAC地址
        /// </summary>
        public void GetMACAddress()
        {
            MACAddress = NetworkInterface
                .GetAllNetworkInterfaces()
                .Where(nic =>
                    nic.OperationalStatus == OperationalStatus.Up &&
                    nic.NetworkInterfaceType != NetworkInterfaceType.Loopback)
                .Select(nic => nic.GetPhysicalAddress().ToString())
                .FirstOrDefault();
        }

        /// <summary>
        /// 激活授权
        /// </summary>
        public void ActivateLicense()
        {
            // 导入公钥
            // 公钥不能让用户输入，否则用户可以用自己的密钥伪造信息和签名通过验证
            var rsa = new RSACryptoServiceProvider();
            try
            {
                rsa.ImportFromPem(PublicKey.AsSpan());
            }
            catch (ArgumentException)
            {
                MessageBox.Show("公钥错误！");
                return;
            }

            // 对激活码进行解码
            byte[] licenseDecode;
            try
            {
                licenseDecode = Convert.FromBase64String(License);
            }
            catch (Exception e) when (e is FormatException or ArgumentNullException)
            {
                MessageBox.Show("激活码错误！请检查激活码后重试");
                return;
            }

            // 头两个字节是授权信息的长度
            var dataLen = (licenseDecode[0] << 8) + licenseDecode[1];
            // 授权信息
            var data = licenseDecode[2..(dataLen + 2)];
            // 授权信息的签名
            var dataSigned = licenseDecode[(dataLen + 2)..];
            // 验证签名与原始信息是否匹配
            if (!rsa.VerifyData(data, new SHA1CryptoServiceProvider(), dataSigned))
            {
                MessageBox.Show("激活码错误！请检查激活码后重试");
                return;
            }

            // 激活码为真，但还要做输入信息的验证
            var dataEntity = JsonSerializer.Deserialize(data, typeof(ClientModel)) as ClientModel;
            if (dataEntity?.Email != Email || dataEntity?.MACAddress != MACAddress)
            {
                MessageBox.Show("激活码与本机或输入信息不匹配！");
                return;
            }

            if (dataEntity?.Date < DateTime.Now)
            {
                MessageBox.Show("激活码已过期！请重新购买");
                return;
            }

            MessageBox.Show(@$"激活成功,授权给{dataEntity?.Email}，有效日期至{dataEntity?.Date.ToShortDateString()}");
        }
    }
}