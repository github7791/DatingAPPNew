using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username {set; get;}

        [Required]
        [StringLength(8, MinimumLength = 4 , ErrorMessage = "Must specify password between 4 and 8 characters")]
        public string Password  {set; get;}
    }
}