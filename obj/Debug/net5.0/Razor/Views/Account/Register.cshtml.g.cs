#pragma checksum "C:\Users\mdkir\Documents\University\Subjects\Web\Курсова\CourseWork\Views\Account\Register.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "d8c0a255b2503ff31d93c3848f87e7d80a3cb2a09c4d6a378af9fdde6f065dec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Register), @"mvc.1.0.view", @"/Views/Account/Register.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\mdkir\Documents\University\Subjects\Web\Курсова\CourseWork\Views\_ViewImports.cshtml"
using CourseWork;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mdkir\Documents\University\Subjects\Web\Курсова\CourseWork\Views\_ViewImports.cshtml"
using CourseWork.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mdkir\Documents\University\Subjects\Web\Курсова\CourseWork\Views\_ViewImports.cshtml"
using CourseWork.Domain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mdkir\Documents\University\Subjects\Web\Курсова\CourseWork\Views\_ViewImports.cshtml"
using CourseWork.Domain.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mdkir\Documents\University\Subjects\Web\Курсова\CourseWork\Views\_ViewImports.cshtml"
using CourseWork.Domain.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mdkir\Documents\University\Subjects\Web\Курсова\CourseWork\Views\_ViewImports.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"d8c0a255b2503ff31d93c3848f87e7d80a3cb2a09c4d6a378af9fdde6f065dec", @"/Views/Account/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"cfe9082c7919763ebd48d3d0e17a27a50a4a1dd8862f190512b02f18f41fa0d1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Account_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RegisterViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Регистрация аккаунта</h1>\r\n");
#nullable restore
#line 4 "C:\Users\mdkir\Documents\University\Subjects\Web\Курсова\CourseWork\Views\Account\Register.cshtml"
 using (Html.BeginForm("Register", "Account", ViewBag.ReturnURL, FormMethod.Post, true, null))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        ");
#nullable restore
#line 7 "C:\Users\mdkir\Documents\University\Subjects\Web\Курсова\CourseWork\Views\Account\Register.cshtml"
   Write(Html.LabelFor(x=>x.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 8 "C:\Users\mdkir\Documents\University\Subjects\Web\Курсова\CourseWork\Views\Account\Register.cshtml"
   Write(Html.TextBoxFor(x=>x.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 9 "C:\Users\mdkir\Documents\University\Subjects\Web\Курсова\CourseWork\Views\Account\Register.cshtml"
   Write(Html.ValidationMessageFor(x=>x.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n        ");
#nullable restore
#line 12 "C:\Users\mdkir\Documents\University\Subjects\Web\Курсова\CourseWork\Views\Account\Register.cshtml"
   Write(Html.LabelFor(x=>x.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 13 "C:\Users\mdkir\Documents\University\Subjects\Web\Курсова\CourseWork\Views\Account\Register.cshtml"
   Write(Html.TextBoxFor(x=>x.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 14 "C:\Users\mdkir\Documents\University\Subjects\Web\Курсова\CourseWork\Views\Account\Register.cshtml"
   Write(Html.ValidationMessageFor(x=>x.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n        ");
#nullable restore
#line 17 "C:\Users\mdkir\Documents\University\Subjects\Web\Курсова\CourseWork\Views\Account\Register.cshtml"
   Write(Html.LabelFor(x=>x.RepeatPassword));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 18 "C:\Users\mdkir\Documents\University\Subjects\Web\Курсова\CourseWork\Views\Account\Register.cshtml"
   Write(Html.TextBoxFor(x=>x.RepeatPassword));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 19 "C:\Users\mdkir\Documents\University\Subjects\Web\Курсова\CourseWork\Views\Account\Register.cshtml"
   Write(Html.ValidationMessageFor(x=>x.RepeatPassword));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n        <input type=\"submit\" value=\"Регистрация\"/>\r\n    </div>\r\n");
#nullable restore
#line 24 "C:\Users\mdkir\Documents\University\Subjects\Web\Курсова\CourseWork\Views\Account\Register.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegisterViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
