using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.Models
{
    public class Category
    {
       public int id { get; set; }
       public string categoryName { get; set; }
       public string desc { get; set; }
       public List<Phone> phones { get; set; }
    }
}
