using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Doctors.Models
{
    public class CreateViewModel
    {
        public Doctor Doctor { get; set; }
        public Category Category { get; set; }
    }
}