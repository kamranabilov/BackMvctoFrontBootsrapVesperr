#pragma checksum "E:\3.Asp.Net.Core\HomeTaskBootstrapVesperr\HomeTaskBootstrapVesperr\Views\Home\ServicesDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0dbff7b84c361c90e66e3846fc8c069b64aa0a42"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ServicesDetail), @"mvc.1.0.view", @"/Views/Home/ServicesDetail.cshtml")]
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
#line 2 "E:\3.Asp.Net.Core\HomeTaskBootstrapVesperr\HomeTaskBootstrapVesperr\Views\Home\ServicesDetail.cshtml"
using HomeTaskBootstrapVesperr.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0dbff7b84c361c90e66e3846fc8c069b64aa0a42", @"/Views/Home/ServicesDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccfb546ea7ac201b1c39e86f2583cfffc7b1ed4a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ServicesDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Services>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n\r\n    <div class=\"col-md-6 col-lg-3 d-flex align-items-stretch mb-5 mb-lg-0\">\r\n        <div class=\"icon-box\" data-aos=\"fade-up\" data-aos-delay=\"100\">\r\n            <div class=\"icon\"><i");
            BeginWriteAttribute("class", " class=\"", 248, "\"", 267, 1);
#nullable restore
#line 10 "E:\3.Asp.Net.Core\HomeTaskBootstrapVesperr\HomeTaskBootstrapVesperr\Views\Home\ServicesDetail.cshtml"
WriteAttributeValue("", 256, Model.Icon, 256, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></div>\r\n            <h4 class=\"title\"><a>");
#nullable restore
#line 11 "E:\3.Asp.Net.Core\HomeTaskBootstrapVesperr\HomeTaskBootstrapVesperr\Views\Home\ServicesDetail.cshtml"
                            Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n            <p class=\"description\">");
#nullable restore
#line 12 "E:\3.Asp.Net.Core\HomeTaskBootstrapVesperr\HomeTaskBootstrapVesperr\Views\Home\ServicesDetail.cshtml"
                              Write(Model.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Services> Html { get; private set; }
    }
}
#pragma warning restore 1591
