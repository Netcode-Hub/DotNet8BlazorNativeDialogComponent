using System.ComponentModel.DataAnnotations;

namespace DotNet8BlazorNativeDialogComponent
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public decimal? Amount { get; set; }
    }
}
