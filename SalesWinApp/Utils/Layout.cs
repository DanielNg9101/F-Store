namespace SalesWinApp.Utils;
public static class Layout
{
    public static Point CenterParent(this Form mdiChild, Form mdiParent)
    {
        mdiChild.StartPosition = FormStartPosition.Manual;
        return new Point((mdiParent.ClientSize.Width - mdiChild.Width) / 2,
                       (mdiParent.ClientSize.Height - mdiChild.Height) / 2);
    }
}
