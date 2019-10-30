using Microsoft.AspNetCore.Mvc;
using MyProject.Data.interfaces;
using MyProject.ViewsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace MyProject.Controllers
{
    public class PhonesController : Controller
    {
        private readonly IAllPhone allPhones;
        private readonly IPhonesCategory allCategories;
        

        public PhonesController(IAllPhone allPhon, IPhonesCategory allCateg )
        {
            allPhones = allPhon;
            allCategories = allCateg;
         
        }


        public ViewResult List()
        {
            ViewBag.Title = "Все самое интересное об IT";
            PhonesListViewModel temp = new PhonesListViewModel();
            temp.allPhones = allPhones.phones;
            temp.curCat = "Блоги о телефонах";
            return View(temp);
        }

        public ViewResult Information()
        {
            ViewBag.Title = "Информация";
            PhonesListViewModel temp = new PhonesListViewModel();
            temp.allPhones = allPhones.phones;
            temp.curCat = "Подробнее о телефоне";
            return View(temp);
        }
        
        
    }
    
}
