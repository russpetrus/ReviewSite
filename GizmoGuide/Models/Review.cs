using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace GizmoGuide.Models
{
    public class Review
    {
        [Key]
        public int ReviewID { get; set; }

        [DisplayName("Date of Review")]
        public DateTime ReviewDate { get; set; }

        [DisplayName("Manufacturer")]
        public string ProductMake { get; set; }

        [DisplayName("Name of Product")]
        public string ProductName { get; set; }

        [DisplayName("Model Number")]
        public string ModelNumber { get; set; }

        [DisplayName("Manufacturer's Description")]
        public string ProductDescription { get; set; }

        [DisplayName("Image URL")]
        public string ImageURL { get; set; }

        [DisplayName("Review")]
        public string ReviewContent { get; set; }

        [Range(1, 5)]
        public int Score { get; set; }

        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}