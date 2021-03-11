using System.ComponentModel.DataAnnotations;

namespace qrnick_api.DTOs
{
    public class RegisterDto
    {
        [Required] 
        public string Login { get; set; }
     
        [Required]
        public string Password { get; set; }
    }
}