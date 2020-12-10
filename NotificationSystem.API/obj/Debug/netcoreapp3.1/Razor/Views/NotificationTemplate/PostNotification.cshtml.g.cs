#pragma checksum "C:\Projects\NotificationSystem\NotificationSystem.API\Views\NotificationTemplate\PostNotification.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "195ebb7f853b19be10a698eb091f20c723af0138"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NotificationTemplate_PostNotification), @"mvc.1.0.view", @"/Views/NotificationTemplate/PostNotification.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"195ebb7f853b19be10a698eb091f20c723af0138", @"/Views/NotificationTemplate/PostNotification.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6d2c5d58a9a68c29a2f34db95093ca115a0d483", @"/Views/_ViewImports.cshtml")]
    public class Views_NotificationTemplate_PostNotification : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Projects\NotificationSystem\NotificationSystem.API\Views\NotificationTemplate\PostNotification.cshtml"
  
    ViewData["Title"] = " Notification Template";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.1/css/all.min.css"" />
<style>
    label {
        padding-bottom: 20px;
    }

    i {
        position: absolute;
        visibility: hidden;
    }

    .success input {
        border-color: #2ecc71;
    }

    .error textarea {
        border-color: #e74e3c;
    }

    .success textarea {
        border-color: #2ecc71;
    }

    .error input {
        border-color: #e74e3c;
    }

    small {
        margin-left: 20px;
        visibility: hidden;
    }

    .success i.fa-check-circle {
        color: #2ecc71;
        visibility: visible;
        margin-top: 6px
    }

    .error i.fa-exclamation-circle {
        color: #e74e3c;
        visibility: visible;
        margin-top: 6px
    }

    .error small {
        color: #e74e3c;
        visibility: visible;
    }

    .success small {
        color: #2ecc71;
        visibility: visible;
    }
</style>

<div class=""");
            WriteLiteral(@"col-12 col-xl-12"">
    <h2 class=""card-title mb-3""><span style=""font-size: 20px;""><strong>Add Notification Template</strong></span></h2>
    <div class=""card"">
        <div class=""card-header"">
        </div>
        <div class=""card-body"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "195ebb7f853b19be10a698eb091f20c723af01385458", async() => {
                WriteLiteral(@"
                <div class=""mb-3 row"">
                    <label class=""col-form-label col-sm-2 text-sm-right"">Name</label>
                    <div class=""col-sm-10"">
                        <input type=""text"" class=""form-control"" placeholder=""Full Name"" id=""name"">
                        <i class=""fas fa-check-circle""></i>
                        <i class=""fas fa-exclamation-circle""></i>
                        <small>Error Message</small>
                    </div>
                </div>
                <div class=""mb-3 row"">
                    <label class=""col-form-label col-sm-2 text-sm-right"">Description</label>
                    <div class=""col-sm-10"">
                        <textarea class=""form-control"" placeholder=""Description"" id=""description"" rows=""3""></textarea>
                        <i class=""fas fa-check-circle""></i>
                        <i class=""fas fa-exclamation-circle""></i>
                        <small>Error Message</small>
                    </div>
       ");
                WriteLiteral(@"         </div>
                <div class=""mb-3 row"">
                    <label class=""col-form-label col-sm-2 text-sm-right"">Notification Type</label>
                    <div class=""col-sm-10"">
                        <select class=""form-control"" id=""notifType"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "195ebb7f853b19be10a698eb091f20c723af01387119", async() => {
                    WriteLiteral("Select Notification Type");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "195ebb7f853b19be10a698eb091f20c723af01388179", async() => {
                    WriteLiteral("Welcome Message");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "195ebb7f853b19be10a698eb091f20c723af01389230", async() => {
                    WriteLiteral("Application Submission");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "195ebb7f853b19be10a698eb091f20c723af013810288", async() => {
                    WriteLiteral("Application Approval");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        </select>
                        <i class=""fas fa-check-circle""></i>
                        <i class=""fas fa-exclamation-circle""></i>
                        <small>Error Message</small>
                    </div>
                </div>
                <div class=""mb-3 row"">
                    <label class=""col-form-label col-sm-2 text-sm-right"">Notification Channel</label>
                    <div class=""col-sm-10"">
                        <select class=""form-control"" id=""notifChannel"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "195ebb7f853b19be10a698eb091f20c723af013811888", async() => {
                    WriteLiteral("Select Notification Channel");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "195ebb7f853b19be10a698eb091f20c723af013812952", async() => {
                    WriteLiteral("Email Channel");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "195ebb7f853b19be10a698eb091f20c723af013814002", async() => {
                    WriteLiteral("SMS Channel");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        </select>
                        <i class=""fas fa-check-circle""></i>
                        <i class=""fas fa-exclamation-circle""></i>
                        <small>Error Message</small>
                    </div>
                </div>
                <div class=""mb-3 row"">
                    <div class=""col-sm-10 ml-sm-auto"">
                        <button type=""submit"" class=""btn btn-primary"">Submit</button>
                    </div>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
    </div>
</div>

<script type=""text/javascript"">
    const form = document.getElementById('form');
    const name = document.getElementById('name');
    const notifType = document.getElementById('notifType');
    const notifChannel = document.getElementById('notifChannel');
    const description = document.getElementById('description');

    form.addEventListener('submit', (e) => {
        e.preventDefault();

        checkInputs();
    });

    function checkInputs() {
        //get the values from the inputs
        const nameValue = name.value.trim();
        const notifTypeValue = notifType.value.trim();
        const notifChannelValue = notifChannel.value.trim();
        const descriptionValue = description.value.trim();

        if (nameValue == """") {
            //show error and add erro class
            setErrorFor(name, ""Input Field Cannot Be Blank"");
        } else {
            //show the success class
            setSuccessFor(name, ""Input Is Valid""");
            WriteLiteral(@");
        }

        if (descriptionValue == """") {
            //show error and add erro class
            setErrorFor(description, ""Input Field Cannot Be Blank"");
        } else {
            //show the success class
            setSuccessFor(description, ""Input Is Valid"");
        }

        if (notifTypeValue == ""Select Notification Type"") {
            //show error and add erro class
            setErrorFor(notifType, ""Input Field Cannot Be Blank"");
        } else {
            //show the success class
            setSuccessFor(notifType, ""Input Is Valid"");
        }

        if (notifChannelValue == ""Select Notification Channel"") {
            //show error and add erro class
            setErrorFor(notifChannel, ""Input Field Cannot Be Blank"");
        } else {
            //show the success class
            setSuccessFor(notifChannel, ""Input Is Valid"");
        }
    }

    function setErrorFor(input , message) {
        const formControl = input.parentElement;
        con");
            WriteLiteral(@"st grandParent = formControl.parentElement;
        const small = formControl.querySelector('small');

        //add error message inside small tag
        small.innerText = message;

        //add error class
        grandParent.className = ""mb-3 row error"";
    }

    function setSuccessFor(input, message) {
        const formControl = input.parentElement;
        const grandParent = formControl.parentElement;
        const small = formControl.querySelector('small');

        //add success message inside small tag
        small.innerText = message;

        //add error class
        grandParent.className = ""mb-3 row success"";
    }

</script>");
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
