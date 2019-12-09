using Microsoft.AspNetCore.Mvc;
using MyProject.Data.interfaces;
using MyProject.ViewsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyProject.Models;
using MyProject.Data;
using System.Data.Entity;

namespace MyProject.Controllers
{
    public class PhonesController : Controller
    {
        private readonly AppDbContext allPhones;
        private readonly AppDbContext allCategories;
        

        public PhonesController(AppDbContext allPhon, AppDbContext allCateg )
        {
            allPhones = allPhon;
            allCategories = allCateg;

        }

        public IActionResult Index()
        {
            return View(allPhones.Phone.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Phone phone)
        {            
            allPhones.Phone.Add(phone);
            await allPhones.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public IActionResult Information(int? id)
        {     
            
            if (id != null)
            {
                Phone phone = allPhones.Phone.FirstOrDefault(p => p.id == id);
                if (phone != null)
                    return View(phone);                     
            }
            return NotFound();

            }

    }
    
}
