using MyProject.Data.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace MyProject.Data.Repository
{
    public class CategoryRepository : IPhonesCategory
    {
        private readonly AppDbContext appDbContext;

        public CategoryRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public IEnumerable<Category> getAllCategories => appDbContext.Category;

    }
}
