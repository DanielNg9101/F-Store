using BusinessObject;
using DataAccess.Repository;
using SalesWinApp.Utils;
using System.ComponentModel.DataAnnotations;

namespace SalesWinApp;
public partial class frmMembers : Form
{
    private const char PASSWORD_CHAR = '\u25CF';
    private readonly IMemberRepository _memberRepository = (IMemberRepository)MemberRepository.Instance;

    public frmMembers()
    {
        InitializeComponent();
    }
    public void frmMembers_Load(object sender, EventArgs e)
    {
        txtPassword.PasswordChar = PASSWORD_CHAR;
        txtReenteredPassword.PasswordChar = PASSWORD_CHAR;

        BindingSource source = new BindingSource();
        source.DataSource = new MemberObject();

        txtEmail.DataBindings.Clear();
        txtPassword.DataBindings.Clear();
        txtCountry.DataBindings.Clear();
        txtCompanyName.DataBindings.Clear();
        txtCity.DataBindings.Clear();
        txtReenteredPassword.Text = string.Empty;


        txtEmail.DataBindings.Add("Text", source, "Email");
        txtPassword.DataBindings.Add("Text", source, "Password");
        txtCountry.DataBindings.Add("Text", source, "Country");
        txtCompanyName.DataBindings.Add("Text", source, "CompanyName");
        txtCity.DataBindings.Add("Text", source, "City");

        userBindingSource.DataSource = null;
        userBindingSource.DataSource = source;

    }

    public void ClearTextAndDataBindings()
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
        try
        {
            var errors = Validations.ValidateBindingSource<MemberObject>(userBindingSource);
            if (errors.Any())
            {
                foreach (ValidationResult result in errors)
                {
                    /*MessageBox.Show(result.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;*/
                    throw new ArgumentException(result.ErrorMessage);
                }
            }

            if (!txtPassword.Text.Equals(txtReenteredPassword.Text))
            {
                throw new Exception("Password must be match");
            }

            MemberObject entity = new MemberObject
            {
                Email = txtEmail.Text,
                CompanyName = lbCompanyName.Text,
                City = lbCity.Text,
                Country = lbCountry.Text,
                Password = txtPassword.Text,
            };
            await _memberRepository.CreateAsync(entity);
            MessageBox.Show("Register success! Click Ok to login", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
            Hide();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}
