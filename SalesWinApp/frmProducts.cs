using DataAccess.Contexts;
using DataAccess.Repository;
using SalesWinApp.Utils;

namespace SalesWinApp;
public partial class frmProducts : Form
{
    private readonly IProductRepository _productRepository;
    private BindingSource source;
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

    public async void frmProducts_Load(object sender, EventArgs e)
    {
        txtProductId.ReadOnly = true;
        if (!((frmMain)MdiParent).isAuthorized)
        {
            btnDelete.Enabled = false;
        }
        await LoadProducts();
    }

    public async Task LoadProducts()
    {
        var products = await _productRepository.ToListAsync();

        source = new BindingSource();
        source.DataSource = products;

        txtProductId.DataBindings.Clear();
        txtCategoryId.DataBindings.Clear();
        txtProductName.DataBindings.Clear();
        txtUnitInStock.DataBindings.Clear();
        txtUnitPrice.DataBindings.Clear();
        txtWeight.DataBindings.Clear();

        txtProductId.DataBindings.Add("Text", source, "ProductId");
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

    private async void btnDelete_Click(object sender, EventArgs e)
    {
        try
        {
            var target = await _productRepository
                .FirstOrDefaultAsync(t => t.ProductId == int.Parse(txtProductId.Text));
            if (target is null)
            {
                throw new ArgumentNullException($"Product Id-{txtProductId.Text} not found");
            }
            await _productRepository.DeleteAsync(target);
            await LoadProducts();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
