using DataAccess.Contexts;
using DataAccess.Repository;
using SalesWinApp.Utils;

namespace SalesWinApp;
public partial class frmProducts : Form
{
    private readonly IProductRepository _productRepository;
    public frmProducts()
    {
        _productRepository = ProductRepository.Instance;
        InitializeComponent();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        frmMain mdiParent = (frmMain)MdiParent;
        frmProductDetail frmProductDetail = new();
        mdiParent.frmProductDetail = frmProductDetail;
        FrmLayout.CenterFormFromParent(mdiParent, frmProductDetail);
        frmProductDetail.frmProductDetail_Load(sender, e);
        frmProductDetail.Show();
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        
    }

    public void frmProducts_Load(object sender, EventArgs e)
    {
        LoadProducts();
    }

    private async void LoadProducts()
    {
        var products = await _productRepository.ToListAsync();

        BindingSource source = new BindingSource();
        source.DataSource = products;

        txtCategoryId.DataBindings.Clear();
        txtProductName.DataBindings.Clear();
        txtUnitInStock.DataBindings.Clear();
        txtUnitPrice.DataBindings.Clear();
        txtWeight.DataBindings.Clear();

        txtCategoryId.DataBindings.Add("Text", source, "CategoryId");
        txtProductName.DataBindings.Add("Text", source, "ProductName");
        txtUnitInStock.DataBindings.Add("Text", source, "UnitsInStock");
        txtUnitPrice.DataBindings.Add("Text", source, "UnitPrice");
        txtWeight.DataBindings.Add("Text", source, "Weight");

        dgvProducts.DataSource = null;
        dgvProducts.DataSource = source;

        if (products.Count == 0)
        {
            ClearText();
            btnDelete.Enabled = false;
        } else
        {
            btnDelete.Enabled = true;
        }
    }

    private void ClearText()
    {
        txtCategoryId.Text = string.Empty;
        txtProductName.Text = string.Empty;
        txtUnitInStock.Text = string.Empty;
        txtUnitPrice.Text = string.Empty;
        txtWeight.Text = string.Empty;
    }

    private void btnClose_Click(object sender, EventArgs e) => Close();
}
