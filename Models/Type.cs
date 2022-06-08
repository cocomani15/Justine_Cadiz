using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.IdentityModel.Protocols;

namespace webdev.Models
{
    public class Type
    {
        [Key]
        public int id {get; set;}
        [Required]
        [StringLength(100)]
        public string type {get; set;}
    }
}