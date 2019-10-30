using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyProject.Models;

namespace MyProject.Data
{
    public class ObjectsDB
    {
        public static void Initial(AppDbContext context)
        {
           // context.Phone.RemoveRange(context.Phone);
           // context.Category.RemoveRange(context.Category);
            context.Database.Migrate();
            if(!context.Category.Any())
            {
                context.Category.AddRange(Categories.Select(temp => temp.Value));
            }

            if (!context.Phone.Any())
            {
                context.AddRange(
                    new Phone
                    {
                        namePhone = "iPhone SE 2 выйдет в новом дизайне",
                        companyPhone = "Apple",
                        ramPhone = "3 ГБ",
                        cpuPhone = "Apple A13 Bionic",
                        shortDesc = "iPhone SE 2 находится в разработке и его представят весной 2020 года.",
                        fullDesc = "Да, смартфон выйдет в абсолютно новом дизайне для линейки SE. А если точнее, то это будет копия iPhone 8, как и сообщалось ранее. То есть будет кнопка с Touch ID и даже никакого намёка на безрамочный дисплей.Одна основная камера, стеклянная задняя панель с поддержкой беспроводной зарядки, а также разъём Lightning. Характеристики, правда, как у iPhone 11: процессор Apple A13 Bionic и 3 ГБ оперативной памяти.",
                        img = "/images/SE.jpg",
                        isFavorite = true,
                        Category = Categories["Телефоны"]
                    },
                     new Phone
                     {
                         namePhone = "Презентация нового ASUS ZenFone 5",
                         companyPhone = "ASUS",
                         ramPhone = "4 ГБ",
                         cpuPhone = " Qualcomm Snapdragon 636",
                         shortDesc = "ASUS представила в Москве новый ZenFone 5 и доступный ZenFone 5 Lite",
                         fullDesc = "Компания ASUS анонсировала для российского рынка три новых смартфона: полуфлагман ZenFone 5, его «облегченный» вариант ZenFone 5 Lite и ZenFone Max с мощной батареей. Все новинки ускорены функцией искусственного интеллекта AI Boost, обладают просторными экранами и двойными камерами.6,2-дюймовый экран ZenFone 5 занимает 90% его лицевой площади. Смартфон оборудован процессором Qualcomm Snapdragon 636, графикой Adreno 509 и LTE-модемом Snapdragon X12, обеспечивающим максимальную скорость скачивания в сотовых сетях до 600 Мбит/с. Установлено 4 гигабайта оперативной и 64 ГБ встроенной памяти.",
                         img = "/images/ASUS.jpg",
                         isFavorite = false,
                         Category = Categories["Телефоны"]
                     },
                    new Phone
                    {
                        namePhone = "Слухи об HTC U12+",
                        companyPhone = "HTC",
                        ramPhone = "6 ГБ",
                        cpuPhone = " Qualcomm Snapdragon 845",
                        shortDesc = "HTC U12+: дизайн флагмана с четырьмя камерами полностью раскрыли",
                        fullDesc = "Компания HTC в этом году представит только один флагман, и почему-то называться он будет U12+, а не просто U12. Анонс состоится уже в мае, так что появляется все больше утечек — на этот раз производитель защитных пленок помог раскрыть дизайн смартфона. Цена HTC U12+ пока не известна, но вряд ли он будет стоить дороже прошлой моделиU11+ на старте.",
                        img = "/images/HTC122.jpg",
                        isFavorite = false,
                        Category = Categories["Телефоны"]
                    },
                     new Phone
                     {
                         namePhone = "Начало продаж Blackview P10000 Pro ",
                         companyPhone = "Blackview",
                         ramPhone = "4 ГБ",
                         cpuPhone = "MediaTek (MT6763)",
                         shortDesc = "В Китае начали продавать смартфон Blackview P10000 Pro с батареей на 11 000 мА*ч",
                         fullDesc = "Китайский бренд Blackview выпустил смартфон с аккумулятором, номинальная емкость которого сопоставима с батареей ноутбука. Новинка комплектуется аккумулятором рекордного объема — на 11 тысяч мАч, что в несколько раз больше, чем у конкурирующих устройств (1500–3000 мАч). По емкости батареи P10000 Pro превосходит прошлого рекордсмена Oukitel K10000, который комплектовался аккумулятором на 10 000 мАч и полностью заряжался за 3,5 часа.",
                         img = "/images/charge.jpg",
                         isFavorite = false,
                         Category = Categories["Телефоны"]
                     }


                   );
            }       
            
            context.SaveChanges();
        }

        private static Dictionary<string, Category> categ;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if(categ == null)
                {
                    var list = new Category[]
                    {
                        new Category{categoryName = "Телефоны", desc = "Заметки о разработках телефонов"},
                        new Category{categoryName = "Аксессуары ", desc = "Всё самое необходимое для Вашего смартфона"}
                    };
                    categ = new Dictionary<string, Category>();
                    foreach(Category c in list)                    
                        categ.Add(c.categoryName, c);                                                          
                }
                return categ;
            }
        }
    }
}
