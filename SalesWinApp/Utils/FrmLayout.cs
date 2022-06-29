namespace SalesWinApp.Utils;
public static class FrmLayout
{
    public static Point CenterParent(this Form mdiChild, Form mdiParent)
    {
        mdiChild.StartPosition = FormStartPosition.Manual;
        return new Point((mdiParent.ClientSize.Width - mdiChild.Width) / 2,
                       (mdiParent.ClientSize.Height - mdiChild.Height) / 2);
    }

    public static void CenterFormFromParent<T>(Form mdiParent, T child) where T : Form
    {
        child.MdiParent = mdiParent;
        child.Location = child.CenterParent(mdiParent);
    }
}
