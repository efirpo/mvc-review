#pragma checksum "/Users/suzannedeakins/Desktop/Epicodus/PierresVendors.Solution/PierresVendors/Views/Vendors/Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc73600c6b4ada24af12b455bc5a45c8149b0e0f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vendors_Show), @"mvc.1.0.view", @"/Views/Vendors/Show.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Vendors/Show.cshtml", typeof(AspNetCore.Views_Vendors_Show))]
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
#line 1 "/Users/suzannedeakins/Desktop/Epicodus/PierresVendors.Solution/PierresVendors/Views/Vendors/Show.cshtml"
using PierresVendors.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc73600c6b4ada24af12b455bc5a45c8149b0e0f", @"/Views/Vendors/Show.cshtml")]
    public class Views_Vendors_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/Users/suzannedeakins/Desktop/Epicodus/PierresVendors.Solution/PierresVendors/Views/Vendors/Show.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(57, 5, true);
            WriteLiteral("\n<h2>");
            EndContext();
            BeginContext(63, 20, false);
#line 6 "/Users/suzannedeakins/Desktop/Epicodus/PierresVendors.Solution/PierresVendors/Views/Vendors/Show.cshtml"
Write(Model["vendor"].Name);

#line default
#line hidden
            EndContext();
            BeginContext(83, 23, true);
            WriteLiteral("</h2>\n<h3>Orders:</h3>\n");
            EndContext();
#line 8 "/Users/suzannedeakins/Desktop/Epicodus/PierresVendors.Solution/PierresVendors/Views/Vendors/Show.cshtml"
 if (@Model["orders"].Count == 0)
{

#line default
#line hidden
            BeginContext(142, 52, true);
            WriteLiteral("  <p>There are no orders to show.</p>\n  <p>Please <a");
            EndContext();
            BeginWriteAttribute("href", " href= \'", 194, "\'", 241, 3);
            WriteAttributeValue("", 202, "/vendors/", 202, 9, true);
#line 11 "/Users/suzannedeakins/Desktop/Epicodus/PierresVendors.Solution/PierresVendors/Views/Vendors/Show.cshtml"
WriteAttributeValue("", 211, Model["vendor"].Id, 211, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 230, "/orders/new", 230, 11, true);
            EndWriteAttribute();
            BeginContext(242, 26, true);
            WriteLiteral(">add some orders.</a></p>\n");
            EndContext();
#line 12 "/Users/suzannedeakins/Desktop/Epicodus/PierresVendors.Solution/PierresVendors/Views/Vendors/Show.cshtml"
}
else
{  
  

#line default
#line hidden
#line 15 "/Users/suzannedeakins/Desktop/Epicodus/PierresVendors.Solution/PierresVendors/Views/Vendors/Show.cshtml"
   foreach (Order order in @Model["orders"])
  {

#line default
#line hidden
            BeginContext(328, 8, true);
            WriteLiteral("    <h4>");
            EndContext();
            BeginContext(337, 11, false);
#line 17 "/Users/suzannedeakins/Desktop/Epicodus/PierresVendors.Solution/PierresVendors/Views/Vendors/Show.cshtml"
   Write(order.Title);

#line default
#line hidden
            EndContext();
            BeginContext(348, 35, true);
            WriteLiteral("</h4>\n    <ul>\n    <li>Order Date: ");
            EndContext();
            BeginContext(384, 10, false);
#line 19 "/Users/suzannedeakins/Desktop/Epicodus/PierresVendors.Solution/PierresVendors/Views/Vendors/Show.cshtml"
               Write(order.Date);

#line default
#line hidden
            EndContext();
            BeginContext(394, 33, true);
            WriteLiteral("</li>\n    <li>Order Description: ");
            EndContext();
            BeginContext(428, 17, false);
#line 20 "/Users/suzannedeakins/Desktop/Epicodus/PierresVendors.Solution/PierresVendors/Views/Vendors/Show.cshtml"
                      Write(order.Description);

#line default
#line hidden
            EndContext();
            BeginContext(445, 27, true);
            WriteLiteral("</li>\n    <li>Order Price: ");
            EndContext();
            BeginContext(473, 11, false);
#line 21 "/Users/suzannedeakins/Desktop/Epicodus/PierresVendors.Solution/PierresVendors/Views/Vendors/Show.cshtml"
                Write(order.Price);

#line default
#line hidden
            EndContext();
            BeginContext(484, 24, true);
            WriteLiteral("</li>\n    </ul><br><br>\n");
            EndContext();
#line 23 "/Users/suzannedeakins/Desktop/Epicodus/PierresVendors.Solution/PierresVendors/Views/Vendors/Show.cshtml"
  }

#line default
#line hidden
#line 23 "/Users/suzannedeakins/Desktop/Epicodus/PierresVendors.Solution/PierresVendors/Views/Vendors/Show.cshtml"
   
}

#line default
#line hidden
            BeginContext(514, 2, true);
            WriteLiteral("<a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 516, "\'", 562, 3);
            WriteAttributeValue("", 523, "/vendors/", 523, 9, true);
#line 25 "/Users/suzannedeakins/Desktop/Epicodus/PierresVendors.Solution/PierresVendors/Views/Vendors/Show.cshtml"
WriteAttributeValue("", 532, Model["vendor"].Id, 532, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 551, "/orders/new", 551, 11, true);
            EndWriteAttribute();
            BeginContext(563, 21, true);
            WriteLiteral(">Add some Orders.</a>");
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
