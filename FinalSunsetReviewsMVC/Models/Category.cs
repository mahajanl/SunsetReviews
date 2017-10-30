using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalSunsetReviewsMVC.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        public string Location { get; set; }

        //public string CategoryLocation { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }

    }
}