#pragma checksum "C:\Projects\NotificationSystem\NotificationSystem.API\Views\NotificationEmailAlert\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "547057140f9562ac4a420f5a1d6a9b02c8eaaa49"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NotificationEmailAlert_Index), @"mvc.1.0.view", @"/Views/NotificationEmailAlert/Index.cshtml")]
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
#line 1 "C:\Projects\NotificationSystem\NotificationSystem.API\Views\_ViewImports.cshtml"
using NotificationSystem.API;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\NotificationSystem\NotificationSystem.API\Views\_ViewImports.cshtml"
using NotificationSystem.API.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"547057140f9562ac4a420f5a1d6a9b02c8eaaa49", @"/Views/NotificationEmailAlert/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6d2c5d58a9a68c29a2f34db95093ca115a0d483", @"/Views/_ViewImports.cshtml")]
    public class Views_NotificationEmailAlert_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Projects\NotificationSystem\NotificationSystem.API\Views\NotificationEmailAlert\Index.cshtml"
  
    ViewData["Title"] = " Notification Email Alert";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<link href=""https://cdn.datatables.net/1.10.22/css/jquery.dataTables.min.css"" rel=""stylesheet"" />

<script type=""text/javascript"" src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>

<script type=""text/javascript"" src=""https://cdn.datatables.net/1.10.22/js/jquery.dataTables.min.js""></script>

<div class=""container-fluid p-0"">

    <div class=""row"">

        <div class=""col-12 col-xl-12"">
            <h2 class=""card-title""><span style=""font-size: 20px;""><strong>Email Notification</strong></span></h2>
            <div class=""card"">
                <div class=""card-header"">
                    
                </div>
                <table id=""tblNotificationEmail"" class=""table table-striped table-bordered"">
                    <thead>
                        <tr>
                            <th>Email</th>
                            <th>Subject</th>
                            <th>Message</th>
                            <th>Receiver Name</th>
             ");
            WriteLiteral(@"               <th>Actions</th>
                        </tr>
                    </thead>
                    <tbody>

                        <tr>
                            <td>Johnsonblack@yahoo.com</td>
                            <td>Internship Role</td>
                            <td>I wish to apply for the role of a software developer at your sweet reputable firm, please accept me!</td>
                            <td>James Rodriguez</td>
                            <td class=""table-action"">
                                <a href=""#""><i class=""align-middle"" style=""color:blue"" data-feather=""edit-2""></i></a>
                            </td>
                        </tr>
                        <tr>
                            <td>Emiliarice@yahoo.com</td>
                            <td>Internship Role</td>
                            <td>I wish to apply for the role of a software developer at your sweet reputable firm, please accept me!</td>
                            <td>Jason V");
            WriteLiteral(@"orhez</td>
                            <td class=""table-action"">
                                <a href=""#""><i class=""align-middle"" style=""color:blue"" data-feather=""edit-2""></i></a>
                            </td>
                        </tr>
                        <tr>
                            <td>clarkville@yahoo.com</td>
                            <td>Internship Role</td>
                            <td>I wish to apply for the role of a software developer at your sweet reputable firm, please accept me!</td>
                            <td>Jonny Bravo</td>
                            <td class=""table-action"">
                                <a href=""#""><i class=""align-middle"" style=""color:blue"" data-feather=""edit-2""></i></a>
                            </td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>

    </div>
</div>

<script type=""text/javascript"">
    $(document).ready(function () {
        $('#tb");
            WriteLiteral("lNotificationEmail\').DataTable();\r\n    });\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
