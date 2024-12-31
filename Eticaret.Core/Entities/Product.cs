﻿using System.ComponentModel.DataAnnotations;

namespace Eticaret.Core.Entities
{
    public class Product : IEntitiy
    {
        public int Id { get; set; }
        
        [Display(Name = "Adı")]
        public string Name { get; set; }
        
        [Display(Name = "Açıklama")]
        public string? Description { get; set; }
        
        [Display(Name = "Resim")]
        public string? Image { get; set; }
        
        [Display(Name = "Fiyat")]
        public decimal Price { get; set; }
        
        [Display(Name = "Stok")]
        public string? ProductCode { get; set; }
        
        [Display(Name = "Aktif?")]
        public bool IsActive { get; set; }
        
        [Display(Name = "Anasayfada Göster")]
        public bool IsHome { get; set; }
        
        [Display(Name = "Kategori")]
        public int? CategoryId { get; set; }
        
        [Display(Name = "Kategori")]
        public Category? Category { get; set; }
        
        [Display(Name = "Marka")]
        public int? BrandId { get; set; }
        [Display(Name = "Marka")]
        public Brand? Brand { get; set; }
        [Display(Name = "Sıra No")]
        public int OrderNo { get; set; }

        [Display(Name = "Kayıt Tarihi"), ScaffoldColumn(false)]
        public DateTime CreateDate { get; set; } = DateTime.Now;

    }
}
