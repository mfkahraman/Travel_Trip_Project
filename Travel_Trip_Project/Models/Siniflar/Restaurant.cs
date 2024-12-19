using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Travel_Trip_Project.Models.Siniflar
{
    public class Restaurant
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Restoran adı gereklidir.")]
        [StringLength(100, ErrorMessage = "Restoran adı 100 karakterden fazla olamaz.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Açıklama gereklidir.")]
        [StringLength(1000, ErrorMessage = "Açıklama 500 karakterden fazla olamaz.")]
        public string Description { get; set; }

        [Url(ErrorMessage = "Lütfen geçerli bir URL giriniz.")]
        public string ImageUrl { get; set; }
    }
}
