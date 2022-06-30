using BusinessObject;
using SalesWinApp.Utils;

namespace SalesWinApp;
public partial class frmMain : Form
{
    public frmLogin frmLogin;
    public frmRegister frmMembers;
    public frmProducts frmProducts;
    public frmProductDetail frmProductDetail;

    public bool isAuthorized { get; set; } = false;
    public frmMain()
    {
        frmLogin = new();
        frmMembers = new();
        frmProducts = new();
        frmProductDetail = new frmProductDetail { Product = new Product() };

        InitializeComponent();
    }

    private void frmContainer_Load(object sender, EventArgs e)
    {
        FrmLayout.CenterFormFromParent(this, frmLogin);
        frmLogin.Show();

        FrmLayout.CenterFormFromParent(this, frmMembers);
        FrmLayout.CenterFormFromParent(this, frmProducts);
        FrmLayout.CenterFormFromParent(this, frmProductDetail);
        FrmLayout.CenterFormFromParent(this, frmLogin);
    }
}
