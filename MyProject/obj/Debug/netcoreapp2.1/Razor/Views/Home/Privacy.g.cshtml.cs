#pragma checksum "C:\Users\Ilya\source\repos\MyProject\MyProject\Views\Home\Privacy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "107ec39bfc90523f3c254122d7a3cdf6a2ef6dce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Privacy), @"mvc.1.0.razor-page", @"/Views/Home/Privacy.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Views/Home/Privacy.cshtml", typeof(AspNetCore.Views_Home_Privacy), null)]
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
#line 3 "C:\Users\Ilya\source\repos\MyProject\MyProject\Views\Home\Privacy.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#line 5 "C:\Users\Ilya\source\repos\MyProject\MyProject\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"107ec39bfc90523f3c254122d7a3cdf6a2ef6dce", @"/Views/Home/Privacy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ef5f1ef31367949e2cea7bbc7b6fd608ca466df", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Privacy : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/signalr/dist/browser/signalr.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/chat.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(133, 110, true);
            WriteLiteral("<div class=\"container\">\r\n    <div class=\"row\">&nbsp;</div>\r\n    <div class=\"row\">\r\n        <div class=\"col-2\">");
            EndContext();
            BeginContext(244, 17, false);
#line 8 "C:\Users\Ilya\source\repos\MyProject\MyProject\Views\Home\Privacy.cshtml"
                      Write(Localizer["User"]);

#line default
#line hidden
            EndContext();
            BeginContext(261, 141, true);
            WriteLiteral("</div>\r\n        <div class=\"col-4\"><input type=\"text\" id=\"userInput\" /></div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-2\">");
            EndContext();
            BeginContext(403, 20, false);
#line 12 "C:\Users\Ilya\source\repos\MyProject\MyProject\Views\Home\Privacy.cshtml"
                      Write(Localizer["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(423, 229, true);
            WriteLiteral("</div>\r\n        <div class=\"col-4\"><input type=\"text\" id=\"messageInput\" /></div>\r\n    </div>\r\n    <div class=\"row\">&nbsp;</div>\r\n    <div class=\"row\">\r\n        <div class=\"col-6\">\r\n            <input type=\"button\" id=\"sendButton\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 652, "\"", 680, 1);
#line 18 "C:\Users\Ilya\source\repos\MyProject\MyProject\Views\Home\Privacy.cshtml"
WriteAttributeValue("", 660, Localizer["Button"], 660, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(681, 227, true);
            WriteLiteral(" />\r\n        </div>\r\n    </div>\r\n</div>\r\n<div class=\"row\">\r\n    <div class=\"col-12\">\r\n        <hr />\r\n    </div>\r\n</div>\r\n<div class=\"row\">\r\n    <div class=\"col-6\">\r\n        <ul id=\"messagesList\"></ul>\r\n    </div>\r\n</div>\r\n<h1>");
            EndContext();
            BeginContext(909, 15, false);
#line 32 "C:\Users\Ilya\source\repos\MyProject\MyProject\Views\Home\Privacy.cshtml"
Write(Localizer["H1"]);

#line default
#line hidden
            EndContext();
            BeginContext(924, 37, true);
            WriteLiteral(":</h1>\r\n<div class=\"row mt-5 mb-2\">\r\n");
            EndContext();
#line 34 "C:\Users\Ilya\source\repos\MyProject\MyProject\Views\Home\Privacy.cshtml"
      
        foreach (Comment comment in ViewBag.Comments)
        {

#line default
#line hidden
            BeginContext(1035, 56, true);
            WriteLiteral("            <div class=\"col-lg-4\">\r\n                <h3>");
            EndContext();
            BeginContext(1092, 16, false);
#line 38 "C:\Users\Ilya\source\repos\MyProject\MyProject\Views\Home\Privacy.cshtml"
               Write(comment.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(1108, 3, true);
            WriteLiteral(" : ");
            EndContext();
            BeginContext(1112, 12, false);
#line 38 "C:\Users\Ilya\source\repos\MyProject\MyProject\Views\Home\Privacy.cshtml"
                                   Write(comment.Text);

#line default
#line hidden
            EndContext();
            BeginContext(1124, 33, true);
            WriteLiteral("</h3><br />\r\n            </div>\r\n");
            EndContext();
#line 40 "C:\Users\Ilya\source\repos\MyProject\MyProject\Views\Home\Privacy.cshtml"

        }
    

#line default
#line hidden
            BeginContext(1177, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
            BeginContext(1185, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6219a920c72b4467b44063f42d843408", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1245, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1247, 36, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e9dfa8487d74d7986f1b479bfc17384", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1283, 2, true);
            WriteLiteral("\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MyProject.Models.Comment>> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IEnumerable<MyProject.Models.Comment>> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IEnumerable<MyProject.Models.Comment>>)PageContext?.ViewData;
        public IEnumerable<MyProject.Models.Comment> Model => ViewData.Model;
    }
}
#pragma warning restore 1591
