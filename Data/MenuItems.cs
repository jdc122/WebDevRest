using System;
using System.ComponentModel.DataAnnotations;

namespace OceansideRestaurant.Data
{
    public class MenuItems
    {
        [Key]
        public int ID { get; set; }
        [Required, StringLength(25, MinimumLength = 3)]
        public string Name { get; set; }
        [Required]
        [Range(0.01, 100)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        [Required]
        [StringLength(250, MinimumLength = 10)]
        public string Description { get; set; }

        public Boolean Active { get; set; }
        public string ImageDescription { get; set; }
        public byte[] ImageData { get; set; }

    }
}
