#pragma checksum "C:\Users\karol\Desktop\Repos\OndrejForal\week-07\day-01\BankOfSimba\Views\Home\PrintString.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac63f4148ac6a8b9a93488dd4e054f4b2486d56e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_PrintString), @"mvc.1.0.view", @"/Views/Home/PrintString.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac63f4148ac6a8b9a93488dd4e054f4b2486d56e", @"/Views/Home/PrintString.cshtml")]
    public class Views_Home_PrintString : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\karol\Desktop\Repos\OndrejForal\week-07\day-01\BankOfSimba\Views\Home\PrintString.cshtml"
Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</br>\r\n");
#nullable restore
#line 4 "C:\Users\karol\Desktop\Repos\OndrejForal\week-07\day-01\BankOfSimba\Views\Home\PrintString.cshtml"
Write(Html.Raw(Model));

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; }
    }
}
#pragma warning restore 1591
