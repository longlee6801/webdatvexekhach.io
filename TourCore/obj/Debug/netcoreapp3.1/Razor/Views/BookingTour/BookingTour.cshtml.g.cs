#pragma checksum "C:\Users\tuf\Desktop\TourCore\TourCore\TourCore\TourCore\Views\BookingTour\BookingTour.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1d2c0d4694406bb67122d8580ab3dfce5820104"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BookingTour_BookingTour), @"mvc.1.0.view", @"/Views/BookingTour/BookingTour.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1d2c0d4694406bb67122d8580ab3dfce5820104", @"/Views/BookingTour/BookingTour.cshtml")]
    #nullable restore
    public class Views_BookingTour_BookingTour : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TourCore.Models.ViewModels.TourViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\tuf\Desktop\TourCore\TourCore\TourCore\TourCore\Views\BookingTour\BookingTour.cshtml"
 using (Html.BeginForm("BookingTour", "BookingTour", FormMethod.Post, new { @class = "row" }))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-sm-6 form-group contact-forms\">\r\n        ");
#nullable restore
#line 6 "C:\Users\tuf\Desktop\TourCore\TourCore\TourCore\TourCore\Views\BookingTour\BookingTour.cshtml"
   Write(Html.TextBox("Name", "", new { @class = "form-control", @placeholder = "Name" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 7 "C:\Users\tuf\Desktop\TourCore\TourCore\TourCore\TourCore\Views\BookingTour\BookingTour.cshtml"
   Write(Html.ValidationMessage("Name", "", new { @style = "color:red;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-sm-6 form-group contact-forms\">\r\n        ");
#nullable restore
#line 10 "C:\Users\tuf\Desktop\TourCore\TourCore\TourCore\TourCore\Views\BookingTour\BookingTour.cshtml"
   Write(Html.TextBox("Email", "", new { @class = "form-control", @placeholder = "Email" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 11 "C:\Users\tuf\Desktop\TourCore\TourCore\TourCore\TourCore\Views\BookingTour\BookingTour.cshtml"
   Write(Html.ValidationMessage("Email","",new {@style="color:red;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-sm-6 form-group contact-forms\">\r\n        ");
#nullable restore
#line 14 "C:\Users\tuf\Desktop\TourCore\TourCore\TourCore\TourCore\Views\BookingTour\BookingTour.cshtml"
   Write(Html.TextBox("Phone", "", new { @class = "form-control", @placeholder = "Phone" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 15 "C:\Users\tuf\Desktop\TourCore\TourCore\TourCore\TourCore\Views\BookingTour\BookingTour.cshtml"
   Write(Html.ValidationMessage("Phone", "", new { @style = "color:red;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-sm-6 form-group contact-forms\">\r\n        ");
#nullable restore
#line 18 "C:\Users\tuf\Desktop\TourCore\TourCore\TourCore\TourCore\Views\BookingTour\BookingTour.cshtml"
   Write(Html.TextBox("Address", "", new { @class = "form-control", @placeholder = "Address" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 19 "C:\Users\tuf\Desktop\TourCore\TourCore\TourCore\TourCore\Views\BookingTour\BookingTour.cshtml"
   Write(Html.ValidationMessage("Address", "", new { @style = "color:red;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-sm-6 form-group contact-forms\">\r\n        ");
#nullable restore
#line 22 "C:\Users\tuf\Desktop\TourCore\TourCore\TourCore\TourCore\Views\BookingTour\BookingTour.cshtml"
   Write(Html.TextBox("PeopleGo", "", new { @class = "form-control", @placeholder = "People Go", id = "b" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 23 "C:\Users\tuf\Desktop\TourCore\TourCore\TourCore\TourCore\Views\BookingTour\BookingTour.cshtml"
   Write(Html.ValidationMessage("PeopleGo","", new { @style = "color:red;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

    </div>
    <div class=""col-sm-6 form-group contact-forms"">
        <input type=""text"" name=""Content"" class=""form-control"" placeholder=""Gửi yêu cầu"" />
    </div>
    <div class=""col-sm-6 form-group contact-forms"">
        <input type=""date"" name=""BeginDate"" class=""form-control"" placeholder=""Ngày khách muốn đi"" />
    </div>
    <input type=""hidden"" name=""TourId""");
            BeginWriteAttribute("value", " value=\"", 1707, "\"", 1724, 1);
#nullable restore
#line 32 "C:\Users\tuf\Desktop\TourCore\TourCore\TourCore\TourCore\Views\BookingTour\BookingTour.cshtml"
WriteAttributeValue("", 1715, Model.Id, 1715, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <div class=\"col-md-12 booking-button\">\r\n        <button type=\"submit\" class=\"btn btn-block sent-butnn\" id=\"btnSubmit\">Đặt Tour</button>\r\n    </div>\r\n");
#nullable restore
#line 36 "C:\Users\tuf\Desktop\TourCore\TourCore\TourCore\TourCore\Views\BookingTour\BookingTour.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TourCore.Models.ViewModels.TourViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
