#pragma checksum "/Users/macbook/Desktop/Attachment/Cart_Exam/Cart_Exam/Views/Home/SuccessPaymentView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2316ba82209c81082165e73e39a44425dc9e6ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SuccessPaymentView), @"mvc.1.0.view", @"/Views/Home/SuccessPaymentView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/SuccessPaymentView.cshtml", typeof(AspNetCore.Views_Home_SuccessPaymentView))]
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
#line 1 "/Users/macbook/Desktop/Attachment/Cart_Exam/Cart_Exam/Views/_ViewImports.cshtml"
using Cart_Exam;

#line default
#line hidden
#line 2 "/Users/macbook/Desktop/Attachment/Cart_Exam/Cart_Exam/Views/_ViewImports.cshtml"
using Cart_Exam.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2316ba82209c81082165e73e39a44425dc9e6ea", @"/Views/Home/SuccessPaymentView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4bccc9f73299b8b78d80bea4f6d626c8c529c88", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_SuccessPaymentView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cart_Exam.Models.ViewModels.VerifyResultData>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 82, true);
            WriteLiteral("<div class=\"alert alert-success\">\r\n    <h2>عملیات با موفقیت انجام شد</h2>\r\n    <p>");
            EndContext();
            BeginContext(136, 13, false);
#line 4 "/Users/macbook/Desktop/Attachment/Cart_Exam/Cart_Exam/Views/Home/SuccessPaymentView.cshtml"
  Write(Model.ResCode);

#line default
#line hidden
            EndContext();
            BeginContext(149, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(153, 17, false);
#line 4 "/Users/macbook/Desktop/Attachment/Cart_Exam/Cart_Exam/Views/Home/SuccessPaymentView.cshtml"
                   Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(170, 27, true);
            WriteLiteral("</p>\r\n    <p>شماره پیگیری :");
            EndContext();
            BeginContext(198, 19, false);
#line 5 "/Users/macbook/Desktop/Attachment/Cart_Exam/Cart_Exam/Views/Home/SuccessPaymentView.cshtml"
                Write(Model.RetrivalRefNo);

#line default
#line hidden
            EndContext();
            BeginContext(217, 26, true);
            WriteLiteral(" </p>\r\n    <p>شماره مرجع :");
            EndContext();
            BeginContext(244, 19, false);
#line 6 "/Users/macbook/Desktop/Attachment/Cart_Exam/Cart_Exam/Views/Home/SuccessPaymentView.cshtml"
              Write(Model.SystemTraceNo);

#line default
#line hidden
            EndContext();
            BeginContext(263, 13, true);
            WriteLiteral(" </p>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cart_Exam.Models.ViewModels.VerifyResultData> Html { get; private set; }
    }
}
#pragma warning restore 1591
