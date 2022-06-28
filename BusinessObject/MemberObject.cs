using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessObject;
public class MemberObject
{
    [Key,Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int MemberId { get; set; }
    [Required, MaxLength(100), EmailAddress]
    public string Email { get; set; }
    [Required, MaxLength(40)]
    public string CompanyName { get; set; }
    [Required, MaxLength(15)]
    public string City { get; set; }
    [Required, MaxLength(15)]
    public string Country { get; set; }
    [Required, MaxLength(30)]
    public string Password { get; set; }
}
