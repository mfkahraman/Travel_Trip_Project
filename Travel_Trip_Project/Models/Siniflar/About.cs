using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Travel_Trip_Project.Models.Siniflar
{
    public class About
    {
        [Key]
        public int ID { get; set; }

        [Url(ErrorMessage = "Lütfen geçerli bir URL giriniz.")]
        public string PhotoUrl { get; set; }

        [Required(ErrorMessage = "Açıklama gereklidir.")]
        [StringLength(1000, ErrorMessage = "Açıklama 1000 karakterden fazla olamaz.")]
        public string Description { get; set; }
    }
}
