﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AngularDemo.Models
{
    public class Brands
    {
        public int ID { get; set; }
        [Required]
        [StringLength(30)]
        public string BrandName { get; set; }

        [InverseProperty("brand")]
        public virtual ICollection<Product> Products { get; set; }
    }
}
