using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Model.Models
{
    public class Test
    {
        [Key]
        public int Id { get; set; }

        public string name { get; set; }

        public bool status { get; set; }
    }
}
