﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expNewsPortal.Data.Data
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [MaxLength(50, ErrorMessage = "Ad Alanı 50 karakterden uzun olamaz!")]
        [Display(Name = "Ad")]
        public string Name { get; set; }

        [MaxLength(50, ErrorMessage = "Soyad Alanı 50 karakterden uzun olamaz!")]
        [Display(Name = "SoyAd")]
        public string Surname { get; set; }

        [Display(Name = "e-mail")]
        [Required]
        //RegEx Attribute bulunabilir
        public string Email { get; set; }

        [MaxLength(16, ErrorMessage = "Şifre Alanı 16 karakterden uzun olamaz!")]
        [DataType(DataType.Password)]
        [Display(Name = "Şifre")]
        [Required]
        public string Password { get; set; }

        [Display(Name = "Kayıt Tarihi")]
        public DateTime CreateDate { get; set; }

        [Display(Name = "Durumu")]
        public bool IsActive { get; set; }

        public virtual Role Rol { get; set; }
    }
}
