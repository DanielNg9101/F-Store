﻿using SalesWinApp.Utils;

namespace SalesWinApp;
public partial class frmMain : Form
{
    public frmLogin frmLogin = new();
    public frmMembers frmMembers = new();
    public frmMain()
    {
        InitializeComponent();
    }

    private void frmContainer_Load(object sender, EventArgs e)
    {
        frmLogin.MdiParent = this;
        frmLogin.Location = frmLogin.CenterParent(this);
        frmLogin.Show();

        frmMembers.MdiParent = this;
        frmMembers.Location = frmMembers.CenterParent(this);
    }
}
