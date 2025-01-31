namespace AllSopFoodService.Repositories.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using AllSopFoodService.Model;

    public interface ICategoryRepository : IGenericRepository<Category>
    {
        IQueryable<Category> GetCategoryDataWithEagerLoad(int id);
    }
}
