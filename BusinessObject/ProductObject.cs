using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessObject;
public class ProductObject
{
    [Key, Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ProductId { get; set; }
    [Required]
    public int CategoryId { get; set; }
    [Required, MaxLength(40)]
    public string ProductName { get; set; }
    [Required, MaxLength(20)]
    public string Weight { get; set; }
    [Required, Column(TypeName = "money")]
    public double UnitPrice { get; set; }
    [Required]
    public int UnitsInStock { get; set; }
}
