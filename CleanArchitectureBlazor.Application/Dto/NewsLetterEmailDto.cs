using System.ComponentModel.DataAnnotations;

namespace CleanArchitectureBlazor.Application.Dto
{
    public class NewsLetterEmailDto
    {
       
        [EmailAddress(ErrorMessage = "Niepoprawny format adresu email.")]
        public string? Email { get; set; } 
    }
}
