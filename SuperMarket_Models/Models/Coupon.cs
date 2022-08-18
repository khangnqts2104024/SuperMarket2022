﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket_Models.Models
{
    [Table("tbCoupon")]
    public class Coupon
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CouponId { get; set; }
        [Required]
        public string? Code { get; set; }
       
        public double? DiscountPercent { get; set; }
        public DateTime CreatedDate { get; } = DateTime.Now;
        public DateTime ExpiredDate { get; set; }
        public int Count { get; set; }
        //public virtual List<Product> products { set; get; }
    }
}
