using System.ComponentModel.DataAnnotations;

namespace CleanArchitectureBlazor.Domain.Service_Price
{
 public class Service
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Price { get; set; }
        public string? Category { get; set; }
    }
}
