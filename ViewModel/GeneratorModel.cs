using System;
using System.Security.Cryptography;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;

namespace LicenseGenerator.ViewModel
{
    public class GeneratorModel : ViewModel
    {
        private string _email;
        private DateTime _date;
        private string _macAddress;
        private string _privateKey;
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

        [JsonIgnore]
        public string PrivateKey
        {
            get => _privateKey;
            set => SetProperty(ref _privateKey, value);
        }

        [JsonIgnore]
        public string License
        {
            get => _license;
            set => SetProperty(ref _license, value);
        }

        public void GenerateLicense()
        {
            // 授权信息，为Json格式
            var data = JsonSerializer.SerializeToUtf8Bytes(this);
            // 导入私钥
            var rsa = new RSACryptoServiceProvider();
            try
            {
                rsa.ImportFromPem(PrivateKey.AsSpan());
            }
            catch (ArgumentException)
            {
                MessageBox.Show("私钥错误！");
                return;
            }

            // 密钥由授权信息长度+授权信息+授权信息签名组成，以Base64的形式呈现
            // 用2个byte来存储信息长度
            var dataLen = data.Length;
            var dataLenByte = new byte[] {(byte) (dataLen >> 8), (byte) dataLen};
            var dataSigned = rsa.SignData(data, new SHA1CryptoServiceProvider());
            var dataCombined = new byte[dataLenByte.Length + data.Length + dataSigned.Length];
            dataLenByte.CopyTo(dataCombined, 0);
            data.CopyTo(dataCombined, dataLenByte.Length);
            dataSigned.CopyTo(dataCombined, dataLenByte.Length + data.Length);
            License = Convert.ToBase64String(dataCombined);
        }
    }
}