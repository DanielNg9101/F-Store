namespace SalesWinApp;

partial class frmProductDetail
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
            this.lbCategoryId = new System.Windows.Forms.Label();
            this.lbProductName = new System.Windows.Forms.Label();
            this.lbWeight = new System.Windows.Forms.Label();
            this.lbUnitPrice = new System.Windows.Forms.Label();
            this.lbUnitInStock = new System.Windows.Forms.Label();
            this.txtCategoryId = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtUnitInStock = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCategoryId
            // 
            this.lbCategoryId.AutoSize = true;
            this.lbCategoryId.Location = new System.Drawing.Point(66, 78);
            this.lbCategoryId.Name = "lbCategoryId";
            this.lbCategoryId.Size = new System.Drawing.Size(105, 25);
            this.lbCategoryId.TabIndex = 1;
            this.lbCategoryId.Text = "Category Id";
            // 
            // lbProductName
            // 
            this.lbProductName.AutoSize = true;
            this.lbProductName.Location = new System.Drawing.Point(66, 146);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(126, 25);
            this.lbProductName.TabIndex = 2;
            this.lbProductName.Text = "Product Name";
            // 
            // lbWeight
            // 
            this.lbWeight.AutoSize = true;
            this.lbWeight.Location = new System.Drawing.Point(66, 224);
            this.lbWeight.Name = "lbWeight";
            this.lbWeight.Size = new System.Drawing.Size(68, 25);
            this.lbWeight.TabIndex = 3;
            this.lbWeight.Text = "Weight";
            // 
            // lbUnitPrice
            // 
            this.lbUnitPrice.AutoSize = true;
            this.lbUnitPrice.Location = new System.Drawing.Point(66, 306);
            this.lbUnitPrice.Name = "lbUnitPrice";
            this.lbUnitPrice.Size = new System.Drawing.Size(86, 25);
            this.lbUnitPrice.TabIndex = 4;
            this.lbUnitPrice.Text = "Unit Price";
            // 
            // lbUnitInStock
            // 
            this.lbUnitInStock.AutoSize = true;
            this.lbUnitInStock.Location = new System.Drawing.Point(66, 376);
            this.lbUnitInStock.Name = "lbUnitInStock";
            this.lbUnitInStock.Size = new System.Drawing.Size(112, 25);
            this.lbUnitInStock.TabIndex = 5;
            this.lbUnitInStock.Text = "Unit In Stock";
            // 
            // txtCategoryId
            // 
            this.txtCategoryId.Location = new System.Drawing.Point(265, 75);
            this.txtCategoryId.Name = "txtCategoryId";
            this.txtCategoryId.Size = new System.Drawing.Size(331, 31);
            this.txtCategoryId.TabIndex = 6;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(265, 143);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(331, 31);
            this.txtProductName.TabIndex = 6;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(265, 221);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(331, 31);
            this.txtWeight.TabIndex = 6;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(265, 303);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(331, 31);
            this.txtUnitPrice.TabIndex = 6;
            // 
            // txtUnitInStock
            // 
            this.txtUnitInStock.Location = new System.Drawing.Point(265, 373);
            this.txtUnitInStock.Name = "txtUnitInStock";
            this.txtUnitInStock.Size = new System.Drawing.Size(331, 31);
            this.txtUnitInStock.TabIndex = 6;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(469, 464);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 34);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(288, 464);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 34);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(108, 464);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 34);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmProductDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 544);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
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
            this.Name = "frmProductDetail";
            this.Text = "s";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion
    private Label lbCategoryId;
    private Label lbProductName;
    private Label lbWeight;
    private Label lbUnitPrice;
    private Label lbUnitInStock;
    private TextBox txtCategoryId;
    private TextBox txtProductName;
    private TextBox txtWeight;
    private TextBox txtUnitPrice;
    private TextBox txtUnitInStock;
    private Button btnDelete;
    private Button btnSave;
    private Button btnCancel;
}