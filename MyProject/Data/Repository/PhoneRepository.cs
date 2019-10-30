using Microsoft.EntityFrameworkCore;
using MyProject.Data.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyProject.Models;

namespace MyProject.Data.Repository
{
    public class PhoneRepository : IAllPhone
    {
        private readonly AppDbContext appDbContext;

        public PhoneRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public IEnumerable<Phone> phones => appDbContext.Phone.Include(temp => temp.Category);

        public IEnumerable<Phone> showFavPhones => appDbContext.Phone.Where(test => test.isFavorite).Include(temp => temp.Category);

        public Phone showPhone(int idPhone) => appDbContext.Phone.FirstOrDefault(test => test.id == idPhone);


    }
}
