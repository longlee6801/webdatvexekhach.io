#pragma checksum "C:\Users\tuf\Desktop\TourCore\TourCore\TourCore\TourCore\Views\Admin\Payment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35088d63a57d254e57dc7c2337e5a316c40b2ad0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Payment), @"mvc.1.0.view", @"/Views/Admin/Payment.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35088d63a57d254e57dc7c2337e5a316c40b2ad0", @"/Views/Admin/Payment.cshtml")]
    #nullable restore
    public class Views_Admin_Payment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TourCore.Models.ViewModels.ContractDetailViewModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\tuf\Desktop\TourCore\TourCore\TourCore\TourCore\Views\Admin\Payment.cshtml"
  
    ViewData["Title"] = "Payment";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    tbody > tr > td {
        text-align: center;
    }

    thead > tr > th {
        text-align: center;
    }
</style>
<h1 style=""text-align:center;color:brown"">Danh sách khánh hàng đã thanh toán</h1>

<br />
<br />
<table class=""table"">
    <thead>
        <tr>
            <th>
                ");
#nullable restore
#line 23 "C:\Users\tuf\Desktop\TourCore\TourCore\TourCore\TourCore\Views\Admin\Payment.cshtml"
           Write(Html.DisplayNameFor(model => model.Code));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\tuf\Desktop\TourCore\TourCore\TourCore\TourCore\Views\Admin\Payment.cshtml"
           Write(Html.DisplayNameFor(model => model.NameTour));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "C:\Users\tuf\Desktop\TourCore\TourCore\TourCore\TourCore\Views\Admin\Payment.cshtml"
           Write(Html.DisplayNameFor(model => model.NameCustomer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "C:\Users\tuf\Desktop\TourCore\TourCore\TourCore\TourCore\Views\Admin\Payment.cshtml"
           Write(Html.DisplayNameFor(model => model.Cost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 38 "C:\Users\tuf\Desktop\TourCore\TourCore\TourCore\TourCore\Views\Admin\Payment.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                ");
#nullable restore
#line 41 "C:\Users\tuf\Desktop\TourCore\TourCore\TourCore\TourCore\Views\Admin\Payment.cshtml"
           Write(Html.HiddenFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <td>\r\n                    ");
#nullable restore
#line 43 "C:\Users\tuf\Desktop\TourCore\TourCore\TourCore\TourCore\Views\Admin\Payment.cshtml"
               Write(Html.DisplayFor(modelItem => item.Code));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 46 "C:\Users\tuf\Desktop\TourCore\TourCore\TourCore\TourCore\Views\Admin\Payment.cshtml"
               Write(Html.DisplayFor(modelItem => item.NameTour));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 49 "C:\Users\tuf\Desktop\TourCore\TourCore\TourCore\TourCore\Views\Admin\Payment.cshtml"
               Write(Html.DisplayFor(modelItem => item.NameCustomer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 52 "C:\Users\tuf\Desktop\TourCore\TourCore\TourCore\TourCore\Views\Admin\Payment.cshtml"
               Write(item.Cost.Value.ToString("#,##"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 55 "C:\Users\tuf\Desktop\TourCore\TourCore\TourCore\TourCore\Views\Admin\Payment.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TourCore.Models.ViewModels.ContractDetailViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
