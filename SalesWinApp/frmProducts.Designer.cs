namespace SalesWinApp;

partial class frmProducts
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtUnitInStock = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtCategoryId = new System.Windows.Forms.TextBox();
            this.lbUnitInStock = new System.Windows.Forms.Label();
            this.lbUnitPrice = new System.Windows.Forms.Label();
            this.lbWeight = new System.Windows.Forms.Label();
            this.lbProductName = new System.Windows.Forms.Label();
            this.lbCategoryId = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(582, 269);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 34);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(730, 269);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 34);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtUnitInStock
            // 
            this.txtUnitInStock.Location = new System.Drawing.Point(977, 124);
            this.txtUnitInStock.Name = "txtUnitInStock";
            this.txtUnitInStock.Size = new System.Drawing.Size(331, 31);
            this.txtUnitInStock.TabIndex = 15;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(977, 54);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(331, 31);
            this.txtUnitPrice.TabIndex = 16;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(319, 200);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(331, 31);
            this.txtWeight.TabIndex = 17;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(319, 122);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(331, 31);
            this.txtProductName.TabIndex = 18;
            // 
            // txtCategoryId
            // 
            this.txtCategoryId.Location = new System.Drawing.Point(319, 54);
            this.txtCategoryId.Name = "txtCategoryId";
            this.txtCategoryId.Size = new System.Drawing.Size(331, 31);
            this.txtCategoryId.TabIndex = 19;
            // 
            // lbUnitInStock
            // 
            this.lbUnitInStock.AutoSize = true;
            this.lbUnitInStock.Location = new System.Drawing.Point(778, 127);
            this.lbUnitInStock.Name = "lbUnitInStock";
            this.lbUnitInStock.Size = new System.Drawing.Size(112, 25);
            this.lbUnitInStock.TabIndex = 14;
            this.lbUnitInStock.Text = "Unit In Stock";
            // 
            // lbUnitPrice
            // 
            this.lbUnitPrice.AutoSize = true;
            this.lbUnitPrice.Location = new System.Drawing.Point(778, 57);
            this.lbUnitPrice.Name = "lbUnitPrice";
            this.lbUnitPrice.Size = new System.Drawing.Size(86, 25);
            this.lbUnitPrice.TabIndex = 13;
            this.lbUnitPrice.Text = "Unit Price";
            // 
            // lbWeight
            // 
            this.lbWeight.AutoSize = true;
            this.lbWeight.Location = new System.Drawing.Point(120, 203);
            this.lbWeight.Name = "lbWeight";
            this.lbWeight.Size = new System.Drawing.Size(68, 25);
            this.lbWeight.TabIndex = 12;
            this.lbWeight.Text = "Weight";
            // 
            // lbProductName
            // 
            this.lbProductName.AutoSize = true;
            this.lbProductName.Location = new System.Drawing.Point(120, 125);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(126, 25);
            this.lbProductName.TabIndex = 11;
            this.lbProductName.Text = "Product Name";
            // 
            // lbCategoryId
            // 
            this.lbCategoryId.AutoSize = true;
            this.lbCategoryId.Location = new System.Drawing.Point(120, 57);
            this.lbCategoryId.Name = "lbCategoryId";
            this.lbCategoryId.Size = new System.Drawing.Size(105, 25);
            this.lbCategoryId.TabIndex = 10;
            this.lbCategoryId.Text = "Category Id";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(646, 764);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(112, 34);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(42, 326);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersWidth = 62;
            this.dgvProducts.RowTemplate.Height = 33;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullColumnSelect;
            this.dgvProducts.Size = new System.Drawing.Size(1353, 412);
            this.dgvProducts.TabIndex = 23;
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1439, 825);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtUnitInStock);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtCategoryId);
            this.Controls.Add(this.lbUnitInStock);
            this.Controls.Add(this.lbUnitPrice);
            this.Controls.Add(this.lbWeight);
            this.Controls.Add(this.lbProductName);
            this.Controls.Add(this.lbCategoryId);
            this.Name = "frmProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Management";
            this.Load += new System.EventHandler(this.frmProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Button btnAdd;
    private Button btnDelete;
    private TextBox txtUnitInStock;
    private TextBox txtUnitPrice;
    private TextBox txtWeight;
    private TextBox txtProductName;
    private TextBox txtCategoryId;
    private Label lbUnitInStock;
    private Label lbUnitPrice;
    private Label lbWeight;
    private Label lbProductName;
    private Label lbCategoryId;
    private Button btnClose;
    private DataGridView dgvProducts;
}
