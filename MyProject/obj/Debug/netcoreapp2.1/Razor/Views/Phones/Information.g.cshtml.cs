#pragma checksum "C:\Users\Ilya\source\repos\MyProject\MyProject\Views\Phones\Information.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87678ccb82e245849521d7a7f5cfe20a1daca760"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Phones_Information), @"mvc.1.0.view", @"/Views/Phones/Information.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Phones/Information.cshtml", typeof(AspNetCore.Views_Phones_Information))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Ilya\source\repos\MyProject\MyProject\Views\_ViewImports.cshtml"
using MyProject;

#line default
#line hidden
#line 2 "C:\Users\Ilya\source\repos\MyProject\MyProject\Views\_ViewImports.cshtml"
using MyProject.Models;

#line default
#line hidden
#line 3 "C:\Users\Ilya\source\repos\MyProject\MyProject\Views\_ViewImports.cshtml"
using MyProject.ViewsModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87678ccb82e245849521d7a7f5cfe20a1daca760", @"/Views/Phones/Information.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8346a9e56f217a4bd34523a3946ed5f2113b86d6", @"/Views/_ViewImports.cshtml")]
    public class Views_Phones_Information : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 25, true);
            WriteLiteral("<h1>Информация</h1>\r\n<h3>");
            EndContext();
            BeginContext(26, 12, false);
#line 2 "C:\Users\Ilya\source\repos\MyProject\MyProject\Views\Phones\Information.cshtml"
Write(Model.curCat);

#line default
#line hidden
            EndContext();
            BeginContext(38, 36, true);
            WriteLiteral("</h3>\r\n<div class=\"row mt-5 mb-2\">\r\n");
            EndContext();
#line 4 "C:\Users\Ilya\source\repos\MyProject\MyProject\Views\Phones\Information.cshtml"
      
        foreach (var a in Model.allPhones)
        {
            if (a.id == 6003)
            {

#line default
#line hidden
            BeginContext(183, 42, true);
            WriteLiteral("                <img class=\"img-thumbnail\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 225, "\"", 237, 1);
#line 9 "C:\Users\Ilya\source\repos\MyProject\MyProject\Views\Phones\Information.cshtml"
WriteAttributeValue("", 231, a.img, 231, 6, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(238, 25, true);
            WriteLiteral(" />\r\n                <h2>");
            EndContext();
            BeginContext(264, 11, false);
#line 10 "C:\Users\Ilya\source\repos\MyProject\MyProject\Views\Phones\Information.cshtml"
               Write(a.namePhone);

#line default
#line hidden
            EndContext();
            BeginContext(275, 32, true);
            WriteLiteral("</h2><br />\r\n                <p>");
            EndContext();
            BeginContext(308, 11, false);
#line 11 "C:\Users\Ilya\source\repos\MyProject\MyProject\Views\Phones\Information.cshtml"
              Write(a.shortDesc);

#line default
#line hidden
            EndContext();
            BeginContext(319, 25, true);
            WriteLiteral("</p>\r\n                <p>");
            EndContext();
            BeginContext(345, 10, false);
#line 12 "C:\Users\Ilya\source\repos\MyProject\MyProject\Views\Phones\Information.cshtml"
              Write(a.fullDesc);

#line default
#line hidden
            EndContext();
            BeginContext(355, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 13 "C:\Users\Ilya\source\repos\MyProject\MyProject\Views\Phones\Information.cshtml"
                break;
            }
        }
        

#line default
#line hidden
            BeginContext(422, 16, true);
            WriteLiteral("</div>\r\n\r\n\r\n\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
