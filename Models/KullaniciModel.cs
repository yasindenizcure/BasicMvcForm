using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SubatOdev2.Models
{
	public class KullaniciModel
	{
        [Required(ErrorMessage = "Ad alanı zorunludur!")]
        [StringLength(50, ErrorMessage = "Ad en fazla 50 karakter olabilir.")]
        public string Ad { get; set; }

        [Required(ErrorMessage = "E-posta alanı zorunludur!")]
        [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi giriniz!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Telefon numarası zorunludur!")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Telefon numarası 10 haneli olmalıdır!")]
        public string Telefon { get; set; }

        [Required(ErrorMessage = "Şifre zorunludur!")]
        [StringLength(16, MinimumLength = 6, ErrorMessage = "Şifre 6-16 karakter arasında olmalıdır.")]
        public string Sifre { get; set; }
    }
}