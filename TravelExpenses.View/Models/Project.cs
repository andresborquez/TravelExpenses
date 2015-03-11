using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelExpenses.View.Models
{
    public class Project
    {
        public int ProjectID { get; set; }

        [Required]
        [Display(Name="Company")]
        public int CompanyID { get; set; }

        [Display(Name = "Company")]
        public string CompanyName { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }
    }
}