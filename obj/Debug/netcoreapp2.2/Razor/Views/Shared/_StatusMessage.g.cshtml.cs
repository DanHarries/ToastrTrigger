#pragma checksum "C:\Users\itharriesd\source\repos\ToastrTest\ToastrTest\Views\Shared\_StatusMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d9847f86f529584be133dada39b8f20b1bada1a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__StatusMessage), @"mvc.1.0.view", @"/Views/Shared/_StatusMessage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_StatusMessage.cshtml", typeof(AspNetCore.Views_Shared__StatusMessage))]
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
#line 1 "C:\Users\itharriesd\source\repos\ToastrTest\ToastrTest\Views\_ViewImports.cshtml"
using ToastrTest;

#line default
#line hidden
#line 2 "C:\Users\itharriesd\source\repos\ToastrTest\ToastrTest\Views\_ViewImports.cshtml"
using ToastrTest.Models;

#line default
#line hidden
#line 3 "C:\Users\itharriesd\source\repos\ToastrTest\ToastrTest\Views\_ViewImports.cshtml"
using ToastrTest.Helpers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d9847f86f529584be133dada39b8f20b1bada1a", @"/Views/Shared/_StatusMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69dd3d3ab420c88e0eafce17ea4281bf6bfc077c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__StatusMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\itharriesd\source\repos\ToastrTest\ToastrTest\Views\Shared\_StatusMessage.cshtml"
   var status = TempDataExtensions.Get<StatusMessageDisplay>(TempData, "StatusMessage"); 

#line default
#line hidden
            BeginContext(94, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\itharriesd\source\repos\ToastrTest\ToastrTest\Views\Shared\_StatusMessage.cshtml"
 if (status != null)
{


#line default
#line hidden
            BeginContext(123, 98, true);
            WriteLiteral("    <script type=\"text/javascript\">\r\n        $(function () {\r\n\r\n            let _statusMessage = \"");
            EndContext();
            BeginContext(222, 25, false);
#line 10 "C:\Users\itharriesd\source\repos\ToastrTest\ToastrTest\Views\Shared\_StatusMessage.cshtml"
                             Write(status.Message.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(247, 89, true);
            WriteLiteral("\";\r\n            toastr.success(\"It Works!\", \'Success\');\r\n\r\n        });\r\n\r\n    </script>\r\n");
            EndContext();
#line 16 "C:\Users\itharriesd\source\repos\ToastrTest\ToastrTest\Views\Shared\_StatusMessage.cshtml"

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591