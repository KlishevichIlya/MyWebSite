using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.Components
{
    public class Timer : ViewComponent
    {
        public string Invoke()
        {
            return $"Текущее время:{DateTime.UtcNow.ToString("HH:mm")}";
        }
    }
}
