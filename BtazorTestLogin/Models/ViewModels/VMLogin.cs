using System.ComponentModel.DataAnnotations;

namespace BtazorTestLogin.Models.ViewModels
{
    public class VMLogin
    {
        [Required(ErrorMessage = "Please enter your username")]
        public string ? USER_NAME { get; set; }
        [Required(ErrorMessage = "Please enter your password")]
        public string ? PASS_WORD { get; set; }

        
    }
}
