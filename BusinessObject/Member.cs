using System.ComponentModel.DataAnnotations;

namespace BusinessObject;
public class Member : BaseEntity
{
/*    [Key, Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int MemberId { get; set; }*/

    [Required, MaxLength(100), EmailAddress]
    public string Email { get; set; }

    [Required, MinLength(6), MaxLength(30)]
    public string Password { get; set; }

    [Required, MaxLength(40)]
    public string CompanyName { get; set; }

    [Required, MaxLength(15)]
    public string City { get; set; }

    [Required, MaxLength(15)]
    public string Country { get; set; }
}
