﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace MyProject.Data.interfaces
{
    public interface IAllPhone
    {
        IEnumerable<Phone> phones { get; }
        IEnumerable<Phone> showFavPhones { get; }
        Phone showPhone(int idPhone);
    }
}
