#pragma checksum "D:\Downloads\ShamsipourFinantialStudents-Master\ShamsipourFinantialStudents-Master\ShamsipourOnlineSystem\Views\Laboratory\LaboratoryStudentsHistory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e639a9d4a7f52e3e06f9c07a5ce82e3129d16871"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Laboratory_LaboratoryStudentsHistory), @"mvc.1.0.view", @"/Views/Laboratory/LaboratoryStudentsHistory.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Downloads\ShamsipourFinantialStudents-Master\ShamsipourFinantialStudents-Master\ShamsipourOnlineSystem\Views\_ViewImports.cshtml"
using ShamsipourOnlineSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Downloads\ShamsipourFinantialStudents-Master\ShamsipourFinantialStudents-Master\ShamsipourOnlineSystem\Views\_ViewImports.cshtml"
using ShamsipourOnlineSystem.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Downloads\ShamsipourFinantialStudents-Master\ShamsipourFinantialStudents-Master\ShamsipourOnlineSystem\Views\_ViewImports.cshtml"
using ShamsipourOnlineSystem.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Downloads\ShamsipourFinantialStudents-Master\ShamsipourFinantialStudents-Master\ShamsipourOnlineSystem\Views\Laboratory\LaboratoryStudentsHistory.cshtml"
using PersianTranlation.DateConvertor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Downloads\ShamsipourFinantialStudents-Master\ShamsipourFinantialStudents-Master\ShamsipourOnlineSystem\Views\Laboratory\LaboratoryStudentsHistory.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e639a9d4a7f52e3e06f9c07a5ce82e3129d16871", @"/Views/Laboratory/LaboratoryStudentsHistory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c10d7860fea7dc99635bb1cee8da4a31e4bac525", @"/Views/_ViewImports.cshtml")]
    public class Views_Laboratory_LaboratoryStudentsHistory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LaboratoryViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-magenta mb-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Sweetalert2/sweetalert2.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Sweetalert2/sweetalert2.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/site-min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"container\">\n    <div class=\"text-center\">\n        <h1 class=\"mt-5 mb-5 text-title\">سامانه ثبت درخواست فارغ التحصیلی دانشجویان </h1>\n        <h2 class=\"mt-5 mb-5 text-title-experts\">پنل مسئول آزمایشگاه </h2>\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e639a9d4a7f52e3e06f9c07a5ce82e3129d168716644", async() => {
                WriteLiteral("نمایش صف انتظار");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        <div class=""page-active"">
            <div class=""col-md-12 col-lg-12 col-xl-12 col-sm-12 col-12 box-shadow pt-5 box-container mt-5 pb-3"">
                <table class=""table table-bordered table-responsive-sm table-hover"">
                    <thead class=""thead-light"">
                        <tr class=""text-center"">
                            <th>شماره دانشجویی</th>
                            <th>شماره درخواست</th>
                            <th>وضعیت</th>
                            <th>تاریخ چک شدن درخواست</th>
                        </tr>
                    </thead>
                    <tbody>

");
#nullable restore
#line 23 "D:\Downloads\ShamsipourFinantialStudents-Master\ShamsipourFinantialStudents-Master\ShamsipourOnlineSystem\Views\Laboratory\LaboratoryStudentsHistory.cshtml"
                         if (Model != null)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\Downloads\ShamsipourFinantialStudents-Master\ShamsipourFinantialStudents-Master\ShamsipourOnlineSystem\Views\Laboratory\LaboratoryStudentsHistory.cshtml"
                             foreach (var item in Model.LaboratoryStudents)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\n                                    <td>");
#nullable restore
#line 28 "D:\Downloads\ShamsipourFinantialStudents-Master\ShamsipourFinantialStudents-Master\ShamsipourOnlineSystem\Views\Laboratory\LaboratoryStudentsHistory.cshtml"
                                   Write(item.StudentId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 29 "D:\Downloads\ShamsipourFinantialStudents-Master\ShamsipourFinantialStudents-Master\ShamsipourOnlineSystem\Views\Laboratory\LaboratoryStudentsHistory.cshtml"
                                   Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 30 "D:\Downloads\ShamsipourFinantialStudents-Master\ShamsipourFinantialStudents-Master\ShamsipourOnlineSystem\Views\Laboratory\LaboratoryStudentsHistory.cshtml"
                                    Write(item.StageStatus==true?"تایید شده":"رد شده به عنوان نقصی");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 31 "D:\Downloads\ShamsipourFinantialStudents-Master\ShamsipourFinantialStudents-Master\ShamsipourOnlineSystem\Views\Laboratory\LaboratoryStudentsHistory.cshtml"
                                   Write(await Component.InvokeAsync("StudentStatusComponent", item.StudentId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                </tr>\n");
#nullable restore
#line 33 "D:\Downloads\ShamsipourFinantialStudents-Master\ShamsipourFinantialStudents-Master\ShamsipourOnlineSystem\Views\Laboratory\LaboratoryStudentsHistory.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "D:\Downloads\ShamsipourFinantialStudents-Master\ShamsipourFinantialStudents-Master\ShamsipourOnlineSystem\Views\Laboratory\LaboratoryStudentsHistory.cshtml"
                             
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"alert alert-danger\">دانشجویی وجود ندارد</div>\n");
#nullable restore
#line 38 "D:\Downloads\ShamsipourFinantialStudents-Master\ShamsipourFinantialStudents-Master\ShamsipourOnlineSystem\Views\Laboratory\LaboratoryStudentsHistory.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </tbody>\n                </table>\n            </div>\n        </div>\n\n    </div>\n</div>\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e639a9d4a7f52e3e06f9c07a5ce82e3129d1687112142", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e639a9d4a7f52e3e06f9c07a5ce82e3129d1687113319", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e639a9d4a7f52e3e06f9c07a5ce82e3129d1687114419", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n\n");
            }
            );
            WriteLiteral("\n");
            DefineSection("Modals", async() => {
                WriteLiteral(@"
    <div class=""modal fade"" id=""ShowReverseDescribtion"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
        <div class=""modal-dialog modal-dialog-centered"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLongTitle"">توضیحات نقصی مدارک برای دانشجو</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    <div class=""col-xl-12 col-lg-12 col-md-12 mb-1"">
                        <fieldset class=""form-group"">
                            <input type=""hidden"" id=""StudentID"" />
                            <label for=""basicInput""></label>
                            <textarea style=""height: 130px"" class=""col-12"" id=""ReverseDescribtion"" placehold");
                WriteLiteral(@"er=""توضیحات نقصی مدارک دانشجو برای نمایش در پنل شخص را وارد کنید""></textarea>
                        </fieldset>
                    </div>
                </div>
                <div class=""modal-footer"">
                    <a href=""#"" class=""btn btn--danger text-white"" data-dismiss=""modal"">بستن</a>
                    <a onclick=""SetStAsReversed()"" class=""btn btn-darkaqua text-white"" data-dismiss=""modal"">ارسال</a>
                </div>
            </div>
        </div>
    </div>


");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LaboratoryViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
