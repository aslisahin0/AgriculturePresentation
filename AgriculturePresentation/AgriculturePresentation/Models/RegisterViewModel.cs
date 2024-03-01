using System.ComponentModel.DataAnnotations;

namespace AgriculturePresentation.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage ="Lütfen kullanıcı adı girin!")]
        public string? userName { get; set; }

        [Required(ErrorMessage = "Lütfen mail girin!")]
        public string? mail { get; set; }

        [Required(ErrorMessage = "Lütfen şifre girin!")]
        public string? password { get; set; }

        [Required(ErrorMessage = "Lütfen şifreyi tekrar girin!")]
        [Compare("password", ErrorMessage ="Şifreler uyumlu değil!")]
        public string? passwordConfirm { get; set; }
    }
}
