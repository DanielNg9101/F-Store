using SalesWinApp.Utils;

namespace SalesWinApp;
public partial class frmMain : Form
{
    public frmLogin frmLogin;
    public frmMembers frmMembers;
    public frmProducts frmProducts;

    public bool isAuthorized { get; set; } = false;
    public frmMain()
    {
        frmLogin = new();
        frmMembers = new();
        frmProducts = new();

        InitializeComponent();
    }

    private void frmContainer_Load(object sender, EventArgs e)
    {
        frmLogin.MdiParent = this;
        frmLogin.Location = frmLogin.CenterParent(this);
        frmLogin.Show();

        frmMembers.MdiParent = this;
        frmMembers.Location = frmMembers.CenterParent(this);

        frmProducts.MdiParent= this;
        frmProducts.Location = frmProducts.CenterParent(this);
    }
}
