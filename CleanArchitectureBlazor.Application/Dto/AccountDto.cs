using System.ComponentModel.DataAnnotations;

namespace CleanArchitectureBlazor.Application.Dto
{
    public class AccountDto
    {
        [Required]
        public string AdminName { get; set; } = null!;
        [Required]
        public string AdminEmail { get; set; } = null!;
    }
}
