namespace RDPAssistance
{
    partial class RDPAssistance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RDPAssistance));
            this.picTopImage = new System.Windows.Forms.PictureBox();
            this.lstCompaniesList = new System.Windows.Forms.ListBox();
            this.cboCompanyUsers = new System.Windows.Forms.ComboBox();
            this.pnlUserInfo = new System.Windows.Forms.Panel();
            this.lblHost = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblDomain = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtDomain = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlData = new System.Windows.Forms.Panel();
            this.lblCompanyUsers = new System.Windows.Forms.Label();
            this.lblCompaniesList = new System.Windows.Forms.Label();
            this.chkSavePosition = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picTopImage)).BeginInit();
            this.pnlUserInfo.SuspendLayout();
            this.pnlData.SuspendLayout();
            this.SuspendLayout();
            // 
            // picTopImage
            // 
            this.picTopImage.Image = ((System.Drawing.Image)(resources.GetObject("picTopImage.Image")));
            this.picTopImage.Location = new System.Drawing.Point(0, 0);
            this.picTopImage.Name = "picTopImage";
            this.picTopImage.Size = new System.Drawing.Size(409, 70);
            this.picTopImage.TabIndex = 0;
            this.picTopImage.TabStop = false;
            this.picTopImage.Click += new System.EventHandler(this.picTopImage_Click);
            // 
            // lstCompaniesList
            // 
            this.lstCompaniesList.FormattingEnabled = true;
            this.lstCompaniesList.Location = new System.Drawing.Point(3, 24);
            this.lstCompaniesList.Name = "lstCompaniesList";
            this.lstCompaniesList.Size = new System.Drawing.Size(157, 147);
            this.lstCompaniesList.TabIndex = 1;
            this.lstCompaniesList.SelectedIndexChanged += new System.EventHandler(this.lstCompaniesList_SelectedIndexChanged);
            // 
            // cboCompanyUsers
            // 
            this.cboCompanyUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCompanyUsers.FormattingEnabled = true;
            this.cboCompanyUsers.Location = new System.Drawing.Point(227, 11);
            this.cboCompanyUsers.Name = "cboCompanyUsers";
            this.cboCompanyUsers.Size = new System.Drawing.Size(167, 21);
            this.cboCompanyUsers.TabIndex = 2;
            this.cboCompanyUsers.SelectedIndexChanged += new System.EventHandler(this.cboCompanyUsers_SelectedIndexChanged);
            // 
            // pnlUserInfo
            // 
            this.pnlUserInfo.Controls.Add(this.lblHost);
            this.pnlUserInfo.Controls.Add(this.txtHost);
            this.pnlUserInfo.Controls.Add(this.lblPassword);
            this.pnlUserInfo.Controls.Add(this.lblUser);
            this.pnlUserInfo.Controls.Add(this.lblDomain);
            this.pnlUserInfo.Controls.Add(this.txtPassword);
            this.pnlUserInfo.Controls.Add(this.txtUser);
            this.pnlUserInfo.Controls.Add(this.txtDomain);
            this.pnlUserInfo.Location = new System.Drawing.Point(166, 38);
            this.pnlUserInfo.Name = "pnlUserInfo";
            this.pnlUserInfo.Size = new System.Drawing.Size(231, 133);
            this.pnlUserInfo.TabIndex = 4;
            // 
            // lblHost
            // 
            this.lblHost.Location = new System.Drawing.Point(3, 9);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(57, 20);
            this.lblHost.TabIndex = 11;
            this.lblHost.Text = "Host";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(61, 9);
            this.txtHost.Name = "txtHost";
            this.txtHost.ReadOnly = true;
            this.txtHost.Size = new System.Drawing.Size(167, 20);
            this.txtHost.TabIndex = 10;
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(3, 94);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(57, 20);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "Password";
            // 
            // lblUser
            // 
            this.lblUser.Location = new System.Drawing.Point(3, 65);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(57, 21);
            this.lblUser.TabIndex = 8;
            this.lblUser.Text = "Usuario";
            // 
            // lblDomain
            // 
            this.lblDomain.Location = new System.Drawing.Point(3, 36);
            this.lblDomain.Name = "lblDomain";
            this.lblDomain.Size = new System.Drawing.Size(57, 20);
            this.lblDomain.TabIndex = 7;
            this.lblDomain.Text = "Dominio";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(61, 94);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(167, 20);
            this.txtPassword.TabIndex = 2;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(61, 65);
            this.txtUser.Name = "txtUser";
            this.txtUser.ReadOnly = true;
            this.txtUser.Size = new System.Drawing.Size(167, 20);
            this.txtUser.TabIndex = 1;
            // 
            // txtDomain
            // 
            this.txtDomain.Location = new System.Drawing.Point(61, 36);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.ReadOnly = true;
            this.txtDomain.Size = new System.Drawing.Size(167, 20);
            this.txtDomain.TabIndex = 0;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(250, 263);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "Conectar";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(331, 263);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlData
            // 
            this.pnlData.BackColor = System.Drawing.SystemColors.Window;
            this.pnlData.Controls.Add(this.lblCompanyUsers);
            this.pnlData.Controls.Add(this.lblCompaniesList);
            this.pnlData.Controls.Add(this.lstCompaniesList);
            this.pnlData.Controls.Add(this.cboCompanyUsers);
            this.pnlData.Controls.Add(this.pnlUserInfo);
            this.pnlData.Location = new System.Drawing.Point(0, 76);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(406, 179);
            this.pnlData.TabIndex = 7;
            // 
            // lblCompanyUsers
            // 
            this.lblCompanyUsers.Location = new System.Drawing.Point(166, 12);
            this.lblCompanyUsers.Name = "lblCompanyUsers";
            this.lblCompanyUsers.Size = new System.Drawing.Size(60, 20);
            this.lblCompanyUsers.TabIndex = 6;
            this.lblCompanyUsers.Text = "Usuarios";
            // 
            // lblCompaniesList
            // 
            this.lblCompaniesList.Location = new System.Drawing.Point(3, 1);
            this.lblCompaniesList.Name = "lblCompaniesList";
            this.lblCompaniesList.Size = new System.Drawing.Size(157, 20);
            this.lblCompaniesList.TabIndex = 5;
            this.lblCompaniesList.Text = "Empresas";
            this.lblCompaniesList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkSavePosition
            // 
            this.chkSavePosition.AutoSize = true;
            this.chkSavePosition.Location = new System.Drawing.Point(6, 263);
            this.chkSavePosition.Name = "chkSavePosition";
            this.chkSavePosition.Size = new System.Drawing.Size(115, 17);
            this.chkSavePosition.TabIndex = 8;
            this.chkSavePosition.Text = "Guardar posición...";
            this.chkSavePosition.UseVisualStyleBackColor = true;
            // 
            // RDPAssistance
            // 
            this.AcceptButton = this.btnConnect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(407, 291);
            this.Controls.Add(this.chkSavePosition);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.picTopImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RDPAssistance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asistente de Conexión a Escritorio remoto";
            this.Load += new System.EventHandler(this.RDPAssistance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picTopImage)).EndInit();
            this.pnlUserInfo.ResumeLayout(false);
            this.pnlUserInfo.PerformLayout();
            this.pnlData.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picTopImage;
        private System.Windows.Forms.ListBox lstCompaniesList;
        private System.Windows.Forms.ComboBox cboCompanyUsers;
        private System.Windows.Forms.Panel pnlUserInfo;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtDomain;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.Label lblCompaniesList;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblDomain;
        private System.Windows.Forms.Label lblCompanyUsers;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.CheckBox chkSavePosition;
    }
}

