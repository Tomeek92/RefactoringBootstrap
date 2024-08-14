using System.ComponentModel.DataAnnotations;

namespace CleanArchitectureBlazor.Application.Dto
{
    public class NewsLetterEmailDto
    {
        [EmailAddress(ErrorMessage = "Niepoprawny format emaila.")]
        public string Email { get; set; } = null!;
    }
}
