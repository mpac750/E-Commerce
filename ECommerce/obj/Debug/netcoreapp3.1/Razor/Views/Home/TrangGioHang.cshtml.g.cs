#pragma checksum "E:\ECommerce\ECommerce\Views\Home\TrangGioHang.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9014d4c2b9391b47bdc1166ddaee9a9e169297a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_TrangGioHang), @"mvc.1.0.view", @"/Views/Home/TrangGioHang.cshtml")]
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
#line 1 "E:\ECommerce\ECommerce\Views\_ViewImports.cshtml"
using ECommerce;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\ECommerce\ECommerce\Views\_ViewImports.cshtml"
using ECommerce.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9014d4c2b9391b47bdc1166ddaee9a9e169297a9", @"/Views/Home/TrangGioHang.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec470632cb3b1b75499bc0cdcc8d1831e35eecad", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_TrangGioHang : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/User/images/galaxy-note.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/User/images/Z1.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\ECommerce\ECommerce\Views\Home\TrangGioHang.cshtml"
  
    ViewData["Title"] = "TrangGioHang";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!--//////////////////////////////////////////////////-->
<!--///////////////////GioHang//////////////////////-->
<!--//////////////////////////////////////////////////-->
<div id=""page-content"" class=""single-page"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <ul class=""breadcrumb"">
                    <li><a href=""index.html"">Trang Chủ</a></li>
                    <li><a href=""cart.html"">Giỏ Hàng</a></li>
                </ul>
            </div>
        </div>
        <div class=""row"">
            <div class=""product well"">
                <div class=""col-md-3"">
                    <div class=""image"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9014d4c2b9391b47bdc1166ddaee9a9e169297a94749", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
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
                <div class=""col-md-9"">
                    <div class=""caption"">
                        <div class=""name""><h3><a href=""#"">Samsung Galaxy Note </a></h3></div>
                        <div class=""info"">
                            <ul>
                                <li>Thương hiệu: Samsung</li>
                                <li>ID: 0000001</li>
                            </ul>
                        </div>
                        <div class=""price"">5,000,000đ<span>6,000,000đ</span></div>
                        <label>Số Lượng: </label> <input class=""form-inline quantity"" type=""text"" value=""1"">
                        <hr>
                        <a href=""#"" class=""btn btn-default pull-right"">Xóa</a>
                    </div>
                </div>
                <div class=""clear""></div>
            </div>
        </div>
        <div class=""row"">
            <div class=""product well"">
                <div class=""");
            WriteLiteral("col-md-3\">\r\n                    <div class=\"image\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9014d4c2b9391b47bdc1166ddaee9a9e169297a96944", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
                <div class=""col-md-9"">
                    <div class=""caption"">
                        <div class=""name""><h3><a href=""product.html"">Sony Z</a></h3></div>
                        <div class=""info"">
                            <ul>
                                <li>Thương hiệu: Sony</li>
                                <li>ID: 0000002</li>
                            </ul>
                        </div>
                        <div class=""price"">8,000,000đ<span>10,000,000đ</span></div>
                        <label>Số Lượng: </label> <input class=""form-inline quantity"" type=""text"" value=""1"">
                        <hr>
                        <a href=""#"" class=""btn btn-default pull-right"">Xóa</a>
                    </div>
                </div>
                <div class=""clear""></div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-4 col-md-offset-8 "">
                <cen");
            WriteLiteral(@"ter><a href=""#"" class=""btn btn-1"">Tiếp Tục Mua Hàng</a></center>
            </div>
        </div>
        <div class=""row"">
            <div class=""pricedetails"">
                <div class=""col-md-4 col-md-offset-8"">
                    <table>
                        <h6>Chi Tiết Hóa Đơn</h6>
                        <tr>
                            <td>Samsung Note 10</td>
                            <td>5,000,000đ</td>
                        </tr>
                        <tr>
                            <td>Sony Z</td>
                            <td>8,000,000đ</td>
                        </tr>
                        <tr>
                            <td>Tổng Cộng</td>
                            <td>13,000,000đ</td>
                        </tr>
                        <tr>
                            <td>Tiền Vận Chuyển</td>
                            <td>0đ</td>
                        </tr>
                        <tr style=""border-top: 1px solid #333"">
                    ");
            WriteLiteral(@"        <td><h5>TOTAL</h5></td>
                            <td>13,000,000đ</td>
                        </tr>
                    </table>
                    <center><a href=""#"" class=""btn btn-1"">Thanh Toán</a></center>
                </div>
            </div>
        </div>
    </div>
</div>
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
