using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DentistCalendar.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage ="Kullanıcı Adını Giriniz")]
        [Display(Name ="Kullanıcı Adınız:")]
        public string UserName { get; set; }
        [Required(ErrorMessage = " Adınızı Giriniz")]
        [Display(Name = " Adınız:")]
        public string Name { get; set; }
        [Required(ErrorMessage = " Soyadınızı Giriniz")]
        [Display(Name = " Soyadınız:")]
        public string Surname { get; set; }
        [Required(ErrorMessage = " Şifrenizi Giriniz")]
        [Display(Name = " Şifreniz:")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = " Mail Giriniz")]
        [Display(Name = " Mail Adresi:")]
        [EmailAddress(ErrorMessage ="Lütfen email alanını kontrol edin")]
        public string EMail { get; set; }
        
        [Display(Name = " Randevu rengi")]
        public string Color { get; set; }
       
        [Display(Name = " Doktorum")]
        public bool IsDentist { get; set; }

    }
}
