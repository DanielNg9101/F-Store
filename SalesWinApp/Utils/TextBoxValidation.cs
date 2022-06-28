namespace SalesWinApp.Utils;
public static class TextBoxValidation
{
    public static void txtbox_Validating(this TextBox txtBox, ErrorProvider errorProvider, System.ComponentModel.CancelEventArgs e)
    {
        if (string.IsNullOrEmpty(txtBox.Text))
        {
            e.Cancel = true;
            txtBox.Focus();
            errorProvider.SetError(txtBox, $"{txtBox.Name} should not be left blank");
        }
        else
        {
            e.Cancel = false;
            errorProvider.SetError(txtBox, "");
        }
    }
}
