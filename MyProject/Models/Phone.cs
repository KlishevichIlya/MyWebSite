using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.Models
{
    public class Phone
    {
        public int id { get; set; }
        public string namePhone { get; set; }
        public string companyPhone { get; set; }
        public string ramPhone { get; set; }
        public string cpuPhone { get; set; }
        public string shortDesc { get; set; }
        public string fullDesc { get; set; }
        public string img { get; set; }
        public bool isFavorite { get; set;}
        public int categoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
