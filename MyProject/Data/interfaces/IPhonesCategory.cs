﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace MyProject.Data.interfaces
{
    public interface IPhonesCategory  
    {
        IEnumerable<Category> getAllCategories { get; }
    }
}
