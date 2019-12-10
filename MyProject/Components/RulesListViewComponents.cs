using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.Components
{
    public class RulesListViewComponents : ViewComponent
    {
        List<string> users;
        public RulesListViewComponents()
        {
            users = new List<string>
            {
                "Не флудить", "Без мата", "Без оскорблений"
            };
        }
        public IViewComponentResult Invoke()
        {
            return View(users);
        }
    }
}
