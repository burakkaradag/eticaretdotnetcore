#pragma checksum "C:\Users\iau\Desktop\ProjeFatihBurak2ugrastıgım\ETicaret\ETicaret\Areas\Admin\Views\Gallery\Liste.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f62a2929e4cdc795e35da8a589ea79a9cc99b7c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Gallery_Liste), @"mvc.1.0.view", @"/Areas/Admin/Views/Gallery/Liste.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Gallery/Liste.cshtml", typeof(AspNetCore.Areas_Admin_Views_Gallery_Liste))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f62a2929e4cdc795e35da8a589ea79a9cc99b7c5", @"/Areas/Admin/Views/Gallery/Liste.cshtml")]
    public class Areas_Admin_Views_Gallery_Liste : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ETicaret.Areas.Admin.Model.GalleryModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\iau\Desktop\ProjeFatihBurak2ugrastıgım\ETicaret\ETicaret\Areas\Admin\Views\Gallery\Liste.cshtml"
  
    ViewData["Title"] = "Liste";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(141, 161, true);
            WriteLiteral("\r\n<h1>Liste</h1>\r\n<table class=\"table table-bordered table-hover\">\r\n    <tr>\r\n        <td>Id</td>\r\n        <td>UrunId</td>\r\n        <td>Image</td>\r\n    </tr>\r\n\r\n");
            EndContext();
#line 15 "C:\Users\iau\Desktop\ProjeFatihBurak2ugrastıgım\ETicaret\ETicaret\Areas\Admin\Views\Gallery\Liste.cshtml"
     foreach (var item in Model.Glist)
    {

#line default
#line hidden
            BeginContext(349, 22, true);
            WriteLiteral("    <tr>\r\n        <td>");
            EndContext();
            BeginContext(372, 12, false);
#line 18 "C:\Users\iau\Desktop\ProjeFatihBurak2ugrastıgım\ETicaret\ETicaret\Areas\Admin\Views\Gallery\Liste.cshtml"
       Write(item.imageId);

#line default
#line hidden
            EndContext();
            BeginContext(384, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(404, 14, false);
#line 19 "C:\Users\iau\Desktop\ProjeFatihBurak2ugrastıgım\ETicaret\ETicaret\Areas\Admin\Views\Gallery\Liste.cshtml"
       Write(item.productId);

#line default
#line hidden
            EndContext();
            BeginContext(418, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 20 "C:\Users\iau\Desktop\ProjeFatihBurak2ugrastıgım\ETicaret\ETicaret\Areas\Admin\Views\Gallery\Liste.cshtml"
         if (item.image == null)
        {

#line default
#line hidden
            BeginContext(470, 14, true);
            WriteLiteral("        <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 484, "\"", 531, 2);
            WriteAttributeValue("", 491, "/Admin/Gallery/EkleCoklu/", 491, 25, true);
#line 22 "C:\Users\iau\Desktop\ProjeFatihBurak2ugrastıgım\ETicaret\ETicaret\Areas\Admin\Views\Gallery\Liste.cshtml"
WriteAttributeValue("", 516, item.productId, 516, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(532, 17, true);
            WriteLiteral("> Ekle</a></td>\r\n");
            EndContext();
#line 23 "C:\Users\iau\Desktop\ProjeFatihBurak2ugrastıgım\ETicaret\ETicaret\Areas\Admin\Views\Gallery\Liste.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(585, 20, true);
            WriteLiteral("            <td><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 605, "\"", 623, 2);
            WriteAttributeValue("", 611, "/", 611, 1, true);
#line 26 "C:\Users\iau\Desktop\ProjeFatihBurak2ugrastıgım\ETicaret\ETicaret\Areas\Admin\Views\Gallery\Liste.cshtml"
WriteAttributeValue("", 612, item.image, 612, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(624, 33, true);
            WriteLiteral(" height=\"50\" width=\"50\" /></td>\r\n");
            EndContext();
#line 27 "C:\Users\iau\Desktop\ProjeFatihBurak2ugrastıgım\ETicaret\ETicaret\Areas\Admin\Views\Gallery\Liste.cshtml"
        }

#line default
#line hidden
            BeginContext(668, 13, true);
            WriteLiteral("\r\n    </tr>\r\n");
            EndContext();
#line 30 "C:\Users\iau\Desktop\ProjeFatihBurak2ugrastıgım\ETicaret\ETicaret\Areas\Admin\Views\Gallery\Liste.cshtml"
    }

#line default
#line hidden
            BeginContext(688, 10, true);
            WriteLiteral("</table>\r\n");
            EndContext();
            BeginContext(699, 41, false);
#line 32 "C:\Users\iau\Desktop\ProjeFatihBurak2ugrastıgım\ETicaret\ETicaret\Areas\Admin\Views\Gallery\Liste.cshtml"
Write(Html.ActionLink("EkleCoklu", "EkleCoklu"));

#line default
#line hidden
            EndContext();
            BeginContext(740, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ETicaret.Areas.Admin.Model.GalleryModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
