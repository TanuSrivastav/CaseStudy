using System;
using System.Collections.Generic;

#nullable disable

namespace ECommerce.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string CatId { get; set; }
        public string ProductImage { get; set; }
        public decimal? ProductMrp { get; set; }
        public decimal? ProductDiscount { get; set; }
        public decimal? ProductFinal { get; set; }
        public int? ProductQuantity { get; set; }
    }
}
