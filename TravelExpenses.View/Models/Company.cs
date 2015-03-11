using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TravelExpenses.View.Models
{
    public class Company
    {
        [Key]
        [Required]
        public int CompanyID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }
    }
}