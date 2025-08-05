using System.ComponentModel.DataAnnotations;


namespace FormsApp.Models
{
    public class Product
    {
        [Display(Name = "Urun Id")]
        
        public int ProductId { get; set; }
        [Required(ErrorMessage ="Gerekli bir alan")]
        [StringLength(100)]
        [Display(Name = "Urun Adı")]
        public string? Name { get; set; }
        [Required]
        [Range(0,100000)]
        [Display(Name = "Fiyat")]
        public decimal? Price { get; set; }
        [Display(Name = "Resim")]
        public string? Image { get; set; } = string.Empty;
        public bool IsActive { get; set; }
        [Display(Name = "Kategori")]
        [Required]
        public int? CategoryId { get; set; }
    }
}