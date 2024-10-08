﻿using System.ComponentModel.DataAnnotations;

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
