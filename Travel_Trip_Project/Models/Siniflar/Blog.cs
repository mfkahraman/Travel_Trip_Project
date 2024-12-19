using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Travel_Trip_Project.Models.Siniflar
{
    public class Blog
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Başlık alanı gereklidir.")]
        [StringLength(100, ErrorMessage = "Başlık en fazla 100 karakter olabilir.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Tarih alanı gereklidir.")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Açıklama alanı gereklidir.")]
        [StringLength(1000, ErrorMessage = "Açıklama en fazla 500 karakter olabilir.")]
        public string Description { get; set; }

        public string BlogImage { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}
