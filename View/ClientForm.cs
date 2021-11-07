using System;
using System.Windows.Forms;
using LicenseGenerator.ViewModel;

namespace LicenseGenerator.View
{
    public partial class ClientForm : Form
    {
        private readonly ClientModel _model = new ClientModel();

        public ClientForm()
        {
            InitializeComponent();
            BindData();
        }

        /// <summary>
        /// 参数绑定
        /// </summary>
        private void BindData()
        {
            tbEmail.DataBindings.Add("Text", _model, nameof(_model.Email));
            // 得到mac地址
            _model.GetMACAddress();
            tbMAC.DataBindings.Add("Text", _model, nameof(_model.MACAddress));
            // 示例用公钥
            _model.PublicKey = @"-----BEGIN PUBLIC KEY----- MIGeMA0GCSqGSIb3DQEBAQUAA4GMADCBiAKBgGFPnrvYFsHG3+NAFcVf4czqpdFX Of/eQyyFTUxwm4qjPJGLpm/agh5U3gUS6E5t9QHHSpN6hf3g8qIMgblDtTSltU4r mWEf3C8JoHK9fSsJeo2JadOSoJj8YBTPFjOTNz7/PkS0F+Sn/8to/ybzt8tUReT9 5Fxi4JWkJyxQpcWnAgMBAAE= -----END PUBLIC KEY-----";
            tbPublicKey.DataBindings.Add("Text", _model, nameof(_model.PublicKey));
            tbLicense.DataBindings.Add("Text", _model, nameof(_model.License));
        }

        private void BtnActivate_Click(object sender, EventArgs e)
        {
            _model.ActivateLicense();
        }
    }
}