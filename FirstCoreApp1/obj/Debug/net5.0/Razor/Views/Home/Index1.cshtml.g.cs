#pragma checksum "C:\Users\sangavis1\source\repos\FirstCoreApp1\FirstCoreApp1\Views\Home\Index1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b60722ba779c0d2da1766fffd522a3827158e879"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index1), @"mvc.1.0.view", @"/Views/Home/Index1.cshtml")]
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
#line 1 "C:\Users\sangavis1\source\repos\FirstCoreApp1\FirstCoreApp1\Views\_ViewImports.cshtml"
using FirstCoreApp1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sangavis1\source\repos\FirstCoreApp1\FirstCoreApp1\Views\_ViewImports.cshtml"
using FirstCoreApp1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b60722ba779c0d2da1766fffd522a3827158e879", @"/Views/Home/Index1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a409b7f3676efb6da77599e0c1dd6b1d72f2beb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<FirstCoreApp1.Models.PostViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\sangavis1\source\repos\FirstCoreApp1\FirstCoreApp1\Views\Home\Index1.cshtml"
   ViewData["title"] = "HomePage";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""row"">
    <h2> POSTLIST</h2>
    <table class=""table"">
        <thead>
            <tr>
                <th>
                    PostID
                </th>
                <th>
                    Title
                </th>
                <th>
                    Description
                </th>
                <th>
                    Author
                </th>
            </tr>

        </thead>
        <tbody>
");
#nullable restore
#line 31 "C:\Users\sangavis1\source\repos\FirstCoreApp1\FirstCoreApp1\Views\Home\Index1.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 35 "C:\Users\sangavis1\source\repos\FirstCoreApp1\FirstCoreApp1\Views\Home\Index1.cshtml"
                   Write(Html.DisplayFor(Modelitem => item.postId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 38 "C:\Users\sangavis1\source\repos\FirstCoreApp1\FirstCoreApp1\Views\Home\Index1.cshtml"
                   Write(Html.DisplayFor(Modelitem => item.title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 41 "C:\Users\sangavis1\source\repos\FirstCoreApp1\FirstCoreApp1\Views\Home\Index1.cshtml"
                   Write(Html.DisplayFor(Modelitem => item.description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 44 "C:\Users\sangavis1\source\repos\FirstCoreApp1\FirstCoreApp1\Views\Home\Index1.cshtml"
                   Write(Html.DisplayFor(Modelitem => item.author));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 47 "C:\Users\sangavis1\source\repos\FirstCoreApp1\FirstCoreApp1\Views\Home\Index1.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n\r\n    </table>\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<FirstCoreApp1.Models.PostViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591