using System;
using System.Windows.Forms;
using LicenseGenerator.ViewModel;

namespace LicenseGenerator.View
{
    public partial class GeneratorForm : Form
    {
        private readonly GeneratorModel _model = new GeneratorModel();

        public GeneratorForm()
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
            // 有效期默认一年
            _model.Date = DateTime.Now.AddYears(1);
            dtpDate.DataBindings.Add("Value", _model, nameof(_model.Date));
            tbMAC.DataBindings.Add("Text", _model, nameof(_model.MACAddress));
            // 示例用私钥
            _model.PrivateKey = @"-----BEGIN RSA PRIVATE KEY----- MIICWwIBAAKBgGFPnrvYFsHG3+NAFcVf4czqpdFXOf/eQyyFTUxwm4qjPJGLpm/a gh5U3gUS6E5t9QHHSpN6hf3g8qIMgblDtTSltU4rmWEf3C8JoHK9fSsJeo2JadOS oJj8YBTPFjOTNz7/PkS0F+Sn/8to/ybzt8tUReT95Fxi4JWkJyxQpcWnAgMBAAEC gYAi0/xb/tsmP6eiDi28lrSaQuFWK4H2sfYY2RzxXtxMol/rN7A6GFq5wGY2Kq46 Y+Bs4ocugYuzce9lUFSdmj4gSLJSao2MU/7W5PiML+qYWTnXH19Kl777xkXaDOVI gT8Xu65jnUC1xxzqvAqMH+lIoaI+r0RymGnBkNwWrxdoAQJBAJ9WrN6AIMBRmDaH tobaEYWK+YUK/UZThousyBQ02DFGgq/L6FyGD4HPkQzletab6Hux4JpNDgjUD4gw xnN7qgcCQQCcWAw0pswOZMBX/gFFwWTpXnYOQQrIh4ht434ebHlYxub50FEJ/TGd bYBJW5dk0hnohmSXPuzyAyjrF9fyUJ9hAkAFq3PjRvPjZAPijNm12rSc5+ERFt8E TZyQA8nqziaTOksULlFKWYrbt6MVrmS8ljejjyTK2MsTDViwI+wr186pAkAdNOma 0GogajvwdDgiot1KJ2ZghVARZBhdhvkhj9wfdJDjrEHnXtBs+27SxXSD1igW4zxZ cNzs3SBAwuSJlPwhAkEAnqGIRk7093CALK3jUKtBH/xkXPeZhVTABNbIHuiec00M EDOCN0Fnba5EDT18hqHKfGpTK1hvnk8gA5vatZFyfA== -----END RSA PRIVATE KEY-----";
            tbPrivateKey.DataBindings.Add("Text", _model, nameof(_model.PrivateKey));
            tbLicense.DataBindings.Add("Text", _model, nameof(_model.License));
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            _model.GenerateLicense();
        }
    }
}