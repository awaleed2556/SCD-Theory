using Models.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Technova_ecom.Models.Entities
{
    [Table("Category")]
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("category_id")]
        public int CategoryId { get; set; }

        [Column("category_name")]
        public string CategoryName { get; set; }

        [Column("category_order")]
        public int DisplayOrder { get; set; }
    
        public ICollection<Product>? Products { get; set; }
    }
}
