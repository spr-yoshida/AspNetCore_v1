using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore_v1.Models
{
    public class Item
    {
        public Item()
        {
        }

        [Required]
        public int ID { get; set; }
        
        [Required]
        [StringLength(10)]    
        public string Name { get; set; }

        [Required]
        [StringLength(20)]
        public string Description { get; set; }
        
        public bool Completed { get; set; }
    }
}
