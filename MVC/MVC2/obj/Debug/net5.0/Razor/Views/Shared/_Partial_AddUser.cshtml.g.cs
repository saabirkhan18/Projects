#pragma checksum "D:\Saabir\Projects\MVC\MVC2\Views\Shared\_Partial_AddUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3a929b1633e6dce48b83e45e790b9fa8e92b36f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Partial_AddUser), @"mvc.1.0.view", @"/Views/Shared/_Partial_AddUser.cshtml")]
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
#line 1 "D:\Saabir\Projects\MVC\MVC2\Views\_ViewImports.cshtml"
using MVC2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Saabir\Projects\MVC\MVC2\Views\_ViewImports.cshtml"
using MVC2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3a929b1633e6dce48b83e45e790b9fa8e92b36f", @"/Views/Shared/_Partial_AddUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f29d135cc71deb2edc8d6b3a6cb1ab3f95ba2ade", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__Partial_AddUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MVC2.Models.Employee>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-md-6\">\r\n");
#nullable restore
#line 4 "D:\Saabir\Projects\MVC\MVC2\Views\Shared\_Partial_AddUser.cshtml"
         using (Html.BeginForm())
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Saabir\Projects\MVC\MVC2\Views\Shared\_Partial_AddUser.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"form-horizontal\">\r\n                <h4>ContactModel</h4>\r\n                <hr />\r\n                <div class=\"field-validation-error\">\r\n                    <p>");
#nullable restore
#line 12 "D:\Saabir\Projects\MVC\MVC2\Views\Shared\_Partial_AddUser.cshtml"
                  Write(ViewBag.ErrorMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n                ");
#nullable restore
#line 14 "D:\Saabir\Projects\MVC\MVC2\Views\Shared\_Partial_AddUser.cshtml"
           Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 16 "D:\Saabir\Projects\MVC\MVC2\Views\Shared\_Partial_AddUser.cshtml"
               Write(Html.LabelFor(model => model.Name, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <div class=\"col-md-10\">\r\n                        ");
#nullable restore
#line 18 "D:\Saabir\Projects\MVC\MVC2\Views\Shared\_Partial_AddUser.cshtml"
                   Write(Html.EditorFor(model => model.Name, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 19 "D:\Saabir\Projects\MVC\MVC2\Views\Shared\_Partial_AddUser.cshtml"
                   Write(Html.ValidationMessageFor(model => model.Name, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 24 "D:\Saabir\Projects\MVC\MVC2\Views\Shared\_Partial_AddUser.cshtml"
               Write(Html.LabelFor(model => model.Gender, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <div class=\"col-md-10\">\r\n                        Male\r\n                        ");
#nullable restore
#line 27 "D:\Saabir\Projects\MVC\MVC2\Views\Shared\_Partial_AddUser.cshtml"
                   Write(Html.RadioButtonFor(model => model.Gender, "Male"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        Female\r\n                        ");
#nullable restore
#line 29 "D:\Saabir\Projects\MVC\MVC2\Views\Shared\_Partial_AddUser.cshtml"
                   Write(Html.RadioButtonFor(model => model.Gender, "Female"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 33 "D:\Saabir\Projects\MVC\MVC2\Views\Shared\_Partial_AddUser.cshtml"
               Write(Html.LabelFor(model => model.Country, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <div class=\"col-md-10\">\r\n                        ");
#nullable restore
#line 35 "D:\Saabir\Projects\MVC\MVC2\Views\Shared\_Partial_AddUser.cshtml"
                   Write(Html.DropDownList("Country", new List<SelectListItem>()            {
                new SelectListItem() { Text = "India", Value = "India" } ,
                new SelectListItem() { Text = "USA", Value = "USA" }
            }, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 42 "D:\Saabir\Projects\MVC\MVC2\Views\Shared\_Partial_AddUser.cshtml"
               Write(Html.LabelFor(model => model.PhoneNumber, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <div class=\"col-md-10\">\r\n                        ");
#nullable restore
#line 44 "D:\Saabir\Projects\MVC\MVC2\Views\Shared\_Partial_AddUser.cshtml"
                   Write(Html.EditorFor(model => model.PhoneNumber, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 45 "D:\Saabir\Projects\MVC\MVC2\Views\Shared\_Partial_AddUser.cshtml"
                   Write(Html.ValidationMessageFor(model => model.PhoneNumber, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>

                <div class=""form-group"">
                    <div class=""col-md-offset-2 col-md-10"">
                        <input type=""submit"" value=""Create"" class=""btn btn-default"" />
                    </div>
                </div>
            </div>
");
#nullable restore
#line 55 "D:\Saabir\Projects\MVC\MVC2\Views\Shared\_Partial_AddUser.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MVC2.Models.Employee> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591