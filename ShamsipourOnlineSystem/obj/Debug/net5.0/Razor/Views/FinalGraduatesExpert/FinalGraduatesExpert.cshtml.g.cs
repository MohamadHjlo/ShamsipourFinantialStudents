#pragma checksum "D:\Downloads\ShamsipourFinantialStudents-Master\ShamsipourFinantialStudents-Master\ShamsipourOnlineSystem\Views\FinalGraduatesExpert\FinalGraduatesExpert.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eee95018280901b2262171ef1257b6d0912abfcb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FinalGraduatesExpert_FinalGraduatesExpert), @"mvc.1.0.view", @"/Views/FinalGraduatesExpert/FinalGraduatesExpert.cshtml")]
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
#line 1 "D:\Downloads\ShamsipourFinantialStudents-Master\ShamsipourFinantialStudents-Master\ShamsipourOnlineSystem\Views\FinalGraduatesExpert\FinalGraduatesExpert.cshtml"
using PersianTranlation.DateConvertor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Downloads\ShamsipourFinantialStudents-Master\ShamsipourFinantialStudents-Master\ShamsipourOnlineSystem\Views\FinalGraduatesExpert\FinalGraduatesExpert.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eee95018280901b2262171ef1257b6d0912abfcb", @"/Views/FinalGraduatesExpert/FinalGraduatesExpert.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c10d7860fea7dc99635bb1cee8da4a31e4bac525", @"/Views/_ViewImports.cshtml")]
    public class Views_FinalGraduatesExpert_FinalGraduatesExpert : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FinalGraduatesExpertViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-magenta mb-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetHistoryOfStudents", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "GraduatesExpert", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Sweetalert2/sweetalert2.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Sweetalert2/sweetalert2.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/site-min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<div class=""container"">
    <div class=""text-center"">
        <h1 class=""mt-5 mb-5 text-title"">سامانه ثبت درخواست فارغ التحصیلی دانشجویان </h1>
        <h2 class=""mt-5 mb-5 text-title-experts"">پنل کارشناس فارغ التحصیلان </h2>
        <div class=""row justify-content-around"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eee95018280901b2262171ef1257b6d0912abfcb7376", async() => {
                WriteLiteral("نمایش تاریخچه اعمال انجام شده");
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
            WriteLiteral("\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eee95018280901b2262171ef1257b6d0912abfcb8647", async() => {
                WriteLiteral("برو به بخش فارغ التحصیلان ابتدایی");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </div>\n        <div class=\"page-active\">\n            <div class=\"col-md-12 col-lg-12 col-xl-12 col-sm-12 col-12 box-shadow pt-5 box-container mt-5 pb-3\">\n");
#nullable restore
#line 15 "D:\Downloads\ShamsipourFinantialStudents-Master\ShamsipourFinantialStudents-Master\ShamsipourOnlineSystem\Views\FinalGraduatesExpert\FinalGraduatesExpert.cshtml"
                 if (Model.FinalGraduatesExpertStudents.Count != 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <table class=""table table-bordered table-responsive-sm table-hover"">
                        <thead class=""thead-light"">
                            <tr class=""text-center"">
                                <th>شماره دانشجویی</th>
                                <th>شماره درخواست</th>
                                <th>وضعیت</th>
                                <th>دستورات</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 27 "D:\Downloads\ShamsipourFinantialStudents-Master\ShamsipourFinantialStudents-Master\ShamsipourOnlineSystem\Views\FinalGraduatesExpert\FinalGraduatesExpert.cshtml"
                             foreach (var item in Model.FinalGraduatesExpertStudents)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\n                                    <td>");
#nullable restore
#line 30 "D:\Downloads\ShamsipourFinantialStudents-Master\ShamsipourFinantialStudents-Master\ShamsipourOnlineSystem\Views\FinalGraduatesExpert\FinalGraduatesExpert.cshtml"
                                   Write(item.StudentId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 31 "D:\Downloads\ShamsipourFinantialStudents-Master\ShamsipourFinantialStudents-Master\ShamsipourOnlineSystem\Views\FinalGraduatesExpert\FinalGraduatesExpert.cshtml"
                                   Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 32 "D:\Downloads\ShamsipourFinantialStudents-Master\ShamsipourFinantialStudents-Master\ShamsipourOnlineSystem\Views\FinalGraduatesExpert\FinalGraduatesExpert.cshtml"
                                    Write(item.StageStatus==null?"در انتظار تایید":(item.StageStatus==false?"رد شده به عنوان نقصی":"تایید شده"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>\n                                        <button");
            BeginWriteAttribute("onclick", " onclick=\"", 1871, "\"", 1929, 3);
            WriteAttributeValue("", 1881, "GetStudentDescrbtion(\'", 1881, 22, true);
#nullable restore
#line 34 "D:\Downloads\ShamsipourFinantialStudents-Master\ShamsipourFinantialStudents-Master\ShamsipourOnlineSystem\Views\FinalGraduatesExpert\FinalGraduatesExpert.cshtml"
WriteAttributeValue("", 1903, item.StudentDescribtion, 1903, 24, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1927, "\')", 1927, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info\">مشاهده توضیحات دانشجو</button>\n                                        <button");
            BeginWriteAttribute("onclick", " onclick=\"", 2030, "\"", 2138, 6);
            WriteAttributeValue("", 2040, "AcceptStudent(\'", 2040, 15, true);
#nullable restore
#line 35 "D:\Downloads\ShamsipourFinantialStudents-Master\ShamsipourFinantialStudents-Master\ShamsipourOnlineSystem\Views\FinalGraduatesExpert\FinalGraduatesExpert.cshtml"
WriteAttributeValue("", 2055, item.StudentId, 2055, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2070, "\',", 2070, 2, true);
            WriteAttributeValue(" ", 2072, "\'", 2073, 2, true);
#nullable restore
#line 35 "D:\Downloads\ShamsipourFinantialStudents-Master\ShamsipourFinantialStudents-Master\ShamsipourOnlineSystem\Views\FinalGraduatesExpert\FinalGraduatesExpert.cshtml"
WriteAttributeValue("", 2074, item.StudentDescribtion, 2074, 24, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2098, "\',\'FinalGraduatesExpert/SetAsSuccessed\')", 2098, 40, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-darkaqua\">تایید مدارک</button>\n                                        <button");
            BeginWriteAttribute("onclick", " onclick=\"", 2233, "\"", 2276, 3);
            WriteAttributeValue("", 2243, "ReverseStudent(\'", 2243, 16, true);
#nullable restore
#line 36 "D:\Downloads\ShamsipourFinantialStudents-Master\ShamsipourFinantialStudents-Master\ShamsipourOnlineSystem\Views\FinalGraduatesExpert\FinalGraduatesExpert.cshtml"
WriteAttributeValue("", 2259, item.StudentId, 2259, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2274, "\')", 2274, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn--danger\">نقص مدارک</button>\n                                    </td>\n                                </tr>\n");
#nullable restore
#line 39 "D:\Downloads\ShamsipourFinantialStudents-Master\ShamsipourFinantialStudents-Master\ShamsipourOnlineSystem\Views\FinalGraduatesExpert\FinalGraduatesExpert.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\n                    </table>\n");
#nullable restore
#line 42 "D:\Downloads\ShamsipourFinantialStudents-Master\ShamsipourFinantialStudents-Master\ShamsipourOnlineSystem\Views\FinalGraduatesExpert\FinalGraduatesExpert.cshtml"

                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"alert alert-danger\">درخواست فعالی وجود ندارد</div>\n");
#nullable restore
#line 47 "D:\Downloads\ShamsipourFinantialStudents-Master\ShamsipourFinantialStudents-Master\ShamsipourOnlineSystem\Views\FinalGraduatesExpert\FinalGraduatesExpert.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\n        </div>\n    </div>\n</div>\n\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "eee95018280901b2262171ef1257b6d0912abfcb16750", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eee95018280901b2262171ef1257b6d0912abfcb17927", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eee95018280901b2262171ef1257b6d0912abfcb19025", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
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
    <div class=""modal fade"" id=""ShowDescribtion"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
        <div class=""modal-dialog modal-dialog-centered"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLongTitle"">توضیحات دانشجو</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    <div class=""col-xl-12 col-lg-12 col-md-12 mb-1"">
                        <fieldset class=""form-group"">
                            <input type=""hidden"" id=""Edit_ProductId"" />
                            <label for=""basicInput""></label>
                            <textarea style=""height: 130px"" class=""col-12"" id=""StudentDescribtion"" placeholder=""توضیحی ثبت نشد");
                WriteLiteral(@"ه""></textarea>
                        </fieldset>
                    </div>
                </div>
                <div class=""modal-footer"">
                    <a href=""#"" class=""btn btn--danger text-white"" data-dismiss=""modal"">بستن</a>
                </div>
            </div>
        </div>
    </div>

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
                    <div class=""col-xl-12 col-lg-1");
                WriteLiteral(@"2 col-md-12 mb-1"">
                        <fieldset class=""form-group"">
                            <input type=""hidden"" id=""StudentID"" />
                            <label for=""basicInput""></label>
                            <textarea style=""height: 130px"" class=""col-12"" id=""ReverseToStudent"" placeholder=""توضیحات نقصی مدارک دانشجو برای نمایش در پنل شخص را وارد کنید""></textarea>
                        </fieldset>
                    </div>
                </div>
                <div class=""modal-footer"">
                    <a href=""#"" class=""btn btn--danger text-white"" data-dismiss=""modal"">بستن</a>
                    <a onclick=""SetStAsReversed('FinalGraduatesExpert/SetAsReversed')"" class=""btn btn-darkaqua text-white"" data-dismiss=""modal"">ارسال</a>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FinalGraduatesExpertViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
