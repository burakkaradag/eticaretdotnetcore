#pragma checksum "C:\Users\iau\Desktop\ProjeFatihBurak2ugrastıgım\ETicaret\ETicaret\Areas\Admin\Views\Account\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35fefd0c7d0f8984f2ae883507a3c74169e6005c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Account_Register), @"mvc.1.0.view", @"/Areas/Admin/Views/Account/Register.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Account/Register.cshtml", typeof(AspNetCore.Areas_Admin_Views_Account_Register))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35fefd0c7d0f8984f2ae883507a3c74169e6005c", @"/Areas/Admin/Views/Account/Register.cshtml")]
    public class Areas_Admin_Views_Account_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ETicaret.Areas.Admin.Model.RegisterModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\iau\Desktop\ProjeFatihBurak2ugrastıgım\ETicaret\ETicaret\Areas\Admin\Views\Account\Register.cshtml"
  
    ViewData["Title"] = "Register";

#line default
#line hidden
            BeginContext(93, 107, true);
            WriteLiteral("\r\n<h1 style=\"color:red\">Register</h1>\r\n<form asp-contoller=\"Account\" action=\"Register\" method=\"post\">\r\n    ");
            EndContext();
            BeginContext(201, 23, false);
#line 8 "C:\Users\iau\Desktop\ProjeFatihBurak2ugrastıgım\ETicaret\ETicaret\Areas\Admin\Views\Account\Register.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(224, 103, true);
            WriteLiteral("\r\n\r\n    <div class=\"form-horizontal\">\r\n        <hr />\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(328, 97, false);
#line 14 "C:\Users\iau\Desktop\ProjeFatihBurak2ugrastıgım\ETicaret\ETicaret\Areas\Admin\Views\Account\Register.cshtml"
       Write(Html.LabelFor(model => model.UserName, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(425, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(481, 97, false);
#line 16 "C:\Users\iau\Desktop\ProjeFatihBurak2ugrastıgım\ETicaret\ETicaret\Areas\Admin\Views\Account\Register.cshtml"
           Write(Html.EditorFor(model => Model.UserName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(578, 86, true);
            WriteLiteral("\r\n\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(665, 94, false);
#line 21 "C:\Users\iau\Desktop\ProjeFatihBurak2ugrastıgım\ETicaret\ETicaret\Areas\Admin\Views\Account\Register.cshtml"
       Write(Html.LabelFor(model => model.Email, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(759, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(815, 94, false);
#line 23 "C:\Users\iau\Desktop\ProjeFatihBurak2ugrastıgım\ETicaret\ETicaret\Areas\Admin\Views\Account\Register.cshtml"
           Write(Html.EditorFor(model => Model.Email, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(909, 86, true);
            WriteLiteral("\r\n\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(996, 97, false);
#line 28 "C:\Users\iau\Desktop\ProjeFatihBurak2ugrastıgım\ETicaret\ETicaret\Areas\Admin\Views\Account\Register.cshtml"
       Write(Html.LabelFor(model => Model.Password, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1093, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(1149, 99, false);
#line 30 "C:\Users\iau\Desktop\ProjeFatihBurak2ugrastıgım\ETicaret\ETicaret\Areas\Admin\Views\Account\Register.cshtml"
           Write(Html.PasswordFor(model => Model.Password, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1248, 86, true);
            WriteLiteral("\r\n\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(1335, 104, false);
#line 35 "C:\Users\iau\Desktop\ProjeFatihBurak2ugrastıgım\ETicaret\ETicaret\Areas\Admin\Views\Account\Register.cshtml"
       Write(Html.LabelFor(model => Model.ConfirmPassword, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1439, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(1495, 106, false);
#line 37 "C:\Users\iau\Desktop\ProjeFatihBurak2ugrastıgım\ETicaret\ETicaret\Areas\Admin\Views\Account\Register.cshtml"
           Write(Html.PasswordFor(model => Model.ConfirmPassword, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1601, 277, true);
            WriteLiteral(@"

            </div>
        </div>
        <div class=""form-group"">
            <div class=""col-md-offset-2 col-md-10"">
                <input type=""submit"" value=""Kaydet"" class=""btn btn-default"" />
            </div>
        </div>
    </div>
</form>

<div>
    ");
            EndContext();
            BeginContext(1879, 40, false);
#line 50 "C:\Users\iau\Desktop\ProjeFatihBurak2ugrastıgım\ETicaret\ETicaret\Areas\Admin\Views\Account\Register.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(1919, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(1926, 33, false);
#line 51 "C:\Users\iau\Desktop\ProjeFatihBurak2ugrastıgım\ETicaret\ETicaret\Areas\Admin\Views\Account\Register.cshtml"
Write(Html.ActionLink("Login", "Login"));

#line default
#line hidden
            EndContext();
            BeginContext(1959, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ETicaret.Areas.Admin.Model.RegisterModel> Html { get; private set; }
    }
}
#pragma warning restore 1591