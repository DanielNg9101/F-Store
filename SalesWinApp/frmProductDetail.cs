using BusinessObject;
using DataAccess.Repository;
using SalesWinApp.Utils;

namespace SalesWinApp;
public partial class frmProductDetail : Form
{
    private readonly IProductRepository _productRepository;
    public Product Product;

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
            Product entity = (Product)productBindingSource.Current;
            var errors = Validations.ValidateBindingSource(entity, productBindingSource);
            if (errors.Any())
            {
                foreach (var result in errors)
                {
                    throw new ArgumentException(result.ErrorMessage);
                }
            }
            //await _productRepository.CreateAsync(entity);
            await _productRepository.UpsertAsync(entity);
            Hide();
            await ((frmMain)MdiParent).frmProducts.LoadProducts();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
    
    private async void btnDelete_Click(object sender, EventArgs e)
    {
        try
        {
            await ((frmMain)MdiParent).frmProducts.DeleteProduct(int.Parse(txtProductId.Text));
            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public void frmProductDetail_Load(object sender, EventArgs e)
    {
        txtProductId.ReadOnly = true;
        if (!((frmMain)MdiParent).isAuthorized)
        {
            btnDelete.Enabled = false;
        }
        CreateDataBindingValidation();
    }

    private void CreateDataBindingValidation()
    {
        BindingSource source = new();
        source.DataSource = Product;

        txtProductId.DataBindings.Clear();
        txtCategoryId.DataBindings.Clear();
        txtProductName.DataBindings.Clear();
        txtUnitInStock.DataBindings.Clear();
        txtUnitPrice.DataBindings.Clear();
        txtWeight.DataBindings.Clear();

        txtProductId.DataBindings.Add("Text", source, "Id");
        txtCategoryId.DataBindings.Add("Text", source, "CategoryId");
        txtProductName.DataBindings.Add("Text", source, "ProductName");
        txtUnitInStock.DataBindings.Add("Text", source, "UnitsInStock");
        txtUnitPrice.DataBindings.Add("Text", source, "UnitPrice");
        txtWeight.DataBindings.Add("Text", source, "Weight");


        productBindingSource.DataSource = null;
        productBindingSource.DataSource = source;
    }

    public void ClearText()
    {
        txtCategoryId.Text = string.Empty;
        txtProductName.Text = string.Empty;
        txtUnitInStock.Text = string.Empty;
        txtUnitPrice.Text = string.Empty;
        txtWeight.Text = string.Empty;
    }

    public void HideFieldsWhenAdding()
    {
        txtProductId.Hide();
        lbProductId.Hide();
    }
}
