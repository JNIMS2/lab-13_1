#pragma checksum "C:\Dev\Lab16_1\Lab16_1\Views\Home\GetForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "264f13392ef019e523feba7697a4f8f2bcf4fbaa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetForm), @"mvc.1.0.view", @"/Views/Home/GetForm.cshtml")]
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
#line 1 "C:\Dev\Lab16_1\Lab16_1\Views\_ViewImports.cshtml"
using Lab16_1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Dev\Lab16_1\Lab16_1\Views\_ViewImports.cshtml"
using Lab16_1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"264f13392ef019e523feba7697a4f8f2bcf4fbaa", @"/Views/Home/GetForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"489bc34a4e245272c5ea0e524bb0298b36309cbc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GetForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-group"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("myform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/home/useform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Dev\Lab16_1\Lab16_1\Views\Home\GetForm.cshtml"
  
    ViewData["Title"] = "GetForm";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<style>\r\n    .warning {\r\n        font-family:Verdana;\r\n        font-size:medium;\r\n        font-weight: bold;\r\n        color: cornflowerblue;\r\n\r\n    }\r\n</style>\r\n<h1>Submit Info:</h1>\r\n\r\n");
            WriteLiteral("<div id=\"message\" class=\"warning\"></div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "264f13392ef019e523feba7697a4f8f2bcf4fbaa4959", async() => {
                WriteLiteral(@"
    <label>FirstName: </label> <input  class=""form-control"" type=""text"" id=""FirstName"" name=""FirstName"" /><span class=""warning"" id=""FirstNameWarning""></span><br />
    <label>LastName: </label><input  class=""form-control"" type=""text"" id=""LastName"" name=""LastName"" /><span class=""warning"" id=""LastNameWarning""></span><br />
    <label>Email: </label><input class=""form-control"" type=""email"" id=""Email"" name=""Email"" /><span class=""warning"" id=""EmailWarning""></span><br />
    <label>Password:</label>  <input  class=""form-control"" type=""password"" id=""Password"" name=""Password"" /><span class=""warning"" id=""PasswordWarning""></span><br />
    <label>Confirm Password: </label><input class=""form-control"" type=""password"" id=""ConfirmPassword"" name=""ConfirmPassword"" /><span class=""warning"" id=""ConfirmPasswordWarning""></span><br />
    <input type=""submit"" value=""Submit Info"" />
    
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"



<script>
    let myform = document.querySelector('#myform');

    function ValidatetheForm() {
        let firstname = document.querySelector('#FirstName').value;
        let lastname = document.querySelector('#LastName').value;
        let email = document.querySelector('#Email').value;
        let password = document.querySelector('#Password').value;
        let confirmpassword = document.querySelector('#ConfirmPassword').value;
        //should be regex for pw requirements--pretty sure
        let regexck = new RegExp(""^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[!");
            WriteLiteral(@"@#$%^&*])"");
        let result = true;

        if (firstname.length < 2) {
            document.querySelector('#FirstNameWarning').innerHTML = 'First Name must be 2 characters long';
            return false;
        }
        if (lastname.length < 2) {
            document.querySelector('#LastNameWarning').innerHTML = 'Last Name must be 2 characters long';
            return false;
        }
        if (email.indexOf('.') == -1 || email.indexOf('");
            WriteLiteral("@\') == -1) {\r\n            document.querySelector(\'#EmailWarning\').innerHTML = \'Email must contain both an ");
            WriteLiteral(@"@ and a .';
            return false;
        }
        if (!regexck.test(password)) {
            document.querySelector('#PasswordWarning').innerHTML = 'password requirements: 1 uppercase, 1 lowercase, 1 number, 1 symbol';
            return false;
        }
        if (password != confirmpassword) {
            document.querySelector('#ConfirmPasswordWarning').innerHTML = 'Passwords must match!';
            return false;
        }
      
       
        return result;

    }
    myform.addEventListener('submit', function (ev) {
        if (ValidatetheForm() == false) {
            console.log('Validation falied, skipping submit');
            ev.preventDefault();
        }
    });


</script>

");
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
