using MyProject.Data.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace MyProject.Data.Mocks
{
    public class mockPhone : IAllPhone
    {
        private readonly IPhonesCategory categoryPhone = new mockCategory();

        public IEnumerable<Phone> phones {
            get
            {
                return new List<Phone>
                {
                    new Phone{
                        namePhone ="iPhone SE 2 выйдет в новом дизайне",
                        companyPhone = "Apple",
                        ramPhone = "3 ГБ",
                        cpuPhone = "Apple A13 Bionic",
                        shortDesc = "iPhone SE 2 находится в разработке и его представят весной 2020 года.",
                        fullDesc = "Да, смартфон выйдет в абсолютно новом дизайне для линейки SE. А если точнее, то это будет копия iPhone 8, как и сообщалось ранее. То есть будет кнопка с Touch ID и даже никакого намёка на безрамочный дисплей.Одна основная камера, стеклянная задняя панель с поддержкой беспроводной зарядки, а также разъём Lightning. Характеристики, правда, как у iPhone 11: процессор Apple A13 Bionic и 3 ГБ оперативной памяти.",
                        img = "/images/SE.jpg",
                        isFavorite = true,
                        Category = categoryPhone.getAllCategories.First()
                    }
                    

                };
            }
        }
        public IEnumerable<Phone> showFavPhones { get; set; }

        public Phone showPhone(int idPhone)
        {
            throw new NotImplementedException();
        }
    }
}
