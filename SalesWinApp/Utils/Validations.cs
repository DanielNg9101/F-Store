using System.ComponentModel.DataAnnotations;

namespace SalesWinApp.Utils;
public static class Validations
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

    public static  IList<ValidationResult> ValidateBindingSource<T>(BindingSource source)
    {
        source.EndEdit();
        T entity = (T)source.Current;
        if (entity == null)
        {
            throw new ArgumentNullException();
        }

        ValidationContext context = new ValidationContext(entity, null, null);
        IList<ValidationResult> errors = new List<ValidationResult>();
        Validator.TryValidateObject(entity, context, errors, true);
        return errors;
    }

    public static IList<ValidationResult> ValidateBindingSource<T>(T entity, BindingSource source)
    {
        source.EndEdit();
        ValidationContext context = new ValidationContext(entity, null, null);
        IList<ValidationResult> errors = new List<ValidationResult>();
        Validator.TryValidateObject(entity, context, errors, true);
        return errors;
    }
}
