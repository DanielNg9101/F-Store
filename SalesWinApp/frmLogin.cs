using BusinessObject;
using DataAccess;
using DataAccess.AppConfig;
using DataAccess.Contexts;
using DataAccess.Repository;

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
        if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtPassword.Text))
        {
            MessageBox.Show("Uncorrect email or password");
            return;
        }

        if (txtEmail.Text.Equals(Admin.Email) && txtPassword.Text.Equals(Admin.Password))
        {
            MessageBox.Show("Welcome admin");
            Close();
        }

        MemberObject user = await _memberRepository.GetUser(txtEmail.Text);
        if (user is null)
        {
            MessageBox.Show("Account not found");
            return;
        }
        MessageBox.Show("Welcome admin");
        Close();
    }

    private void btnRegister_Click(object sender, EventArgs e)
    {

    }
}
