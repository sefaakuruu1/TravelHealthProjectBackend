#pragma checksum "C:\Users\ege.eren\source\repos\Deeneme2\Deeneme2\Views\TravelForms\GetAllEntries.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8eb55cd3cd300edf4b03c075ff962d2d64707301"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TravelForms_GetAllEntries), @"mvc.1.0.view", @"/Views/TravelForms/GetAllEntries.cshtml")]
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
#line 1 "C:\Users\ege.eren\source\repos\Deeneme2\Deeneme2\Views\_ViewImports.cshtml"
using Deeneme2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ege.eren\source\repos\Deeneme2\Deeneme2\Views\_ViewImports.cshtml"
using Deeneme2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8eb55cd3cd300edf4b03c075ff962d2d64707301", @"/Views/TravelForms/GetAllEntries.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa1396555fe08f0835167d36785c98bd80701257", @"/Views/_ViewImports.cshtml")]
    public class Views_TravelForms_GetAllEntries : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Deeneme2.Models.TravelForm>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h2>All Travel Forms</h2>

<table class=""table"">
    <thead>
        <tr>
            <th>Travel Start Date</th>
            <th>Travel End Date</th>
            <th>Country</th>
            <!-- Diğer sütun başlıkları -->
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 15 "C:\Users\ege.eren\source\repos\Deeneme2\Deeneme2\Views\TravelForms\GetAllEntries.cshtml"
         foreach (var form in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 18 "C:\Users\ege.eren\source\repos\Deeneme2\Deeneme2\Views\TravelForms\GetAllEntries.cshtml"
               Write(form.TravelStartDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 19 "C:\Users\ege.eren\source\repos\Deeneme2\Deeneme2\Views\TravelForms\GetAllEntries.cshtml"
               Write(form.TravelEndDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 20 "C:\Users\ege.eren\source\repos\Deeneme2\Deeneme2\Views\TravelForms\GetAllEntries.cshtml"
               Write(form.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <!-- Diğer sütunlar -->\r\n            </tr>\r\n");
#nullable restore
#line 23 "C:\Users\ege.eren\source\repos\Deeneme2\Deeneme2\Views\TravelForms\GetAllEntries.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Deeneme2.Models.TravelForm>> Html { get; private set; }
    }
}
#pragma warning restore 1591
