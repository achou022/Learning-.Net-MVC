#pragma checksum "/Users/andrewchou/Desktop/codingDojo/C#/ASP.Net/introASP/Views/Portfolio/index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8021caeaab86e85b6356d461cf6e64007cc8597b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Portfolio_index), @"mvc.1.0.view", @"/Views/Portfolio/index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Portfolio/index.cshtml", typeof(AspNetCore.Views_Portfolio_index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8021caeaab86e85b6356d461cf6e64007cc8597b", @"/Views/Portfolio/index.cshtml")]
    public class Views_Portfolio_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 33, true);
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n");
            EndContext();
            BeginContext(33, 357, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8021caeaab86e85b6356d461cf6e64007cc8597b2888", async() => {
                BeginContext(39, 344, true);
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <link href=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh"" crossorigin=""anonymous"">
    <title>Hello</title>
");
                EndContext();
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
            EndContext();
            BeginContext(390, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(391, 566, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8021caeaab86e85b6356d461cf6e64007cc8597b4403", async() => {
                BeginContext(397, 39, true);
                WriteLiteral("\n    <h1>\n        Sup World!\n    </h1>\n");
                EndContext();
#line 14 "/Users/andrewchou/Desktop/codingDojo/C#/ASP.Net/introASP/Views/Portfolio/index.cshtml"
      
        string[] stuff = {"Apple Pie", "Burritos", "Clams Casino", "Donuts"};
        for (int i = 0; i < stuff.Length; i++)
        {
            if(stuff[i].First() =='C'){

#line default
#line hidden
                BeginContext(649, 39, true);
                WriteLiteral("                <p style=\"color: red;\">");
                EndContext();
                BeginContext(689, 8, false);
#line 19 "/Users/andrewchou/Desktop/codingDojo/C#/ASP.Net/introASP/Views/Portfolio/index.cshtml"
                                  Write(stuff[i]);

#line default
#line hidden
                EndContext();
                BeginContext(697, 5, true);
                WriteLiteral("</p>\n");
                EndContext();
#line 20 "/Users/andrewchou/Desktop/codingDojo/C#/ASP.Net/introASP/Views/Portfolio/index.cshtml"
            } else{

#line default
#line hidden
                BeginContext(722, 19, true);
                WriteLiteral("                <p>");
                EndContext();
                BeginContext(742, 8, false);
#line 21 "/Users/andrewchou/Desktop/codingDojo/C#/ASP.Net/introASP/Views/Portfolio/index.cshtml"
              Write(stuff[i]);

#line default
#line hidden
                EndContext();
                BeginContext(750, 5, true);
                WriteLiteral("</p>\n");
                EndContext();
#line 22 "/Users/andrewchou/Desktop/codingDojo/C#/ASP.Net/introASP/Views/Portfolio/index.cshtml"
            }
        }
    

#line default
#line hidden
                BeginContext(785, 4, true);
                WriteLiteral("    ");
                EndContext();
                BeginContext(822, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 26 "/Users/andrewchou/Desktop/codingDojo/C#/ASP.Net/introASP/Views/Portfolio/index.cshtml"
      
        DateTime currentTime = DateTime.Now;

#line default
#line hidden
                BeginContext(875, 52, true);
                WriteLiteral("        <h4>The Current Time is... </h4>\n        <p>");
                EndContext();
                BeginContext(928, 11, false);
#line 29 "/Users/andrewchou/Desktop/codingDojo/C#/ASP.Net/introASP/Views/Portfolio/index.cshtml"
      Write(currentTime);

#line default
#line hidden
                EndContext();
                BeginContext(939, 5, true);
                WriteLiteral("</p>\n");
                EndContext();
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
            EndContext();
            BeginContext(957, 10, true);
            WriteLiteral("\n</html>  ");
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
