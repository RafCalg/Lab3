using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab3.Models
{
    public class Product
    {
        [Required(ErrorMessage = "Product ID is required")]
        [StringLength(10)]
        public string ProductID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(50)]
        public string Name { get; set; }


        [Required(ErrorMessage = "Short Description is required")]
        [StringLength(200)]
        public string ShortDescxription { get; set; }

        [Required(ErrorMessage = "Long Description is required")]
        [StringLength(2000)]
        public string LongDescription { get; set; }

        [Required(ErrorMessage = "CategoryID is required")]
        [StringLength(10)]
        public string CategoryID { get; set; }

        [Required(ErrorMessage = "Image File is required")]
        [StringLength(30)]
        public string ImageFile { get; set; }

        [Required(ErrorMessage = "Unit Price is required")]
        [DataType(DataType.Currency)]
        [Range(0, 1000)]    
        public string UnitPrice { get; set; }

        [Required(ErrorMessage = "On Hand quantity is a required field")]
        [Range(0, 10000)]
        public int OnHand { get; set; }



    }
}