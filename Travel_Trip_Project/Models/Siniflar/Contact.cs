using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Travel_Trip_Project.Models.Siniflar
{
    public class Contact
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Adınız ve soyadınız gereklidir.")]
        public string NameSurname { get; set; }

        [Required(ErrorMessage = "Mail adresiniz gereklidir.")]
        [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi girin.")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Konu gereklidir.")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Mesajınız gereklidir.")]
        public string Message { get; set; }
    }

}