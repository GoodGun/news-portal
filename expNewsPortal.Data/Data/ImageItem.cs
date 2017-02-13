using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expNewsPortal.Data.Data
{
    public class ImageItem
    {
        public int ImageItemId { get; set; }
        
        [Display(Name = "Image")]
        public string Image { get; set; }

        public NewsItem NewsItem { get; set; }
    }
}
