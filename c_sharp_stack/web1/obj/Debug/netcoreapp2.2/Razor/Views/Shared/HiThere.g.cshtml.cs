#pragma checksum "/Users/linhuang/Desktop/CodingDojo/c_sharp_stack/web1/Views/Shared/HiThere.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf5ec4d3a0a5bc7eb956ecbfdc68de4e4133b442"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_HiThere), @"mvc.1.0.view", @"/Views/Shared/HiThere.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/HiThere.cshtml", typeof(AspNetCore.Views_Shared_HiThere))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf5ec4d3a0a5bc7eb956ecbfdc68de4e4133b442", @"/Views/Shared/HiThere.cshtml")]
    public class Views_Shared_HiThere : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginContext(0, 23, true);
            WriteLiteral("<!DOCTYPE html>\n<html>\n");
            EndContext();
            BeginContext(23, 169, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf5ec4d3a0a5bc7eb956ecbfdc68de4e4133b4422866", async() => {
                BeginContext(29, 156, true);
                WriteLiteral("\n  <meta charset=\"utf-8\">\n  <meta name=\"viewport\" content=\"width=device-width\">\n  <title>JS Bin</title>\n  <style>\n    .c{\n      color:red;\n    }\n  </style>\n");
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
            BeginContext(192, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(193, 372, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf5ec4d3a0a5bc7eb956ecbfdc68de4e4133b4424193", async() => {
                BeginContext(199, 76, true);
                WriteLiteral("\n  <h1>hi there from Shared</h1>\n  <h1>Here are some delicious foods !</h1>\n");
                EndContext();
#line 16 "/Users/linhuang/Desktop/CodingDojo/c_sharp_stack/web1/Views/Shared/HiThere.cshtml"
    
    var StringList = new List<string>(){
      "Apple Pie",
      "Burritos",
      "Clams Casino",
      "Donuts"
      };

      foreach(var word in StringList)
      {
        if(word[0] == 'C'){

#line default
#line hidden
                BeginContext(479, 24, true);
                WriteLiteral("          <p class= \"c\">");
                EndContext();
                BeginContext(504, 4, false);
#line 27 "/Users/linhuang/Desktop/CodingDojo/c_sharp_stack/web1/Views/Shared/HiThere.cshtml"
                   Write(word);

#line default
#line hidden
                EndContext();
                BeginContext(508, 5, true);
                WriteLiteral("</p>\n");
                EndContext();
#line 28 "/Users/linhuang/Desktop/CodingDojo/c_sharp_stack/web1/Views/Shared/HiThere.cshtml"
        }

#line default
#line hidden
                BeginContext(523, 11, true);
                WriteLiteral("        <p>");
                EndContext();
                BeginContext(535, 4, false);
#line 29 "/Users/linhuang/Desktop/CodingDojo/c_sharp_stack/web1/Views/Shared/HiThere.cshtml"
      Write(word);

#line default
#line hidden
                EndContext();
                BeginContext(539, 5, true);
                WriteLiteral("</p>\n");
                EndContext();
#line 30 "/Users/linhuang/Desktop/CodingDojo/c_sharp_stack/web1/Views/Shared/HiThere.cshtml"
      }
  

#line default
#line hidden
                BeginContext(556, 2, true);
                WriteLiteral("\n\n");
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
            BeginContext(565, 8, true);
            WriteLiteral("\n</html>");
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
