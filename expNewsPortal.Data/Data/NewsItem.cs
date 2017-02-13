using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expNewsPortal.Data.Data
{
    public class NewsItem
    {
        [Key]
        public int NewsItemId { get; set; }

        [MaxLength(250, ErrorMessage = "Başlık Alanı 250 karakterden uzun olamaz!")]
        [Display(Name = "Başlık")]
        [Required]
        public string Title { get; set; }


        [MaxLength(250, ErrorMessage = "Kısa Açıklama Alanı 250 karakterden uzun olamaz!")]
        [Display(Name = "Kısa Açıklama")]
        public string ShortDescription { get; set; }

        public int ViewCount { get; set; }

        [MaxLength(2000, ErrorMessage = "Uzun Açıklama Alanı 2000 karakterden uzun olamaz!")]
        [Display(Name = "Uzun Açıklama")]
        public string Description { get; set; }

        [Display(Name = "Durumu")]
        public bool IsActive { get; set; }

        [Display(Name = "Kayıt Tarihi")]
        public DateTime CreateDate { get; set; }

        public virtual User User { get; set; }

        [MaxLength(255, ErrorMessage = "Image Alanı 255 karakterden uzun olamaz!")]
        [Display(Name = "Image")]
        public string ImageItem { get; set; }

        public virtual ICollection<ImageItem> ImageItems { get; set; }
    }
}
