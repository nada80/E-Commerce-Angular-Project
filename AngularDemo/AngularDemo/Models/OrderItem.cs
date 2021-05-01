﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AngularDemo.Models
{
    public class OrderItem
    {
        public int ID { get; set; }
        public int DateOrdered { get; set; }

        public int productQuantity { get; set; }
        public double productDiscount { get; set; }
        public double ProductPrice { get; set; }
        public double productTotalPrice { get; set; }

        [ForeignKey("product")]
        public int ProductID { get; set; }
        public virtual Product product { get; set; }


        [ForeignKey("order")]
        public int OrderID { get; set; }
        public virtual Order order { get; set; }
    }
}
