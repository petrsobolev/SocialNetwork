#pragma checksum "C:\Users\User\Source\Repos\Social Newtwork\Social_Network\Habr\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e3e39debc71b4900db3ed02d2d753897647f6ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/Index.cshtml", typeof(AspNetCore.Views_User_Index))]
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
#line 1 "C:\Users\User\Source\Repos\Social Newtwork\Social_Network\Habr\Views\_ViewImports.cshtml"
using Habr;

#line default
#line hidden
#line 2 "C:\Users\User\Source\Repos\Social Newtwork\Social_Network\Habr\Views\_ViewImports.cshtml"
using Habr.Models;

#line default
#line hidden
#line 6 "C:\Users\User\Source\Repos\Social Newtwork\Social_Network\Habr\Views\User\Index.cshtml"
using BLL.Domain.Models;

#line default
#line hidden
#line 7 "C:\Users\User\Source\Repos\Social Newtwork\Social_Network\Habr\Views\User\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 8 "C:\Users\User\Source\Repos\Social Newtwork\Social_Network\Habr\Views\User\Index.cshtml"
using Microsoft.Extensions.DependencyModel;

#line default
#line hidden
#line 9 "C:\Users\User\Source\Repos\Social Newtwork\Social_Network\Habr\Views\User\Index.cshtml"
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.ProjectModel;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e3e39debc71b4900db3ed02d2d753897647f6ea", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0c13deedea6541b60b026f03e7e7df3b14f4fbd", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IdentityUser>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\User\Source\Repos\Social Newtwork\Social_Network\Habr\Views\User\Index.cshtml"
  
    ViewData["Title"] = "Users";


#line default
#line hidden
            BeginContext(261, 253, true);
            WriteLiteral("    <link rel=\"stylesheet\" type=\"text/css\" href=\"//cdn.datatables.net/1.10.12/css/jquery.dataTables.min.css\">\r\n\r\n\r\n\r\n    <h2>Users</h2>\r\n\r\n    <table id=\"users\" class=\"display\" style=\"width:100%\">\r\n        <thead>\r\n            <tr>\r\n                <th>");
            EndContext();
            BeginContext(515, 30, false);
#line 20 "C:\Users\User\Source\Repos\Social Newtwork\Social_Network\Habr\Views\User\Index.cshtml"
               Write(Html.DisplayNameFor(s => s.Id));

#line default
#line hidden
            EndContext();
            BeginContext(545, 27, true);
            WriteLiteral("</th>\r\n                <th>");
            EndContext();
            BeginContext(573, 33, false);
#line 21 "C:\Users\User\Source\Repos\Social Newtwork\Social_Network\Habr\Views\User\Index.cshtml"
               Write(Html.DisplayNameFor(s => s.Email));

#line default
#line hidden
            EndContext();
            BeginContext(606, 27, true);
            WriteLiteral("</th>\r\n                <th>");
            EndContext();
            BeginContext(634, 42, false);
#line 22 "C:\Users\User\Source\Repos\Social Newtwork\Social_Network\Habr\Views\User\Index.cshtml"
               Write(Html.DisplayNameFor(s => s.EmailConfirmed));

#line default
#line hidden
            EndContext();
            BeginContext(676, 27, true);
            WriteLiteral("</th>\r\n                <th>");
            EndContext();
            BeginContext(704, 44, false);
#line 23 "C:\Users\User\Source\Repos\Social Newtwork\Social_Network\Habr\Views\User\Index.cshtml"
               Write(Html.DisplayNameFor(s => s.TwoFactorEnabled));

#line default
#line hidden
            EndContext();
            BeginContext(748, 27, true);
            WriteLiteral("</th>\r\n                <th>");
            EndContext();
            BeginContext(776, 36, false);
#line 24 "C:\Users\User\Source\Repos\Social Newtwork\Social_Network\Habr\Views\User\Index.cshtml"
               Write(Html.DisplayNameFor(s => s.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(812, 61, true);
            WriteLiteral("</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 28 "C:\Users\User\Source\Repos\Social Newtwork\Social_Network\Habr\Views\User\Index.cshtml"
             foreach (var user in Model)
            {

#line default
#line hidden
            BeginContext(930, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(977, 7, false);
#line 31 "C:\Users\User\Source\Repos\Social Newtwork\Social_Network\Habr\Views\User\Index.cshtml"
                   Write(user.Id);

#line default
#line hidden
            EndContext();
            BeginContext(984, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1016, 10, false);
#line 32 "C:\Users\User\Source\Repos\Social Newtwork\Social_Network\Habr\Views\User\Index.cshtml"
                   Write(user.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1026, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1058, 19, false);
#line 33 "C:\Users\User\Source\Repos\Social Newtwork\Social_Network\Habr\Views\User\Index.cshtml"
                   Write(user.EmailConfirmed);

#line default
#line hidden
            EndContext();
            BeginContext(1077, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1109, 21, false);
#line 34 "C:\Users\User\Source\Repos\Social Newtwork\Social_Network\Habr\Views\User\Index.cshtml"
                   Write(user.TwoFactorEnabled);

#line default
#line hidden
            EndContext();
            BeginContext(1130, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1162, 13, false);
#line 35 "C:\Users\User\Source\Repos\Social Newtwork\Social_Network\Habr\Views\User\Index.cshtml"
                   Write(user.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(1175, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 37 "C:\Users\User\Source\Repos\Social Newtwork\Social_Network\Habr\Views\User\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1220, 403, true);
            WriteLiteral(@"        </tbody>
    </table>

    <script src=""https://code.jquery.com/jquery-3.3.1.js""></script>
    <script src=""https://cdn.datatables.net/1.10.19/js/jquery.dataTables.min.js"" defer></script>
    <link href=""lib/bootstrap/dist/fonts/glyphicons-halflings-regular.svg"" />
    <script>
        $(document).ready(function () {
            $('#users').DataTable();
        });
    </script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<IdentityUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
