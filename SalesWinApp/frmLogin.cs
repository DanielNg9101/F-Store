using BusinessObject;
using DataAccess.AppConfig;
using DataAccess.Repository;
using SalesWinApp.Utils;

namespace SalesWinApp;

public partial class frmLogin : Form
{
    private const char PASSWORD_CHAR = '\u25CF';
    private readonly AdminAccount Admin = AppSettings.Instance.AdminAccount;

    private IMemberRepository _memberRepository;

    public frmLogin()
    {
        _memberRepository = MemberRepository.Instance;
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
            ((frmMain)MdiParent).isAuthorized = true;// set authorized for admin
            Hide();
            LoadProductForm();
            return;
        }
        try
        {
            Member user = await _memberRepository.FindByEmailAsync(txtEmail.Text);
            if (user is null)
            {
                throw new Exception("Account not found");
            }
            if (!user.Password.Equals(txtPassword.Text))
            {
                throw new Exception("Incorrect email or password");
            }
            /*MessageBox.Show($"Welcome {user.Email}");*/
            Hide();
            LoadProductForm();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void btnRegister_Click(object sender, EventArgs e)
    {
        frmMain mdiParent = (frmMain)MdiParent;
        frmRegister frmRegister = new frmRegister();
        mdiParent.frmMembers = frmRegister;
        FrmLayout.CenterFormFromParent(mdiParent, frmRegister);
        frmRegister.Show();
    }

    private void LoadProductForm()
    {
        frmMain mdiParent = (frmMain)MdiParent;
        frmProducts frmProducts = new();
        mdiParent.frmProducts = frmProducts;
        FrmLayout.CenterFormFromParent(mdiParent, frmProducts);
        frmProducts.Show();
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
