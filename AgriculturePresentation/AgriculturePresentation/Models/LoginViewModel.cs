using System.ComponentModel.DataAnnotations;

namespace AgriculturePresentation.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Lütfen kullanıcı adı giriniz.")]
        public string username { get; set; }

        [Required(ErrorMessage = "Lütfen şifreyi giriniz.")]
        public string password { get; set; }
    }
}
