using BusinessObject;
using DataAccess.Repository;
using SalesWinApp.Utils;
using System.ComponentModel.DataAnnotations;

namespace SalesWinApp;
public partial class frmRegister : Form
{
    private const char PASSWORD_CHAR = '\u25CF';
    private readonly IMemberRepository _memberRepository;

    public frmRegister()
    {
        _memberRepository = MemberRepository.Instance;
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
            MemberObject entity = (MemberObject)userBindingSource.Current;
            bool isExist = (await _memberRepository.FindByEmailAsync(entity.Email)) != null;
            if (isExist)
            {
                throw new Exception($"{entity.Email} has already exist");
            }

            var errors = Validations.ValidateBindingSource(entity,userBindingSource);
            if (errors.Any())
            {
                foreach (ValidationResult result in errors)
                {
                    throw new ArgumentException(result.ErrorMessage);
                }
            }

            if (!txtPassword.Text.Equals(txtReenteredPassword.Text))
            {
                throw new Exception("Password must be match");
            }
            await _memberRepository.CreateAsync(entity);
            MessageBox.Show("Register success! Click Ok to login", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
            Hide();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
