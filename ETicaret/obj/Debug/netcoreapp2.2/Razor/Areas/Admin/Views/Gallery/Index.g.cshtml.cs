#pragma checksum "C:\Users\iau\Desktop\ProjeFatihBurak2ugrastıgım\ETicaret\ETicaret\Areas\Admin\Views\Gallery\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2497e9f128c2fa96bed1ebf98d467732a05c4b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Gallery_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Gallery/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Gallery/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Gallery_Index))]
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
#line 1 "C:\Users\iau\Desktop\ProjeFatihBurak2ugrastıgım\ETicaret\ETicaret\Areas\Admin\Views\Gallery\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2497e9f128c2fa96bed1ebf98d467732a05c4b1", @"/Areas/Admin/Views/Gallery/Index.cshtml")]
    public class Areas_Admin_Views_Gallery_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "C:\Users\iau\Desktop\ProjeFatihBurak2ugrastıgım\ETicaret\ETicaret\Areas\Admin\Views\Gallery\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#line 8 "C:\Users\iau\Desktop\ProjeFatihBurak2ugrastıgım\ETicaret\ETicaret\Areas\Admin\Views\Gallery\Index.cshtml"
 if (SignInManager.IsSignedIn(User))
{

#line default
#line hidden
            BeginContext(270, 40, true);
            WriteLiteral("<h1 style=\"color:dimgray\">\r\n    Sevgili ");
            EndContext();
            BeginContext(311, 29, false);
#line 11 "C:\Users\iau\Desktop\ProjeFatihBurak2ugrastıgım\ETicaret\ETicaret\Areas\Admin\Views\Gallery\Index.cshtml"
       Write(UserManager.GetUserName(User));

#line default
#line hidden
            EndContext();
            BeginContext(340, 21, true);
            WriteLiteral(" HoşGeldin:)\r\n</h1>\r\n");
            EndContext();
#line 13 "C:\Users\iau\Desktop\ProjeFatihBurak2ugrastıgım\ETicaret\ETicaret\Areas\Admin\Views\Gallery\Index.cshtml"
}

#line default
#line hidden
            BeginContext(364, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
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
