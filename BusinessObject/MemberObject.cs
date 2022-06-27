using System.ComponentModel.DataAnnotations;

namespace BusinessObject;
public class MemberObject
{
    [Required]
    public int MemberId { get; set; }
    [Required, MaxLength(100)]
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
