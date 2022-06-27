using DataAccess.Contexts;

namespace SalesWinApp;

public partial class frmLogin : Form
{
    public frmLogin()
    {
        InitializeComponent();
    }

    private void frmLogin_Load(object sender, EventArgs e)
    {
        ApplicationDbContext applicationDbContext = new ApplicationDbContext();
    }
}
