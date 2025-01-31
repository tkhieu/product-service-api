#nullable disable
namespace AllSopFoodService.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Threading.Tasks;

    public class ShoppingCart
    {
        public int Id { get; set; }
        public string CartLabel { get; set; } = "Default Cart Label";
        public bool IsDiscounted { get; set; }
        // Navigation Properties
        public int? VoucherId { get; set; }
        public virtual Promotion VoucherCode { get; set; } //assuming each Cart can only claim one Voucher at a time
        public virtual List<FoodProduct_ShoppingCart> FoodProduct_Carts { get; set; }
        //Navigation props
        public int UserId { get; set; }
        public User CartUser { get; set; }
    }
}
