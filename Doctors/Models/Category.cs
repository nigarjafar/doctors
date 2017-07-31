using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Doctors.Models
{
    public class Category
    {
        [Display (Name="Kateqoriya id")]
        public int Id { get; set; }

        [Display(Name = "Kateqoriya adi")]
        public string Name { get; set; }
    }
}