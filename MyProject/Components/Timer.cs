using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.Components
{
    public class Timer : ViewComponent
    {
        private readonly IStringLocalizer<Timer> _localizerNew;

        public Timer(IStringLocalizer<Timer> localizer)
        {
            _localizerNew = localizer;
        }

        public string Invoke()
        {
            return  $"{_localizerNew["H1"]} : {DateTime.UtcNow.ToString("HH:mm")}";
        }
    }
}
