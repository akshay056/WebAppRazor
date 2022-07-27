
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAppRazor.Model
{
    public class Customer
    {
        public int ID { get; set; }
        [Required()]
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }
    }

}
