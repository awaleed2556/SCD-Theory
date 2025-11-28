using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Technova_ecom.Models.Entities;


namespace Models.Entities
{
    [Table("Products")]
    public class Product
    {
        [Column("product_id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }

        [Column("product_name")]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }
        
        [Column("price")]
        [Display(Name = "Price")]
        public int Price { get; set; }

        [Column("description")]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Column("quantity")]
        [Display(Name = "Quantity")]
        public int Quantity { get; set; }

        [Column("ratings")]
        [Display(Name = "Ratings")]
        public string Ratings { get; set; }

        //Foreign key
        [Column("category_id")]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public Category? Category { get; set; } 


    }
}
