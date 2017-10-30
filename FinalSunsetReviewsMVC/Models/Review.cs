using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FinalSunsetReviewsMVC.Models
{
    public class Review
    {
        [Key]
        public int ReviewID { get; set; }

        [Display(Name = "Reviewer Name")]
        [MinLength(2), MaxLength(30)]
        public string ReviewerName { get; set; }

        public string ReviewTitle { get; set; }

        [Display(Name = "Review Date")]
        public DateTime ReviewDate { get; set; }

        [MinLength(50), MaxLength(500)]
        public string ReviewContent { get; set; }

        [Display(Name = "Recommended")]
        public bool IsRecommended { get; set; }

        [ForeignKey("Category"), Display(Name = "Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}