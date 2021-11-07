
namespace LicenseGenerator.View
{
    partial class GeneratorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.tbPrivateKey = new System.Windows.Forms.TextBox();
            this.lblPrivateKey = new System.Windows.Forms.Label();
            this.tbMAC = new System.Windows.Forms.TextBox();
            this.lblMAC = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.grpLicense = new System.Windows.Forms.GroupBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.tbLicense = new System.Windows.Forms.TextBox();
            this.grpInfo.SuspendLayout();
            this.grpLicense.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.dtpDate);
            this.grpInfo.Controls.Add(this.tbPrivateKey);
            this.grpInfo.Controls.Add(this.lblPrivateKey);
            this.grpInfo.Controls.Add(this.tbMAC);
            this.grpInfo.Controls.Add(this.lblMAC);
            this.grpInfo.Controls.Add(this.lblDate);
            this.grpInfo.Controls.Add(this.tbEmail);
            this.grpInfo.Controls.Add(this.lblEmail);
            this.grpInfo.Location = new System.Drawing.Point(12, 12);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(296, 334);
            this.grpInfo.TabIndex = 9;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "密钥信息";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(91, 72);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(179, 23);
            this.dtpDate.TabIndex = 16;
            // 
            // tbPrivateKey
            // 
            this.tbPrivateKey.Location = new System.Drawing.Point(26, 185);
            this.tbPrivateKey.Multiline = true;
            this.tbPrivateKey.Name = "tbPrivateKey";
            this.tbPrivateKey.Size = new System.Drawing.Size(244, 132);
            this.tbPrivateKey.TabIndex = 15;
            // 
            // lblPrivateKey
            // 
            this.lblPrivateKey.AutoSize = true;
            this.lblPrivateKey.Location = new System.Drawing.Point(26, 165);
            this.lblPrivateKey.Name = "lblPrivateKey";
            this.lblPrivateKey.Size = new System.Drawing.Size(32, 17);
            this.lblPrivateKey.TabIndex = 14;
            this.lblPrivateKey.Text = "私钥";
            // 
            // tbMAC
            // 
            this.tbMAC.Location = new System.Drawing.Point(91, 117);
            this.tbMAC.Name = "tbMAC";
            this.tbMAC.Size = new System.Drawing.Size(179, 23);
            this.tbMAC.TabIndex = 13;
            // 
            // lblMAC
            // 
            this.lblMAC.AutoSize = true;
            this.lblMAC.Location = new System.Drawing.Point(26, 120);
            this.lblMAC.Name = "lblMAC";
            this.lblMAC.Size = new System.Drawing.Size(60, 17);
            this.lblMAC.TabIndex = 12;
            this.lblMAC.Text = "MAC地址";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(26, 75);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(56, 17);
            this.lblDate.TabIndex = 10;
            this.lblDate.Text = "有效日期";
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
            // grpLicense
            // 
            this.grpLicense.Controls.Add(this.btnGenerate);
            this.grpLicense.Controls.Add(this.tbLicense);
            this.grpLicense.Location = new System.Drawing.Point(315, 13);
            this.grpLicense.Name = "grpLicense";
            this.grpLicense.Size = new System.Drawing.Size(200, 333);
            this.grpLicense.TabIndex = 10;
            this.grpLicense.TabStop = false;
            this.grpLicense.Text = "激活码";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(41, 279);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(126, 37);
            this.btnGenerate.TabIndex = 17;
            this.btnGenerate.Text = "生成";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // tbLicense
            // 
            this.tbLicense.Location = new System.Drawing.Point(18, 22);
            this.tbLicense.Multiline = true;
            this.tbLicense.Name = "tbLicense";
            this.tbLicense.Size = new System.Drawing.Size(165, 251);
            this.tbLicense.TabIndex = 16;
            // 
            // GeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 358);
            this.Controls.Add(this.grpLicense);
            this.Controls.Add(this.grpInfo);
            this.Name = "GeneratorForm";
            this.Text = "激活码生成器";
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.grpLicense.ResumeLayout(false);
            this.grpLicense.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox tbPrivateKey;
        private System.Windows.Forms.Label lblPrivateKey;
        private System.Windows.Forms.TextBox tbMAC;
        private System.Windows.Forms.Label lblMAC;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.GroupBox grpLicense;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox tbLicense;
    }
}

