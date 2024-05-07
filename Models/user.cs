using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        [Required]
        public string Fname { get; set; }
        [Required]
        public string Lname { get; set; }
        public int Age { get; set; }
        [Required]
        public string Email { get; set; }
        public int Phone { get; set; }

        [ValidateNever]
        public ICollection<Payment> Payments { get; set; }
        [ValidateNever]
        public ICollection<Order> Orders { get; set; }

      
    }
}
