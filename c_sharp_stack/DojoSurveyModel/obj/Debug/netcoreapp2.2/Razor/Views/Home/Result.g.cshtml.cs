#pragma checksum "/Users/linhuang/Desktop/CodingDojo/c_sharp_stack/DojoSurveyModel/Views/Home/Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "554a95707db0ff7b02ae9f90252010bbb6b8e4d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Result), @"mvc.1.0.view", @"/Views/Home/Result.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Result.cshtml", typeof(AspNetCore.Views_Home_Result))]
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
#line 1 "/Users/linhuang/Desktop/CodingDojo/c_sharp_stack/DojoSurveyModel/Views/_ViewImports.cshtml"
using DojoSurveyModel;

#line default
#line hidden
#line 2 "/Users/linhuang/Desktop/CodingDojo/c_sharp_stack/DojoSurveyModel/Views/_ViewImports.cshtml"
using DojoSurveyModel.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"554a95707db0ff7b02ae9f90252010bbb6b8e4d4", @"/Views/Home/Result.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63b6fb3282cc3555b503421efa742585a5ca8031", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Survey>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(15, 94, true);
            WriteLiteral("\n\n\n\n <div class=\"wraper\">\n       <div name=\"info\">\n           <ul>\n                <li>Name : ");
            EndContext();
            BeginContext(110, 10, false);
#line 9 "/Users/linhuang/Desktop/CodingDojo/c_sharp_stack/DojoSurveyModel/Views/Home/Result.cshtml"
                      Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(120, 43, true);
            WriteLiteral("</li>\n                <li>Dojo Location :  ");
            EndContext();
            BeginContext(164, 14, false);
#line 10 "/Users/linhuang/Desktop/CodingDojo/c_sharp_stack/DojoSurveyModel/Views/Home/Result.cshtml"
                                Write(Model.Location);

#line default
#line hidden
            EndContext();
            BeginContext(178, 46, true);
            WriteLiteral("</li>\n                <li>Favorite Language : ");
            EndContext();
            BeginContext(225, 14, false);
#line 11 "/Users/linhuang/Desktop/CodingDojo/c_sharp_stack/DojoSurveyModel/Views/Home/Result.cshtml"
                                   Write(Model.Language);

#line default
#line hidden
            EndContext();
            BeginContext(239, 37, true);
            WriteLiteral("</li>\n                <li>Comment :  ");
            EndContext();
            BeginContext(277, 13, false);
#line 12 "/Users/linhuang/Desktop/CodingDojo/c_sharp_stack/DojoSurveyModel/Views/Home/Result.cshtml"
                          Write(Model.Comment);

#line default
#line hidden
            EndContext();
            BeginContext(290, 88, true);
            WriteLiteral("</li>\n           </ul> \n\n           <a href=\"/\" >Go back</a>\n\n       </div> \n\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Survey> Html { get; private set; }
    }
}
#pragma warning restore 1591
