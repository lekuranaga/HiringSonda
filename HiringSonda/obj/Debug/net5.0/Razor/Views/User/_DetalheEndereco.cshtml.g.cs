#pragma checksum "D:\Projeto\HiringSonda\HiringSonda\Views\User\_DetalheEndereco.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6eb9d45eced28f8bf44865acfe2e6b62378a7395"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User__DetalheEndereco), @"mvc.1.0.view", @"/Views/User/_DetalheEndereco.cshtml")]
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
#line 1 "D:\Projeto\HiringSonda\HiringSonda\Views\_ViewImports.cshtml"
using HiringSonda;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projeto\HiringSonda\HiringSonda\Views\_ViewImports.cshtml"
using HiringSonda.Domain.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6eb9d45eced28f8bf44865acfe2e6b62378a7395", @"/Views/User/_DetalheEndereco.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a76e66f4d06baa41d6822491ca3049c0af7d4cb9", @"/Views/_ViewImports.cshtml")]
    public class Views_User__DetalheEndereco : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HiringSonda.Domain.Models.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 5 "D:\Projeto\HiringSonda\HiringSonda\Views\User\_DetalheEndereco.cshtml"
       Write(Html.DisplayNameFor(model => model.addressUser.CEP));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 8 "D:\Projeto\HiringSonda\HiringSonda\Views\User\_DetalheEndereco.cshtml"
       Write(Html.DisplayFor(model => model.addressUser.CEP));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 11 "D:\Projeto\HiringSonda\HiringSonda\Views\User\_DetalheEndereco.cshtml"
       Write(Html.DisplayNameFor(model => model.addressUser.Street));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 14 "D:\Projeto\HiringSonda\HiringSonda\Views\User\_DetalheEndereco.cshtml"
       Write(Html.DisplayFor(model => model.addressUser.Street));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 17 "D:\Projeto\HiringSonda\HiringSonda\Views\User\_DetalheEndereco.cshtml"
       Write(Html.DisplayNameFor(model => model.addressUser.Complement));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 20 "D:\Projeto\HiringSonda\HiringSonda\Views\User\_DetalheEndereco.cshtml"
       Write(Html.DisplayFor(model => model.addressUser.Complement));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 23 "D:\Projeto\HiringSonda\HiringSonda\Views\User\_DetalheEndereco.cshtml"
       Write(Html.DisplayNameFor(model => model.addressUser.Neighborhood));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 26 "D:\Projeto\HiringSonda\HiringSonda\Views\User\_DetalheEndereco.cshtml"
       Write(Html.DisplayFor(model => model.addressUser.Neighborhood));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n         <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 29 "D:\Projeto\HiringSonda\HiringSonda\Views\User\_DetalheEndereco.cshtml"
       Write(Html.DisplayNameFor(model => model.addressUser.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 32 "D:\Projeto\HiringSonda\HiringSonda\Views\User\_DetalheEndereco.cshtml"
       Write(Html.DisplayFor(model => model.addressUser.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n         <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 35 "D:\Projeto\HiringSonda\HiringSonda\Views\User\_DetalheEndereco.cshtml"
       Write(Html.DisplayNameFor(model => model.addressUser.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 38 "D:\Projeto\HiringSonda\HiringSonda\Views\User\_DetalheEndereco.cshtml"
       Write(Html.DisplayFor(model => model.addressUser.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n            </dl>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HiringSonda.Domain.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
