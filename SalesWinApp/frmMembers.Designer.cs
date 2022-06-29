namespace SalesWinApp;

partial class frmMembers
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
            this.components = new System.ComponentModel.Container();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbCity = new System.Windows.Forms.Label();
            this.lbCompanyName = new System.Windows.Forms.Label();
            this.lbCountry = new System.Windows.Forms.Label();
            this.lbReenteredPassword = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtReenteredPassword = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.errorEmailProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPasswordProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorReenteredPasswordProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCompanyProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCityProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCountryProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorEmailProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPasswordProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorReenteredPasswordProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCompanyProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCityProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCountryProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(46, 41);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(36, 15);
            this.lbEmail.TabIndex = 0;
            this.lbEmail.Text = "Email";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(46, 85);
            this.lbPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(57, 15);
            this.lbPassword.TabIndex = 0;
            this.lbPassword.Text = "Password";
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Location = new System.Drawing.Point(46, 210);
            this.lbCity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(28, 15);
            this.lbCity.TabIndex = 0;
            this.lbCity.Text = "City";
            // 
            // lbCompanyName
            // 
            this.lbCompanyName.AutoSize = true;
            this.lbCompanyName.Location = new System.Drawing.Point(46, 170);
            this.lbCompanyName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCompanyName.Name = "lbCompanyName";
            this.lbCompanyName.Size = new System.Drawing.Size(91, 15);
            this.lbCompanyName.TabIndex = 0;
            this.lbCompanyName.Text = "CompanyName";
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Location = new System.Drawing.Point(46, 256);
            this.lbCountry.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(50, 15);
            this.lbCountry.TabIndex = 0;
            this.lbCountry.Text = "Country";
            // 
            // lbReenteredPassword
            // 
            this.lbReenteredPassword.AutoSize = true;
            this.lbReenteredPassword.Location = new System.Drawing.Point(46, 130);
            this.lbReenteredPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbReenteredPassword.Name = "lbReenteredPassword";
            this.lbReenteredPassword.Size = new System.Drawing.Size(105, 15);
            this.lbReenteredPassword.TabIndex = 0;
            this.lbReenteredPassword.Text = "Re-enter Password";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(225, 298);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(78, 30);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(338, 298);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(78, 30);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtReenteredPassword
            // 
            this.txtReenteredPassword.Location = new System.Drawing.Point(189, 128);
            this.txtReenteredPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtReenteredPassword.Name = "txtReenteredPassword";
            this.txtReenteredPassword.Size = new System.Drawing.Size(269, 23);
            this.txtReenteredPassword.TabIndex = 3;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(189, 168);
            this.txtCompanyName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(269, 23);
            this.txtCompanyName.TabIndex = 4;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(189, 208);
            this.txtCity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(269, 23);
            this.txtCity.TabIndex = 5;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(189, 254);
            this.txtCountry.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(269, 23);
            this.txtCountry.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(189, 83);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(269, 23);
            this.txtPassword.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(189, 39);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(269, 23);
            this.txtEmail.TabIndex = 1;
            // 
            // errorEmailProvider
            // 
            this.errorEmailProvider.ContainerControl = this;
            // 
            // errorPasswordProvider
            // 
            this.errorPasswordProvider.ContainerControl = this;
            // 
            // errorReenteredPasswordProvider
            // 
            this.errorReenteredPasswordProvider.ContainerControl = this;
            // 
            // errorCompanyProvider
            // 
            this.errorCompanyProvider.ContainerControl = this;
            // 
            // errorCityProvider
            // 
            this.errorCityProvider.ContainerControl = this;
            // 
            // errorCountryProvider
            // 
            this.errorCountryProvider.ContainerControl = this;
            // 
            // frmMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 363);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtReenteredPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lbCountry);
            this.Controls.Add(this.lbCompanyName);
            this.Controls.Add(this.lbCity);
            this.Controls.Add(this.lbReenteredPassword);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbEmail);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmMembers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.frmMembers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorEmailProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPasswordProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorReenteredPasswordProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCompanyProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCityProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCountryProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Label lbEmail;
    private Label lbPassword;
    private Label lbCity;
    private Label lbCompanyName;
    private Label lbCountry;
    private Label lbReenteredPassword;
    private Button btnRegister;
    private Button btnLogin;
    private TextBox txtReenteredPassword;
    private TextBox txtCompanyName;
    private TextBox txtCity;
    private TextBox txtCountry;
    private TextBox txtPassword;
    private TextBox txtEmail;
    private ErrorProvider errorEmailProvider;
    private ErrorProvider errorPasswordProvider;
    private ErrorProvider errorReenteredPasswordProvider;
    private ErrorProvider errorCompanyProvider;
    private ErrorProvider errorCityProvider;
    private ErrorProvider errorCountryProvider;
    private BindingSource userBindingSource;
}
