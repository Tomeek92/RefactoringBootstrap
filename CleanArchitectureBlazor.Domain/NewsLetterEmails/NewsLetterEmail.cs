using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureBlazor.Domain.NewsLetterEmails
{
    public class NewsLetterEmail
    {
        [Key]
        public Guid Id { get; set; }
        public string Email { get; set; } = null!;
    }
}
