using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureBlazor.Domain.Admin
{
    public class Account
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string AdminName { get; set; } = null!;
        [Required]
        public string AdminEmail { get; set; } = null!;
    }
}
