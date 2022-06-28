using BusinessObject;
using DataAccess.Repository;
using SalesWinApp.Utils;

namespace SalesWinApp;
public partial class frmMembers : Form
{
    private const char PASSWORD_CHAR = '\u25CF';
    private readonly IMemberRepository _memberRepository = MemberRepository.Instance;

    public frmMembers()
    {
        InitializeComponent();
    }

    public void frmMembers_Load(object sender, EventArgs e)
    {
        txtPassword.PasswordChar = PASSWORD_CHAR;
        txtReenteredPassword.PasswordChar = PASSWORD_CHAR;
    }

    public void ClearText()
    {
        txtEmail.Text = string.Empty;
        txtPassword.Text = string.Empty;
        txtReenteredPassword.Text = string.Empty;
        txtCity.Text = string.Empty;
        txtCompanyName.Text = string.Empty;
        txtCountry.Text = string.Empty;
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        Hide();
    }

    private async void btnRegister_Click(object sender, EventArgs e)
    {
        if (
            !(txtEmail.txtbox_Validating(lbEmail, errorEmailProvider)
              &&
              txtEmail.MinLength(lbEmail, errorEmailProvider, 3)
              && txtEmail.MaxLength(lbEmail, errorEmailProvider, 100)
              )
            ||
            !(txtPassword.txtbox_Validating(lbPassword, errorPasswordProvider)
              &&
              txtPassword.MinLength(lbPassword, errorPasswordProvider, 3)
              &&
              txtPassword.MaxLength(lbPassword, errorPasswordProvider, 30)
              )
            ||
            !(txtReenteredPassword.txtbox_Validating(lbPassword, errorReenteredPasswordProvider)
              &&
              txtReenteredPassword.MinLength(lbReenteredPassword, errorReenteredPasswordProvider, 3)
              &&
              txtPassword.MaxLength(lbReenteredPassword, errorReenteredPasswordProvider, 30)
              )
            ||
            !(txtCompanyName.txtbox_Validating(lbCompanyName, errorCompanyProvider)
              &&
              txtCompanyName.MinLength(lbCompanyName, errorCompanyProvider, 3)
              &&
              txtCompanyName.MaxLength(lbCompanyName, errorCompanyProvider, 40)
              )
            ||
            !(txtCountry.txtbox_Validating(lbCountry, errorCountryProvider)
              &&
              txtCountry.MinLength(lbPassword, errorCountryProvider, 3)
              &&
              txtCountry.MaxLength(lbPassword, errorCountryProvider, 15)
              )
            ||
            !(txtCity.txtbox_Validating(lbPassword, errorPasswordProvider)
              &&
              txtCity.MinLength(lbPassword, errorPasswordProvider, 3)
              &&
              txtCity.MaxLength(lbPassword, errorPasswordProvider, 15)
              )
            )
            return;

        try
        {
            MemberObject entity = new MemberObject
            {
                Email = txtEmail.Text,
                CompanyName = lbCompanyName.Text,
                City = lbCity.Text,
                Country = lbCountry.Text,
                Password = txtPassword.Text,
            };
            await _memberRepository.CreateAsync(entity);
            MessageBox.Show("Register success! Click Ok to login");
            Hide();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
}
