#pragma checksum "C:\Users\karol\Desktop\Repos\OndrejForal\week-07\day-01\BankOfSimba\Views\Home\RaiseBalance.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1738a01aa3bd5fa4ad37a520a8d4764f631498fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_RaiseBalance), @"mvc.1.0.view", @"/Views/Home/RaiseBalance.cshtml")]
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
#nullable restore
#line 3 "C:\Users\karol\Desktop\Repos\OndrejForal\week-07\day-01\BankOfSimba\Views\Home\RaiseBalance.cshtml"
using BankOfSimba.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1738a01aa3bd5fa4ad37a520a8d4764f631498fb", @"/Views/Home/RaiseBalance.cshtml")]
    public class Views_Home_RaiseBalance : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BankAccount>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/StyleSheet.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n\r\n<html xmlns=\"http://www.w3.org/1999/xhtml\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1738a01aa3bd5fa4ad37a520a8d4764f631498fb4245", async() => {
                WriteLiteral("\r\n    <title>Bank Of Simba</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1738a01aa3bd5fa4ad37a520a8d4764f631498fb4543", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1738a01aa3bd5fa4ad37a520a8d4764f631498fb6512", async() => {
                WriteLiteral("\r\n    <table class=\"table\">\r\n\r\n        <tr class=\"table-header\">\r\n            <td>Name</td>\r\n            <td>Balance</td>\r\n            <td>Animal Species</td>\r\n            <td>Is King?:</td>\r\n            <td>Is Good Boy?:</td>\r\n\r\n\r\n        </tr>\r\n\r\n\r\n\r\n");
#nullable restore
#line 27 "C:\Users\karol\Desktop\Repos\OndrejForal\week-07\day-01\BankOfSimba\Views\Home\RaiseBalance.cshtml"
         foreach (var animal in Model)
        {
            var roleClass = animal.King ? "king" : "noob";



#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr");
                BeginWriteAttribute("class", " class=\"", 617, "\"", 635, 1);
#nullable restore
#line 32 "C:\Users\karol\Desktop\Repos\OndrejForal\week-07\day-01\BankOfSimba\Views\Home\RaiseBalance.cshtml"
WriteAttributeValue("", 625, roleClass, 625, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                <td>");
#nullable restore
#line 33 "C:\Users\karol\Desktop\Repos\OndrejForal\week-07\day-01\BankOfSimba\Views\Home\RaiseBalance.cshtml"
               Write(animal.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 34 "C:\Users\karol\Desktop\Repos\OndrejForal\week-07\day-01\BankOfSimba\Views\Home\RaiseBalance.cshtml"
               Write(animal.Balance);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 34 "C:\Users\karol\Desktop\Repos\OndrejForal\week-07\day-01\BankOfSimba\Views\Home\RaiseBalance.cshtml"
                               Write(animal.Currency);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n                <td>");
#nullable restore
#line 35 "C:\Users\karol\Desktop\Repos\OndrejForal\week-07\day-01\BankOfSimba\Views\Home\RaiseBalance.cshtml"
               Write(animal.AnimalType);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 36 "C:\Users\karol\Desktop\Repos\OndrejForal\week-07\day-01\BankOfSimba\Views\Home\RaiseBalance.cshtml"
                Write(animal.King ? "He Is King" : "No Way");

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 37 "C:\Users\karol\Desktop\Repos\OndrejForal\week-07\day-01\BankOfSimba\Views\Home\RaiseBalance.cshtml"
                Write(animal.GoodGuy ? "Good Boy" : "Ugly One");

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 40 "C:\Users\karol\Desktop\Repos\OndrejForal\week-07\day-01\BankOfSimba\Views\Home\RaiseBalance.cshtml"

        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </table>\r\n    <form action=\"/\" method=\"post\">\r\n        <input type=\"submit\" name=\"RaiseBalance\" value=\"Raise Balance\" >\r\n\r\n\r\n    </form>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BankAccount>> Html { get; private set; }
    }
}
#pragma warning restore 1591
