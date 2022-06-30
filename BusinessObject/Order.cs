using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessObject;
public class Order : BaseEntity
{
/*    [Key, Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int OrderId { get; set; }*/
    [Required]
    public int MemberId { get; set; }
    public Member Member { get; set; }
    [Required]
    public DateTime OrderDate { get; set; }
    public DateTime? RequiredDate { get; set; }
    public DateTime? ShippedDate { get; set; }
    [Column(TypeName = "money")]
    public double? Freight { get; set; }
}
