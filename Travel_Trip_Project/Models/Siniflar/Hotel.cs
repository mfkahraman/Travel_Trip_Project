using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Travel_Trip_Project.Models.Siniflar
{
    public class Hotel
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Otel adı gereklidir.")]
        [StringLength(100, ErrorMessage = "Otel adı 100 karakterden fazla olamaz.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Açıklama gereklidir.")]
        [StringLength(1000, ErrorMessage = "Açıklama 500 karakterden fazla olamaz.")]
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
