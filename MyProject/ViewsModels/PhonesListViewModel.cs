using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace MyProject.ViewsModels
{
    public class PhonesListViewModel
    {
        public IEnumerable<Phone> allPhones { get; set; }
        public string curCat { get; set; }
        
    }
}
