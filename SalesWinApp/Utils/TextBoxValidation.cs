namespace SalesWinApp.Utils;
public static class TextBoxValidation
{
    public static void txtbox_Validating(this TextBox txtBox, Label lb, ErrorProvider errorProvider, System.ComponentModel.CancelEventArgs e)
    {
        if (string.IsNullOrEmpty(txtBox.Text.Trim()))
        {
            e.Cancel = true;
            txtBox.Focus();
            errorProvider.SetError(txtBox, $"{lb.Text} should not be left blank");
        }
        else
        {
            e.Cancel = false;
            errorProvider.SetError(txtBox, string.Empty);
        }
    }
}
