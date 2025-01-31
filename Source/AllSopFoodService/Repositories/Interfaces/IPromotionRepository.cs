namespace AllSopFoodService.Repositories.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using AllSopFoodService.Model;

    public interface IPromotionRepository : IGenericRepository<Promotion>
    {
        Promotion GetCouponByCode(string voucherCode);
        bool CheckVoucherExist(string voucherCode);
    }
}
