using System.ComponentModel.DataAnnotations;

namespace Eticaret.Core.Entities
{
    public class AppUser : IEntitiy
    {
        public int Id { get; set; }

        [Display(Name = "Adı")]
        public string Name { get; set; }

        [Display(Name = "SoyAdı")]
        public string Surname { get; set; }

        public string Email { get; set; }

        [Display(Name = "Telefon")]
        public string? Phone { get; set; }

        [Display(Name = "Şifre")]
        public string Password { get; set; }

        [Display(Name = "Kullanıcı Adı")]
        public string? UserName { get; set; }

        [Display(Name = "Aftif?")]
        public bool IsActive { get; set; }

        [Display(Name = "Admin?")]
        public bool IsAadmin { get; set; }
        
        [Display(Name = "Kayıt Tarihi") ,ScaffoldColumn(false)]
        public DateTime CreateDate { get; set; } = DateTime.Now;
        
        [ScaffoldColumn(false)]
        public Guid UserGuid { get; set; } = Guid.NewGuid();

    }
}
