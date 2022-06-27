using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject;
public class OrderObject
{
    [Required]
    public int OrderId { get; set; }
    [Required]
    public int MemberId { get; set; }
    public MemberObject Member { get; set; }
    [Required]
    public DateTime OrderDate { get; set; }
    public DateTime? RequiredDate { get; set; }
    public DateTime? ShippedDate { get; set; }
    [Column(TypeName = "money")]
    public double? Freight { get; set; }
}
