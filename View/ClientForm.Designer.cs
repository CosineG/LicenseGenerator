
namespace LicenseGenerator.View
{
    partial class ClientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.btnActivate = new System.Windows.Forms.Button();
            this.tbLicense = new System.Windows.Forms.TextBox();
            this.lblLicense = new System.Windows.Forms.Label();
            this.tbPublicKey = new System.Windows.Forms.TextBox();
            this.lblPublicKey = new System.Windows.Forms.Label();
            this.tbMAC = new System.Windows.Forms.TextBox();
            this.lblMAC = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.grpInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.btnActivate);
            this.grpInfo.Controls.Add(this.tbLicense);
            this.grpInfo.Controls.Add(this.lblLicense);
            this.grpInfo.Controls.Add(this.tbPublicKey);
            this.grpInfo.Controls.Add(this.lblPublicKey);
            this.grpInfo.Controls.Add(this.tbMAC);
            this.grpInfo.Controls.Add(this.lblMAC);
            this.grpInfo.Controls.Add(this.tbEmail);
            this.grpInfo.Controls.Add(this.lblEmail);
            this.grpInfo.Location = new System.Drawing.Point(12, 12);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(550, 306);
            this.grpInfo.TabIndex = 10;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "密钥信息";
            // 
            // btnActivate
            // 
            this.btnActivate.Location = new System.Drawing.Point(435, 262);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(89, 37);
            this.btnActivate.TabIndex = 18;
            this.btnActivate.Text = "激活";
            this.btnActivate.UseVisualStyleBackColor = true;
            this.btnActivate.Click += new System.EventHandler(this.BtnActivate_Click);
            // 
            // tbLicense
            // 
            this.tbLicense.Location = new System.Drawing.Point(335, 27);
            this.tbLicense.Multiline = true;
            this.tbLicense.Name = "tbLicense";
            this.tbLicense.Size = new System.Drawing.Size(189, 229);
            this.tbLicense.TabIndex = 17;
            // 
            // lblLicense
            // 
            this.lblLicense.AutoSize = true;
            this.lblLicense.Location = new System.Drawing.Point(287, 30);
            this.lblLicense.Name = "lblLicense";
            this.lblLicense.Size = new System.Drawing.Size(44, 17);
            this.lblLicense.TabIndex = 16;
            this.lblLicense.Text = "激活码";
            // 
            // tbPublicKey
            // 
            this.tbPublicKey.Location = new System.Drawing.Point(91, 117);
            this.tbPublicKey.Multiline = true;
            this.tbPublicKey.Name = "tbPublicKey";
            this.tbPublicKey.ReadOnly = true;
            this.tbPublicKey.Size = new System.Drawing.Size(179, 139);
            this.tbPublicKey.TabIndex = 15;
            // 
            // lblPublicKey
            // 
            this.lblPublicKey.AutoSize = true;
            this.lblPublicKey.Location = new System.Drawing.Point(26, 120);
            this.lblPublicKey.Name = "lblPublicKey";
            this.lblPublicKey.Size = new System.Drawing.Size(32, 17);
            this.lblPublicKey.TabIndex = 14;
            this.lblPublicKey.Text = "公钥";
            // 
            // tbMAC
            // 
            this.tbMAC.Location = new System.Drawing.Point(91, 72);
            this.tbMAC.Name = "tbMAC";
            this.tbMAC.ReadOnly = true;
            this.tbMAC.Size = new System.Drawing.Size(179, 23);
            this.tbMAC.TabIndex = 13;
            // 
            // lblMAC
            // 
            this.lblMAC.AutoSize = true;
            this.lblMAC.Location = new System.Drawing.Point(25, 75);
            this.lblMAC.Name = "lblMAC";
            this.lblMAC.Size = new System.Drawing.Size(60, 17);
            this.lblMAC.TabIndex = 12;
            this.lblMAC.Text = "MAC地址";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(91, 27);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(179, 23);
            this.tbEmail.TabIndex = 9;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(26, 30);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 17);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "邮箱";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 332);
            this.Controls.Add(this.grpInfo);
            this.Name = "ClientForm";
            this.Text = "客户端";
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.TextBox tbPublicKey;
        private System.Windows.Forms.Label lblPublicKey;
        private System.Windows.Forms.TextBox tbMAC;
        private System.Windows.Forms.Label lblMAC;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbLicense;
        private System.Windows.Forms.Label lblLicense;
        private System.Windows.Forms.Button btnActivate;
    }
}