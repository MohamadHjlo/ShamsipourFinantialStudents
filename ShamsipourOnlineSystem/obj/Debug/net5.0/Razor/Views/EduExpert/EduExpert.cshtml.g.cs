#pragma checksum "D:\Downloads\ShamsipourFinantialStudents-Master\ShamsipourFinantialStudents-Master\ShamsipourOnlineSystem\Views\EduExpert\EduExpert.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a4efe84e89469b1829d2768823d31c9eaa95965"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EduExpert_EduExpert), @"mvc.1.0.view", @"/Views/EduExpert/EduExpert.cshtml")]
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
#line 1 "D:\Downloads\ShamsipourFinantialStudents-Master\ShamsipourFinantialStudents-Master\ShamsipourOnlineSystem\Views\EduExpert\EduExpert.cshtml"
using PersianTranlation.DateConvertor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Downloads\ShamsipourFinantialStudents-Master\ShamsipourFinantialStudents-Master\ShamsipourOnlineSystem\Views\EduExpert\EduExpert.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a4efe84e89469b1829d2768823d31c9eaa95965", @"/Views/EduExpert/EduExpert.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c10d7860fea7dc99635bb1cee8da4a31e4bac525", @"/Views/_ViewImports.cshtml")]
    public class Views_EduExpert_EduExpert : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EduExpertViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-magenta mb-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetHistoryOfStudents", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n<div class=\"container\">\n    <div class=\"text-center\">\n        <h1 class=\"mt-5 mb-5 text-title\">سامانه ثبت درخواست فارغ التحصیلی دانشجویان </h1>\n        <h2 class=\"mt-5 mb-5 text-title-experts\">پنل کارشناس آموزش </h2>\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a4efe84e89469b1829d2768823d31c9eaa959656537", async() => {
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
            WriteLiteral("\n        <div class=\"page-active\">\n            <div class=\"col-md-12 col-lg-12 col-xl-12 col-sm-12 col-12 box-shadow pt-5 box-container mt-5 pb-3\">\n");
#nullable restore
#line 12 "D:\Downloads\ShamsipourFinantialStudents-Master\ShamsipourFinantialStudents-Master\ShamsipourOnlineSystem\Views\EduExpert\EduExpert.cshtml"
                 if (Model.EduExpertStudents.Count != 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <table class=""table table-bordered table-responsive-sm table-hover"">
                        <thead class=""thead-light"">
                            <tr class=""text-center"">
                                <th tabindex=""0"" aria-controls=""DataTables_Table_0"" rowspan=""1"" colspan=""1"" style=""width: 9%;"">شماره دانشجویی</th>
                                <th tabindex=""0"" aria-controls=""DataTables_Table_0"" rowspan=""1"" colspan=""1"" style=""width: 2%;"">شماره درخواست</th>
                                <th tabindex=""0"" aria-controls=""DataTables_Table_0"" rowspan=""1"" colspan=""1"" style=""width: 9%;"">تاریخ درخواست</th>
                                <th tabindex=""0"" aria-controls=""DataTables_Table_0"" rowspan=""1"" colspan=""1"" style=""width: 10%;"">وضعیت</th>
                                <th tabindex=""2"" aria-controls=""DataTables_Table_0"" rowspan=""2"" colspan=""2"" style=""width: 60%;"">دستورات</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 25 "D:\Downloads\ShamsipourFinantialStudents-Master\ShamsipourFinantialStudents-Master\ShamsipourOnlineSystem\Views\EduExpert\EduExpert.cshtml"
                             foreach (var item in Model.EduExpertStudents)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\n                                    <td>");
#nullable restore
#line 28 "D:\Downloads\ShamsipourFinantialStudents-Master\ShamsipourFinantialStudents-Master\ShamsipourOnlineSystem\Views\EduExpert\EduExpert.cshtml"
                                   Write(item.StudentId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 29 "D:\Downloads\ShamsipourFinantialStudents-Master\ShamsipourFinantialStudents-Master\ShamsipourOnlineSystem\Views\EduExpert\EduExpert.cshtml"
                                   Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 30 "D:\Downloads\ShamsipourFinantialStudents-Master\ShamsipourFinantialStudents-Master\ShamsipourOnlineSystem\Views\EduExpert\EduExpert.cshtml"
                                    Write(item.Students.FirstOrDefault(s=>s.EduExpertId==item.Id).RequestTime==null?"ثبت نشده":item.Students.FirstOrDefault(s=>s.EduExpertId==item.Id).RequestTime.Value.ToShamsiCalender());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 31 "D:\Downloads\ShamsipourFinantialStudents-Master\ShamsipourFinantialStudents-Master\ShamsipourOnlineSystem\Views\EduExpert\EduExpert.cshtml"
                                    Write(item.StageStatus==null?"در انتظار تایید":(item.StageStatus==false?"رد شده به عنوان نقصی":"تایید شده"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>\n                                        <button");
            BeginWriteAttribute("onclick", " onclick=\"", 2365, "\"", 2423, 3);
            WriteAttributeValue("", 2375, "GetStudentDescrbtion(\'", 2375, 22, true);
#nullable restore
#line 33 "D:\Downloads\ShamsipourFinantialStudents-Master\ShamsipourFinantialStudents-Master\ShamsipourOnlineSystem\Views\EduExpert\EduExpert.cshtml"
WriteAttributeValue("", 2397, item.StudentDescribtion, 2397, 24, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2421, "\')", 2421, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info\">مشاهده توضیحات دانشجو</button>\n                                        <button");
            BeginWriteAttribute("onclick", " onclick=\"", 2524, "\"", 2622, 7);
            WriteAttributeValue("", 2534, "AcceptStudent(\'", 2534, 15, true);
#nullable restore
#line 34 "D:\Downloads\ShamsipourFinantialStudents-Master\ShamsipourFinantialStudents-Master\ShamsipourOnlineSystem\Views\EduExpert\EduExpert.cshtml"
WriteAttributeValue("", 2549, item.StudentId, 2549, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2564, "\',", 2564, 2, true);
            WriteAttributeValue(" ", 2566, "\'", 2567, 2, true);
#nullable restore
#line 34 "D:\Downloads\ShamsipourFinantialStudents-Master\ShamsipourFinantialStudents-Master\ShamsipourOnlineSystem\Views\EduExpert\EduExpert.cshtml"
WriteAttributeValue("", 2568, item.StudentDescribtion, 2568, 24, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2592, "\',", 2592, 2, true);
            WriteAttributeValue(" ", 2594, "\'EduExpert/SetAsSuccessed\')", 2595, 28, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-darkaqua\">تایید مدارک</button>\n                                        <button");
            BeginWriteAttribute("onclick", " onclick=\"", 2717, "\"", 2760, 3);
            WriteAttributeValue("", 2727, "ReverseStudent(\'", 2727, 16, true);
#nullable restore
#line 35 "D:\Downloads\ShamsipourFinantialStudents-Master\ShamsipourFinantialStudents-Master\ShamsipourOnlineSystem\Views\EduExpert\EduExpert.cshtml"
WriteAttributeValue("", 2743, item.StudentId, 2743, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2758, "\')", 2758, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn--danger\">نقص مدارک</button>\n                                    </td>\n                                </tr>\n");
#nullable restore
#line 38 "D:\Downloads\ShamsipourFinantialStudents-Master\ShamsipourFinantialStudents-Master\ShamsipourOnlineSystem\Views\EduExpert\EduExpert.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\n                    </table>\n");
#nullable restore
#line 41 "D:\Downloads\ShamsipourFinantialStudents-Master\ShamsipourFinantialStudents-Master\ShamsipourOnlineSystem\Views\EduExpert\EduExpert.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"alert alert-danger\">درخواست فعالی وجود ندارد</div>\n");
#nullable restore
#line 45 "D:\Downloads\ShamsipourFinantialStudents-Master\ShamsipourFinantialStudents-Master\ShamsipourOnlineSystem\Views\EduExpert\EduExpert.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                <button id=""btnShowReversedStudents"" class=""btn btn-warning mb-5 mt-3"">مشاهده دانشجویان برگشت خورده </button>
            </div>
        </div>


        <div class=""page-cloned"" style=""display: none"">
            <div class=""col-md-12 col-lg-12 col-xl-12 col-sm-12 col-12 box-shadow pt-5 box-container mt-5 pb-3"">
                <table class=""table table-bordered table-responsive-sm table-hover"">
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
#line 65 "D:\Downloads\ShamsipourFinantialStudents-Master\ShamsipourFinantialStudents-Master\ShamsipourOnlineSystem\Views\EduExpert\EduExpert.cshtml"
                         if (Model.ReversedStudentsFromGradExpert.Count != 0)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "D:\Downloads\ShamsipourFinantialStudents-Master\ShamsipourFinantialStudents-Master\ShamsipourOnlineSystem\Views\EduExpert\EduExpert.cshtml"
                             foreach (var item in Model.ReversedStudentsFromGradExpert)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\n                                    <td>");
#nullable restore
#line 70 "D:\Downloads\ShamsipourFinantialStudents-Master\ShamsipourFinantialStudents-Master\ShamsipourOnlineSystem\Views\EduExpert\EduExpert.cshtml"
                                   Write(item.StudentId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 71 "D:\Downloads\ShamsipourFinantialStudents-Master\ShamsipourFinantialStudents-Master\ShamsipourOnlineSystem\Views\EduExpert\EduExpert.cshtml"
                                   Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>در انتظار تایید</td>\n                                    <td>\n                                        <button");
            BeginWriteAttribute("onclick", " onclick=\"", 4451, "\"", 4509, 3);
            WriteAttributeValue("", 4461, "GetStudentDescrbtion(\'", 4461, 22, true);
#nullable restore
#line 74 "D:\Downloads\ShamsipourFinantialStudents-Master\ShamsipourFinantialStudents-Master\ShamsipourOnlineSystem\Views\EduExpert\EduExpert.cshtml"
WriteAttributeValue("", 4483, item.StudentDescribtion, 4483, 24, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4507, "\')", 4507, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info\">مشاهده توضیحات دانشجو</button>\n                                        <button");
            BeginWriteAttribute("onclick", " onclick=\"", 4610, "\"", 4707, 6);
            WriteAttributeValue("", 4620, "AcceptStudent(\'", 4620, 15, true);
#nullable restore
#line 75 "D:\Downloads\ShamsipourFinantialStudents-Master\ShamsipourFinantialStudents-Master\ShamsipourOnlineSystem\Views\EduExpert\EduExpert.cshtml"
WriteAttributeValue("", 4635, item.StudentId, 4635, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4650, "\',", 4650, 2, true);
            WriteAttributeValue(" ", 4652, "\'", 4653, 2, true);
#nullable restore
#line 75 "D:\Downloads\ShamsipourFinantialStudents-Master\ShamsipourFinantialStudents-Master\ShamsipourOnlineSystem\Views\EduExpert\EduExpert.cshtml"
WriteAttributeValue("", 4654, item.StudentDescribtion, 4654, 24, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4678, "\',\'EduExpert/SetAsSuccessed\')", 4678, 29, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-darkaqua\">تایید مدارک</button>\n                                        <button");
            BeginWriteAttribute("onclick", " onclick=\"", 4802, "\"", 4868, 3);
            WriteAttributeValue("", 4812, "GetGradExpertDescribtion(\'", 4812, 26, true);
#nullable restore
#line 76 "D:\Downloads\ShamsipourFinantialStudents-Master\ShamsipourFinantialStudents-Master\ShamsipourOnlineSystem\Views\EduExpert\EduExpert.cshtml"
WriteAttributeValue("", 4838, item.GradReverseDescribtion, 4838, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4866, "\')", 4866, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-darkaqua\">مشاهده توضیحات کارشناس فارغ التحصیلان</button>\n                                        <button");
            BeginWriteAttribute("onclick", " onclick=\"", 4989, "\"", 5032, 3);
            WriteAttributeValue("", 4999, "ReverseStudent(\'", 4999, 16, true);
#nullable restore
#line 77 "D:\Downloads\ShamsipourFinantialStudents-Master\ShamsipourFinantialStudents-Master\ShamsipourOnlineSystem\Views\EduExpert\EduExpert.cshtml"
WriteAttributeValue("", 5015, item.StudentId, 5015, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5030, "\')", 5030, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn--danger\">نقص مدارک</button>\n                                    </td>\n                                </tr>\n");
#nullable restore
#line 80 "D:\Downloads\ShamsipourFinantialStudents-Master\ShamsipourFinantialStudents-Master\ShamsipourOnlineSystem\Views\EduExpert\EduExpert.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "D:\Downloads\ShamsipourFinantialStudents-Master\ShamsipourFinantialStudents-Master\ShamsipourOnlineSystem\Views\EduExpert\EduExpert.cshtml"
                             
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"alert alert-danger\">درخواست فعالی وجود ندارد</div>\n");
#nullable restore
#line 85 "D:\Downloads\ShamsipourFinantialStudents-Master\ShamsipourFinantialStudents-Master\ShamsipourOnlineSystem\Views\EduExpert\EduExpert.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </tbody>\n                </table>\n                <button id=\"btnShowNormalStudents\" class=\"btn btn-warning mb-5 mt-3\"> مشاهده دانشجویان در انتظار ثبت</button>\n            </div>\n        </div>\n    </div>\n</div>\n\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2a4efe84e89469b1829d2768823d31c9eaa9596522122", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a4efe84e89469b1829d2768823d31c9eaa9596523299", async() => {
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
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a4efe84e89469b1829d2768823d31c9eaa9596524397", async() => {
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
                WriteLiteral(@"
    <script>
        $(""#btnShowReversedStudents"").on('click', function () {

            $(this).closest(""div .page-active"").css(""display"", ""none"");
            $(this).closest(""div .page-active"").attr(""class"", ""page-cloned"");
            $(""#btnShowNormalStudents"").closest(""div .page-cloned"").css(""display"", """");
            $(""#btnShowNormalStudents"").closest(""div .page-cloned"").attr(""class"", ""page-active"");

        });
        $(""#btnShowNormalStudents"").on('click', function () {

            $(this).closest(""div .page-active"").css(""display"", ""none"");
            $(this).closest(""div .page-active"").attr(""class"", ""page-cloned"");
            $(""#btnShowReversedStudents"").closest(""div .page-cloned"").css(""display"", """");
            $(""#btnShowReversedStudents"").closest(""div .page-cloned"").attr(""class"", ""page-active"");

        });


        function GetGradExpertDescribtion(gradDescribtion) {


            $('#GradDescribtion').val(gradDescribtion);

            $('#ShowGradExpertDescribtion').modal('show');");
                WriteLiteral("\n        }\n\n\n\n    </script>\n\n");
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
                            <label for=""basicInput""></label>
                            <textarea style=""height: 130px"" class=""col-12"" id=""StudentDescribtion"" placeholder=""توضیحی ثبت نشده""></textarea>
                        </fieldset>
                    <");
                WriteLiteral(@"/div>
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
                    <div class=""col-xl-12 col-lg-12 col-md-12 mb-1"">
                        <fieldset class=""form-group"">");
                WriteLiteral(@"
                            <input type=""hidden"" id=""StudentID"" />
                            <label for=""basicInput""></label>
                            <textarea style=""height: 130px"" class=""col-12"" id=""ReverseToStudent"" placeholder=""توضیحات نقصی مدارک دانشجو برای نمایش در پنل شخص را وارد کنید""></textarea>
                        </fieldset>
                    </div>
                </div>
                <div class=""modal-footer"">
                    <a href=""#"" class=""btn btn--danger text-white"" data-dismiss=""modal"">بستن</a>
                    <a onclick=""SetStAsReversed('EduExpert/SetAsReversed')"" class=""btn btn-darkaqua text-white"" data-dismiss=""modal"">ارسال</a>
                </div>
            </div>
        </div>
    </div>

    <div class=""modal fade"" id=""ShowGradExpertDescribtion"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
        <div class=""modal-dialog modal-dialog-centered"" role=""document"">
            <div class=""modal-content"">
           ");
                WriteLiteral(@"     <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLongTitle"">توضیحات مسئول فارغ التحصیلان</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    <div class=""col-xl-12 col-lg-12 col-md-12 mb-1"">
                        <fieldset class=""form-group"">
                            <label for=""basicInput""></label>
                            <textarea style=""height: 130px"" class=""col-12"" id=""GradDescribtion""> </textarea>
                        </fieldset>
                    </div>
                </div>
                <div class=""modal-footer"">
                    <a href=""#"" class=""btn btn--danger text-white"" data-dismiss=""modal"">بستن</a>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EduExpertViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
