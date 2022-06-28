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
        txtPassword.PasswordChar = PASSWORD_CHAR;
    }

    private async void btnLogin_Click(object sender, EventArgs e)
    {
        if (!txtEmail.txtbox_Validating(lbEmail, errorEmailProvider) 
            ||
            !txtPassword.txtbox_Validating(lbPassword, errorPasswordProvider))
            return;

        if (txtEmail.Text.Equals(Admin.Email) && txtPassword.Text.Equals(Admin.Password))
        {
            MessageBox.Show($"Welcome {Admin.Email}");
            Hide();
        }

        MemberObject user = await _memberRepository.FindByIdAsync(txtEmail.Text);
        if (user is null)
        {
            MessageBox.Show("Account not found");
            return;
        }
        MessageBox.Show($"Welcome {user.Email}");
        Hide();
    }

    private void btnRegister_Click(object sender, EventArgs e)
    {
        frmContainer mdiParent = (frmContainer)MdiParent;
        mdiParent.frmMembers.ClearText();
        mdiParent.frmMembers.Show();
    }

    private void txtEmail_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            btnLogin.PerformClick();
        }
    }

    private void txtPassword_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            btnLogin.PerformClick();
        }
    }
}
