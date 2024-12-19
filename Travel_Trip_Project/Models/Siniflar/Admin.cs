using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Travel_Trip_Project.Models.Siniflar
{
    public class Admin
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Kullanıcı adı gereklidir.")]
        [StringLength(50, ErrorMessage = "Kullanıcı adı en fazla 50 karakter olabilir.")]
        public string User { get; set; }

        [Required(ErrorMessage = "Şifre gereklidir.")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Şifre en az 6, en fazla 20 karakter olmalıdır.")]
        public string Password { get; set; }
    }
}
