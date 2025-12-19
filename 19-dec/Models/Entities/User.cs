using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Technova_ecom.Models.Entities
{
    [Table("User")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }
        [Column("user_name")]
        public string UserName { get; set; }
        [Column("hashed_password")]
        public string HashedPassword { get; set; }
        [Column("role")]
        public string? Role { get; set; }
    }
}
