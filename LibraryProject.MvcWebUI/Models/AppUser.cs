using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryProject.MvcWebUI.Models
{
    public class AppUser
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Kullanıcı adı boş bırakılamaz!")]
        [Display(Name = "Kullanıcı adı")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Email boş bırakılamaz!")]
        [EmailAddress(ErrorMessage = "Email formatında bir adres giriniz.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifre zorunlu.")]
        [Display(Name = "Şifre")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Şifre(Tekrar) zorunlu.")]
        [Display(Name = "Şifre(Tekrar)")]
        [Compare("Password", ErrorMessage = "şifreler aynı değil")]
        public string ConfirmPassword { get; set; }
    }
}