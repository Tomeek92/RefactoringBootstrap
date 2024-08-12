using System.ComponentModel.DataAnnotations;

namespace CleanArchitectureBlazor.Domain.NewsLetterEmails
{
    public class NewsLetterEmail
    {
        [Key]
        public Guid Id { get; set; }
        public string Email { get; set; } = null!;
    }
}
