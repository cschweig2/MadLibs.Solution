#pragma checksum "C:\Users\Chelsea\Desktop\MadLibs.Solution\MadLibs\Views\Home\Form.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f07ca9a900c629d9c7f9ab0e3555e8c45f4b526"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Form), @"mvc.1.0.view", @"/Views/Home/Form.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Form.cshtml", typeof(AspNetCore.Views_Home_Form))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f07ca9a900c629d9c7f9ab0e3555e8c45f4b526", @"/Views/Home/Form.cshtml")]
    public class Views_Home_Form : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 29, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n    ");
            EndContext();
            BeginContext(29, 204, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f07ca9a900c629d9c7f9ab0e3555e8c45f4b5262880", async() => {
                BeginContext(35, 191, true);
                WriteLiteral("\r\n        <meta charset=\'utf-8\'>\r\n        <title>Create A Mab Libs!</title>\r\n        <link rel=\"stylesheet\" href=\"https://maxcdn.bootstrapcdn.com/bootstrap/3.2.0/css/bootstrap.min.css\">\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(233, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(239, 1858, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f07ca9a900c629d9c7f9ab0e3555e8c45f4b5264268", async() => {
                BeginContext(245, 1845, true);
                WriteLiteral(@"
        <h1>Fill in the blanks to create your custom story</h1>
        <form action=""/story"" method=""post"">
            <label for=""nounOne"">First noun</label>
            <input id=""nounOne"" name=""nounOne"" type=""text"">
            <label for=""personOne"">First person</label>
            <input id=""personOne"" name=""personOne"" type=""text"">
            <label for=""verbOne"">First verb</label>
            <input id=""verbOne"" name=""verbOne"" type=""text"">
            <label for=""nounTwo"">Second noun</label>
            <input id=""nounTwo"" name=""nounTwo"" type=""text"">
            <label for=""holiday"">Holday</label>
            <input id=""holiday"" name=""holiday"" type=""text"">
            <label for=""colorOne"">First color</label>
            <input id=""colorOne"" name=""colorOne"" type=""text"">
            <label for=""adjectiveOne"">First adjective</label>
            <input id=""adjectiveOne"" name=""adjectiveOne"" type=""text"">
            <label for=""verbTwo"">Second verb</label>
            <input id=""verbTwo");
                WriteLiteral(@""" name=""verbTwo"" type=""text"">
            <label for=""vegetable"">Vegetable</label>
            <input id=""vegetable"" name=""vegetable"" type=""text"">
            <label for=""verbThree"">Third verb</label>
            <input id=""verbThree"" name=""verbThree"" type=""text"">
            <label for=""personTwo"">Second person</label>
            <input id=""personTwo"" name=""personTwo"" type=""text"">
            <label for=""verbFour"">Fourth verb</label>
            <input id=""verbFour"" name=""verbFour"" type=""text"">
            <label for=""verbFive"">Fifth verb</label>
            <input id=""verbFive"" name=""verbFive"" type=""text"">
            <label for=""colorThree"">Third color</label>
            <input id=""colorThree"" name=""colorThree"" type=""text"">
            <button type=""submit"">Go!</button>
        </form>
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2097, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
