using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Travel_Trip_Project.Models.Siniflar
{
    public class Comment
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Kullanıcı adı alanı gereklidir.")]
        [StringLength(50, ErrorMessage = "Kullanıcı adı en fazla 50 karakter olabilir.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "E-posta alanı gereklidir.")]
        [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi giriniz.")]
        [StringLength(100, ErrorMessage = "E-posta adresi en fazla 100 karakter olabilir.")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Yorum alanı gereklidir.")]
        [StringLength(500, ErrorMessage = "Yorum en fazla 500 karakter olabilir.")]
        public string Context { get; set; }

        [Required(ErrorMessage = "Blog alanı gereklidir.")]
        public int BlogId { get; set; }

        public virtual Blog Blog { get; set; }
    }
}
