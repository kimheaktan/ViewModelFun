#pragma checksum "/Users/user/coding dojo/csharpNew/asp2_Mvc/viewModelFun/Views/User/Users.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a5723ed5f1478ce8f77cf59457fe8cd1d86ccf4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Users), @"mvc.1.0.view", @"/Views/User/Users.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/Users.cshtml", typeof(AspNetCore.Views_User_Users))]
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
#line 1 "/Users/user/coding dojo/csharpNew/asp2_Mvc/viewModelFun/Views/_ViewImports.cshtml"
using viewModelFun;

#line default
#line hidden
#line 1 "/Users/user/coding dojo/csharpNew/asp2_Mvc/viewModelFun/Views/User/Users.cshtml"
using viewModelFun.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a5723ed5f1478ce8f77cf59457fe8cd1d86ccf4", @"/Views/User/Users.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95ce21e87e6e3b5d780dfa533ad9c7b04016b7cc", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Users : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<User>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 215, true);
            WriteLiteral("\n    <div class=\"NavHeader\">\n\n        <a href=\"/\">Message</a> \n        <a href=\"/numbers\">Numbers</a> \n        <a href=\"/user\">User</a> \n        <a href=\"/users\">Users</a> \n\n    </div>\n<h3>Here are some Users!</h3>\n");
            EndContext();
#line 13 "/Users/user/coding dojo/csharpNew/asp2_Mvc/viewModelFun/Views/User/Users.cshtml"
 foreach (var name in Model)
{

#line default
#line hidden
            BeginContext(291, 7, true);
            WriteLiteral("    <P>");
            EndContext();
            BeginContext(299, 14, false);
#line 15 "/Users/user/coding dojo/csharpNew/asp2_Mvc/viewModelFun/Views/User/Users.cshtml"
  Write(name.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(313, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(315, 13, false);
#line 15 "/Users/user/coding dojo/csharpNew/asp2_Mvc/viewModelFun/Views/User/Users.cshtml"
                  Write(name.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(328, 17, true);
            WriteLiteral("</P>\n    <P></P>\n");
            EndContext();
#line 17 "/Users/user/coding dojo/csharpNew/asp2_Mvc/viewModelFun/Views/User/Users.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<User>> Html { get; private set; }
    }
}
#pragma warning restore 1591