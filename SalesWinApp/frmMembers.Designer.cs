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
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.Label();
            this.lbReenteringPassword = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtReenteringPassword = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(66, 68);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(54, 25);
            this.lbEmail.TabIndex = 0;
            this.lbEmail.Text = "Email";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(66, 142);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(87, 25);
            this.lbPassword.TabIndex = 0;
            this.lbPassword.Text = "Password";
            // 
            // txtCity
            // 
            this.txtCity.AutoSize = true;
            this.txtCity.Location = new System.Drawing.Point(66, 350);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(42, 25);
            this.txtCity.TabIndex = 0;
            this.txtCity.Text = "City";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.AutoSize = true;
            this.txtCompanyName.Location = new System.Drawing.Point(66, 283);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(136, 25);
            this.txtCompanyName.TabIndex = 0;
            this.txtCompanyName.Text = "CompanyName";
            // 
            // txtCountry
            // 
            this.txtCountry.AutoSize = true;
            this.txtCountry.Location = new System.Drawing.Point(66, 426);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(75, 25);
            this.txtCountry.TabIndex = 0;
            this.txtCountry.Text = "Country";
            // 
            // lbReenteringPassword
            // 
            this.lbReenteringPassword.AutoSize = true;
            this.lbReenteringPassword.Location = new System.Drawing.Point(66, 216);
            this.lbReenteringPassword.Name = "lbReenteringPassword";
            this.lbReenteringPassword.Size = new System.Drawing.Size(176, 25);
            this.lbReenteringPassword.TabIndex = 0;
            this.lbReenteringPassword.Text = "Reentering Password";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(321, 496);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(112, 34);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "Regsister";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(483, 496);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(112, 34);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtReenteringPassword
            // 
            this.txtReenteringPassword.Location = new System.Drawing.Point(270, 213);
            this.txtReenteringPassword.Name = "txtReenteringPassword";
            this.txtReenteringPassword.Size = new System.Drawing.Size(382, 31);
            this.txtReenteringPassword.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(270, 280);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(382, 31);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(270, 347);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(382, 31);
            this.textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(270, 423);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(382, 31);
            this.textBox4.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(270, 139);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(382, 31);
            this.txtPassword.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(270, 65);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(382, 31);
            this.txtEmail.TabIndex = 1;
            // 
            // frmMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 605);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtReenteringPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lbReenteringPassword);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbEmail);
            this.Name = "frmMembers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.frmMembers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Label lbEmail;
    private Label lbPassword;
    private Label txtCity;
    private Label txtCompanyName;
    private Label txtCountry;
    private Label lbReenteringPassword;
    private Button btnRegister;
    private Button btnLogin;
    private TextBox txtReenteringPassword;
    private TextBox textBox2;
    private TextBox textBox3;
    private TextBox textBox4;
    private TextBox txtPassword;
    private TextBox txtEmail;
}
