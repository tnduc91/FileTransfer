#pragma checksum "/Users/duc/Downloads/just-an-email-master/src/JustSending/Views/App/_ConnectInstructions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd07fa958d269e284ec04a7fa69d3365e8d96529"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_App__ConnectInstructions), @"mvc.1.0.view", @"/Views/App/_ConnectInstructions.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd07fa958d269e284ec04a7fa69d3365e8d96529", @"/Views/App/_ConnectInstructions.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84ada672225e36d5f1cadb604f46b347c1103c96", @"/Views/_ViewImports.cshtml")]
    public class Views_App__ConnectInstructions : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h2>On another Device</h2>\n<ul>\n    <li>Go to <a");
            BeginWriteAttribute("href", " href=\"", 48, "\"", 102, 3);
#nullable restore
#line 3 "/Users/duc/Downloads/just-an-email-master/src/JustSending/Views/App/_ConnectInstructions.cshtml"
WriteAttributeValue("", 55, Context.Request.Scheme, 55, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 78, "://", 78, 3, true);
#nullable restore
#line 3 "/Users/duc/Downloads/just-an-email-master/src/JustSending/Views/App/_ConnectInstructions.cshtml"
WriteAttributeValue("", 81, Context.Request.Host, 81, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">");
#nullable restore
#line 3 "/Users/duc/Downloads/just-an-email-master/src/JustSending/Views/App/_ConnectInstructions.cshtml"
                                                                                   Write(Context.Request.Scheme);

#line default
#line hidden
#nullable disable
            WriteLiteral("://");
#nullable restore
#line 3 "/Users/duc/Downloads/just-an-email-master/src/JustSending/Views/App/_ConnectInstructions.cshtml"
                                                                                                             Write(Context.Request.Host);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\n    <li>Click CONNECT</li>\n    <li>Use this single use PIN</li>\n</ul>\n");
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
