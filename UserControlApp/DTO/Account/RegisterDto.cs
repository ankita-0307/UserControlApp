using System.ComponentModel.DataAnnotations;

namespace UserControlApp.DTO.Account
{
    public class RegisterDto
    {
        [Required]
        [StringLength(15, MinimumLength =3, ErrorMessage ="First name must be atleast of {2} characters and maximum {1} characters")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "Last name must be atleast of {2} characters and maximum {1} characters")]
        public string LastName { get; set; }

        [Required]
        [RegularExpression("^\\w+@[a-zA-Z_]+?\\.[a-zA-Z]{2,3}$", ErrorMessage ="Invalid Email Address")]
        public string Email { get; set; }

        [Required]
        [StringLength(6, ErrorMessage = "Password must be max of {1} characters")]
        public string Password { get; set; }
    }
}
