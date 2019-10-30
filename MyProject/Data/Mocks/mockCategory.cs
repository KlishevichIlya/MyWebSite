using MyProject.Data.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyProject.Models;

namespace MyProject.Data.Mocks
{
    public class mockCategory : IPhonesCategory
    {
        public IEnumerable<Category> getAllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category{categoryName = "Телефоны", desc = "Заметки о разработках телефонов"},
                    new Category{categoryName = "Аксессуары", desc = "Всё самое необходимое для Вашего смартфона"}
                };
            }
        }
    }
}
