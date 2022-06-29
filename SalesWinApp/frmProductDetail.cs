using BusinessObject;
using DataAccess.Repository;
using SalesWinApp.Utils;

namespace SalesWinApp;
public partial class frmProductDetail : Form
{
    private readonly IProductRepository _productRepository;

    public frmProductDetail()
    {
        _productRepository = ProductRepository.Instance;
        InitializeComponent();
    }

    private void btnCancel_Click(object sender, EventArgs e) => Close();

    private async void btnSave_ClickAsync(object sender, EventArgs e)
    {
        try
        {
            ProductObject entity = (ProductObject)productBindingSource.Current;
            var errors = Validations.ValidateBindingSource(entity, productBindingSource);
            if (errors.Any())
            {
                foreach (var result in errors)
                {
                    throw new ArgumentException(result.ErrorMessage);
                }
            }
            await _productRepository.CreateAsync(entity);
            Hide();
            await ((frmMain)MdiParent).frmProducts.LoadProducts();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {

    }

    public void frmProductDetail_Load(object sender, EventArgs e)
    {
        BindingSource source = new();
        source.DataSource = new ProductObject();

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

        productBindingSource.DataSource = null;
        productBindingSource.DataSource = source;
    }
}
