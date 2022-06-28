using BusinessObject;
using DataAccess.AppConfig;
using DataAccess.Repository;
using SalesWinApp.Utils;

namespace SalesWinApp;

public partial class frmLogin : Form
{
    private const char PASSWORD_CHAR = '\u25CF';
    public IMemberRepository _memberRepository { get; set; } = MemberRepository.Instance;
    private readonly AdminAccount Admin = AppSettings.Instance.AdminAccount;
    public frmLogin()
    {
        InitializeComponent();
    }

    private void frmLogin_Load(object sender, EventArgs e)
    {
        txtEmail.Select();
        txtPassword.PasswordChar = PASSWORD_CHAR;
    }

    private async void btnLogin_Click(object sender, EventArgs e)
    {
        if (!ValidateChildren(ValidationConstraints.Enabled)) return;

        if (txtEmail.Text.Equals(Admin.Email) && txtPassword.Text.Equals(Admin.Password))
        {
            MessageBox.Show($"Welcome {Admin.Email}");
            Hide();
        }

        MemberObject user = await _memberRepository.FindByIdAsync(txtEmail.Text);
        if (user is null)
        {
            MessageBox.Show("Account not found");
        }
        MessageBox.Show($"Welcome {user.Email}");
        Hide();
    }

    private void btnRegister_Click(object sender, EventArgs e)
    {
        frmMembers frmMembers = new frmMembers();
        frmMembers.Show();
    }

    private void txtEmail_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {
        txtEmail.txtbox_Validating(lbEmail, errorEmailProvider, e);
    }

    private void txtPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {
        txtPassword.txtbox_Validating(lbPassword, errorPasswordProvider, e);
    }
}
