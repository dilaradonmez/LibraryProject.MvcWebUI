using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryProject.MvcWebUI.Models
{
    public class AppUserVm
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Kullanıcı adı boş bırakılamaz!")]
        [Display(Name = "Kullanıcı adı")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Şifre zorunlu.")]
        [Display(Name = "Şifre")]
        public string Password { get; set; }
    }
}