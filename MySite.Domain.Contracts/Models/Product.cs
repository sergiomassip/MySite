using System.ComponentModel.DataAnnotations;
using System.Web.Http;

namespace MySite.Domain.Contracts.Models
{
    public class Product
    {
        [HttpBindNever]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }        
        public string Description { get; set; }
        [Range(20, 500)]
        public decimal Price { get; set; }      
        public string Category { get; set; }
        public byte[] ImageData { get; set; }
        public string ImageMimeType { get; set; }
    }
}
