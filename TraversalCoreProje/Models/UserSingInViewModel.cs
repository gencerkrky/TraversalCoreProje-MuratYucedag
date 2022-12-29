using System.ComponentModel.DataAnnotations;

namespace TraversalCoreProje.Models
{
    public class UserSingInViewModel
    {
        [Required(ErrorMessage ="Lütfen kullnıcı adını giriniz")]
        public string username { get; set; }
        [Required(ErrorMessage = "Lütfen şifrenizi giriniz")]
        public string password { get; set; }
    }
}
