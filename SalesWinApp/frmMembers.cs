using BusinessObject;
using DataAccess.Repository;

namespace SalesWinApp;
public partial class frmMembers : Form
{
    private const char PASSWORD_CHAR = '\u25CF';
    private readonly IMemberRepository _memberRepository = MemberRepository.Instance;

    public frmMembers()
    {
        InitializeComponent();
    }

    private void frmMembers_Load(object sender, EventArgs e)
    {
        txtPassword.PasswordChar = PASSWORD_CHAR;
        txtReenteringPassword.PasswordChar = PASSWORD_CHAR;
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        Hide();
    }

    private async void btnRegister_Click(object sender, EventArgs e)
    {
        try
        {
            MemberObject entity = new MemberObject
            {
                Email = txtEmail.Text,
                CompanyName = txtCompanyName.Text,
                City = txtCity.Text,
                Country = txtCountry.Text,
                Password = txtPassword.Text,
            };
            await _memberRepository.CreateAsync(entity);
            MessageBox.Show("Register success! Click Ok to login");
            Hide();
        }
        catch
        {
            MessageBox.Show("Email is already exist");
        }
    }
}
