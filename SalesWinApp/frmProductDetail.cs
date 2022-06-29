using BusinessObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp;
public partial class frmProductDetail : Form
{
    public frmProductDetail()
    {
        InitializeComponent();
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {

    }

    private void btnSave_Click(object sender, EventArgs e)
    {

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
