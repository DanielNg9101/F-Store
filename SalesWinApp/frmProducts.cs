using DataAccess.Contexts;

namespace SalesWinApp;
public partial class frmProducts : Form
{
    private readonly ApplicationDbContext _context = ApplicationDbContext.Instance;
    public frmProducts()
    {
        InitializeComponent();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {

    }

    private void btnDelete_Click(object sender, EventArgs e)
    {

    }

    private void frmProducts_Load(object sender, EventArgs e)
    {

    }
}
