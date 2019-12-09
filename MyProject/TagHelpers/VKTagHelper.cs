using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.TagHelpers
{
    public class VKTagHelper : TagHelper
    {
        private const string address = "https://vk.com/itechart.group";
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            output.Attributes.SetAttribute("href", address);
            output.Content.SetContent("группе ВКонтакте");
        }
    }
}
