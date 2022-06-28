namespace SalesWinApp.Utils;
public static class TextBoxValidation
{
    public static bool txtbox_Validating(this TextBox txtBox, Label lb, ErrorProvider errorProvider)
    {
        if (string.IsNullOrEmpty(txtBox.Text.Trim()))
        {
            txtBox.Focus();
            errorProvider.SetError(txtBox, $"{lb.Text} should not be left blank");
            return false;
        }

        errorProvider.SetError(txtBox, string.Empty);
        return true;
    }

    public static bool MinLength(this TextBox txtBox, Label lb, ErrorProvider errorProvider, int minLength)
    {
        if (txtBox.Text.Length < minLength)
        {
            errorProvider.SetError(txtBox, $"{lb.Name} must not be less than {minLength} characters");
            return false;
        }
        errorProvider.SetError(txtBox, string.Empty);
        return true;
    }

    public static bool MaxLength(this TextBox txtBox, Label lb, ErrorProvider errorProvider, int maxLength)
    {
        if (txtBox.Text.Length > maxLength)
        {
            errorProvider.SetError(txtBox, $"{lb.Name} must not exceed {maxLength} characters");
            return false;
        }
        errorProvider.SetError(txtBox, string.Empty);
        return true;
    }
}
