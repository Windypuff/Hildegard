#pragma checksum "C:\Users\bensc\OneDrive\Documents\CS Projects\Hildegard\Views\Home\Students.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02fbd1f9dc299b16f9d49471baa1b57cd329aa74"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Students), @"mvc.1.0.view", @"/Views/Home/Students.cshtml")]
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
#line 1 "C:\Users\bensc\OneDrive\Documents\CS Projects\Hildegard\Views\_ViewImports.cshtml"
using Htest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\bensc\OneDrive\Documents\CS Projects\Hildegard\Views\Home\Students.cshtml"
using Htest.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02fbd1f9dc299b16f9d49471baa1b57cd329aa74", @"/Views/Home/Students.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"340edf49ce5be9d2c272bf3756ea67cfcfd10a24", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Students : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Student>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Display Students</h1>\r\n");
#nullable restore
#line 7 "C:\Users\bensc\OneDrive\Documents\CS Projects\Hildegard\Views\Home\Students.cshtml"
          foreach (var student in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <u1 class=\"list-group list-group-horizontal\">\r\n\r\n                    <li class = \"list-group-item flex-fill\"> \r\n                        ");
#nullable restore
#line 12 "C:\Users\bensc\OneDrive\Documents\CS Projects\Hildegard\Views\Home\Students.cshtml"
                   Write(student.firstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </li>\r\n                    <li class = \"list-group-item flex-fill\"> \r\n                        ");
#nullable restore
#line 15 "C:\Users\bensc\OneDrive\Documents\CS Projects\Hildegard\Views\Home\Students.cshtml"
                   Write(student.secondName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </li>\r\n                     <li class = \"list-group-item flex-fill\"> \r\n                        ");
#nullable restore
#line 18 "C:\Users\bensc\OneDrive\Documents\CS Projects\Hildegard\Views\Home\Students.cshtml"
                   Write(student.yearGroup);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </li>\r\n                    \r\n\r\n            </u1>\r\n");
#nullable restore
#line 23 "C:\Users\bensc\OneDrive\Documents\CS Projects\Hildegard\Views\Home\Students.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("   \r\n</div>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591
