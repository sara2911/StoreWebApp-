using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreWepApp.Model.DB
{
    [Table("Product")]

    public class Product
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("image")]
        public string? Image { get; set; }
        [Column("category")]
        public string? Category { get; set; }
        [Column("title")]
        public string? Title { get; set; }
        [Column("description")]
        public string? Description { get; set; }
        [Required, Column("price")]
        public decimal Price { get; set; }
    }
}
