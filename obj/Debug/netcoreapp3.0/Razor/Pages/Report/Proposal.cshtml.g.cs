#pragma checksum "C:\Users\Jiawei\Documents\GitHub\StrongBartending\Pages\Report\Proposal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "578fa3932b5f83a5be2671e08f4a5d57091f9ee4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(StrongBartending.Pages.Report.Pages_Report_Proposal), @"mvc.1.0.razor-page", @"/Pages/Report/Proposal.cshtml")]
namespace StrongBartending.Pages.Report
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
#line 1 "C:\Users\Jiawei\Documents\GitHub\StrongBartending\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jiawei\Documents\GitHub\StrongBartending\Pages\_ViewImports.cshtml"
using StrongBartending;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Jiawei\Documents\GitHub\StrongBartending\Pages\_ViewImports.cshtml"
using StrongBartending.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"578fa3932b5f83a5be2671e08f4a5d57091f9ee4", @"/Pages/Report/Proposal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6640f5fd96da3eabd841045a30fc2e79d61482b3", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Report_Proposal : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("Propose"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Lead/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Jiawei\Documents\GitHub\StrongBartending\Pages\Report\Proposal.cshtml"
  
    ViewData["Title"] = "Proposal";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "578fa3932b5f83a5be2671e08f4a5d57091f9ee46306", async() => {
                WriteLiteral("\r\n    <title>Welcome</title>\r\n    <meta charset=\"utf-8\" />\r\n    <script type=\"text/javascript\">\r\n\r\n    </script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "578fa3932b5f83a5be2671e08f4a5d57091f9ee47398", async() => {
                WriteLiteral("\r\n    <header>\r\n        <h1>Bartending</h1>\r\n        <h1 style=\"font-size:60px;\">PROPOSAL</h1>\r\n    </header>\r\n    <hr />\r\n    <main>\r\n        <div>\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "578fa3932b5f83a5be2671e08f4a5d57091f9ee47832", async() => {
                    WriteLiteral(@"
                <div id=""CusInfo"" style=""padding-bottom:50px"">
                    <h1 style=""color:gray; padding-bottom:20px"">Bride name & Groom Name</h1>
                    <table>
                        <tr>
                            <td style=""padding-right:100px"">
                                <b>Customer Phone:</b>
                            </td>
                            <td>
                                ");
#nullable restore
#line 34 "C:\Users\Jiawei\Documents\GitHub\StrongBartending\Pages\Report\Proposal.cshtml"
                           Write(Model.Contacts.Phone);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                            </td>
                        </tr>
                        <tr>
                            <td style=""padding-right:100px"">
                                <b>Customer Email:</b>
                            </td>
                            <td>
                                ");
#nullable restore
#line 42 "C:\Users\Jiawei\Documents\GitHub\StrongBartending\Pages\Report\Proposal.cshtml"
                           Write(Model.Contacts.Email);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                            </td>
                        </tr>
                        <tr>
                            <td style=""padding-right:100px"">
                                <b>Event Date:</b>
                            </td>
                            <td>
                                ");
#nullable restore
#line 50 "C:\Users\Jiawei\Documents\GitHub\StrongBartending\Pages\Report\Proposal.cshtml"
                           Write(Model.Leads.EventDate.ToShortDateString());

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                            </td>
                        </tr>
                    </table>
                </div>
                <div id=""EvenInfo"" style=""padding-bottom:50px"">
                    <h2 style=""padding-bottom:20px"">Event Information</h2>
                    <table>
                        <tr>
                            <td style=""padding-right:100px"">
                                <b>Legacy ID:</b>
                            </td>
                            <td style=""padding-right:100px"">
                                ");
#nullable restore
#line 63 "C:\Users\Jiawei\Documents\GitHub\StrongBartending\Pages\Report\Proposal.cshtml"
                           Write(Model.Leads.LegacyId);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                            </td>\r\n                            <td style=\"padding-right:100px\">\r\n                                <b>Aenue Address:</b>\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 69 "C:\Users\Jiawei\Documents\GitHub\StrongBartending\Pages\Report\Proposal.cshtml"
                           Write(Model.Leads.Location);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                            </td>
                        </tr>
                        <tr>
                            <td style=""padding-right:100px"">
                                <b>Event Contact:</b>
                            </td>
                            <td style=""padding-right:100px"">
                                ");
#nullable restore
#line 77 "C:\Users\Jiawei\Documents\GitHub\StrongBartending\Pages\Report\Proposal.cshtml"
                           Write(Model.Contacts.FullName);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                            </td>
                            <td style=""padding-right:100px"">
                                <b>Event Contact Phone:</b>
                            </td>
                            <td>
                                ");
#nullable restore
#line 83 "C:\Users\Jiawei\Documents\GitHub\StrongBartending\Pages\Report\Proposal.cshtml"
                           Write(Model.Contacts.Phone);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                            </td>
                        </tr>
                        <tr>
                            <td style=""padding-right:100px"">
                                <b>Approx. Guest Count:</b>
                            </td>
                            <td style=""padding-right:100px"">
                                ");
#nullable restore
#line 91 "C:\Users\Jiawei\Documents\GitHub\StrongBartending\Pages\Report\Proposal.cshtml"
                           Write(Model.Leads.Guests);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                            </td>\r\n                            <td style=\"padding-right:100px\">\r\n                                <b>Bar Type:</b>\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 97 "C:\Users\Jiawei\Documents\GitHub\StrongBartending\Pages\Report\Proposal.cshtml"
                           Write(Model.Leads.BarTypeKeyNavigation.Description);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                            </td>
                        </tr>
                        <tr>
                            <td style=""padding-right:100px"">
                                <b>Bar Opens</b>
                            </td>
                            <td style=""padding-right:100px"">
                                ");
#nullable restore
#line 105 "C:\Users\Jiawei\Documents\GitHub\StrongBartending\Pages\Report\Proposal.cshtml"
                           Write(Model.Leads.StartTime);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                            </td>
                            <td>
                            </td>
                        </tr>
                        <tr>
                            <td style=""padding-right:100px"">
                                <b>Theme/Colours</b>
                            </td>
                            <td style=""padding-right:100px"">
                                ");
#nullable restore
#line 115 "C:\Users\Jiawei\Documents\GitHub\StrongBartending\Pages\Report\Proposal.cshtml"
                           Write(Model.Leads.Theme);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                            </td>
                        </tr>
                        <tr>
                            <td style=""padding-right:100px"">
                                <b>Additional Information:</b>
                            </td>
                            <td style=""padding-right:100px"">
                                ");
#nullable restore
#line 123 "C:\Users\Jiawei\Documents\GitHub\StrongBartending\Pages\Report\Proposal.cshtml"
                           Write(Model.Leads.Notes);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                            </td>
                        </tr>
                    </table>
                </div>
                <div id=""AvaServices"" style=""padding-bottom:50px"">
                    <h1 style=""padding-bottom:50px;text-align:center"">Available Services</h1>
                    <table>
");
#nullable restore
#line 131 "C:\Users\Jiawei\Documents\GitHub\StrongBartending\Pages\Report\Proposal.cshtml"
                         foreach (var item in Model.EventDetails)
                        {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    <h4>\r\n                                        ");
#nullable restore
#line 136 "C:\Users\Jiawei\Documents\GitHub\StrongBartending\Pages\Report\Proposal.cshtml"
                                   Write(item.ServiceKeyNavigation.Description);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                                        -\r\n                                        $");
#nullable restore
#line 138 "C:\Users\Jiawei\Documents\GitHub\StrongBartending\Pages\Report\Proposal.cshtml"
                                    Write(item.ServiceKeyNavigation.Price);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                                        /");
#nullable restore
#line 139 "C:\Users\Jiawei\Documents\GitHub\StrongBartending\Pages\Report\Proposal.cshtml"
                                    Write(item.ServiceKeyNavigation.Uom);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                                    </h4>\r\n                                </td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 145 "C:\Users\Jiawei\Documents\GitHub\StrongBartending\Pages\Report\Proposal.cshtml"
                               Write(item.Description);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 148 "C:\Users\Jiawei\Documents\GitHub\StrongBartending\Pages\Report\Proposal.cshtml"
                        }

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"                    </table>
                </div>
                <div id=""Closing"" style=""padding-bottom:50px"">
                    <h1 style=""padding-bottom:50px;text-align:center"">Closing</h1>
                    <table>
                        <tr>
                            <td>
                                <p>
                                    Strong Bartending will travel to venues in the Edmonton area at no additional cost. For travel outside of
                                    the Edmonton area, additional charges will apply. A flat rate based on distance will be charged.
                                </p>
                                <p>
                                    A NON-REFUNDABLE booking fee of 40% is required to complete the booking with the remaining 60%
                                    paid no later than 14 days prior to the event date.
                                </p>
                            </td>
                        </tr>
               ");
                    WriteLiteral("     </table>\r\n                </div>\r\n            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </div>\r\n        <div>\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "578fa3932b5f83a5be2671e08f4a5d57091f9ee420238", async() => {
                    WriteLiteral("\r\n                <div class=\"form-group\">\r\n                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "578fa3932b5f83a5be2671e08f4a5d57091f9ee420571", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                    if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                    {
                        throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                    }
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 173 "C:\Users\Jiawei\Documents\GitHub\StrongBartending\Pages\Report\Proposal.cshtml"
                                                                                   WriteLiteral(Model.Leads.LeadKey);

#line default
#line hidden
#nullable disable
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "578fa3932b5f83a5be2671e08f4a5d57091f9ee423093", async() => {
                        WriteLiteral("Back to Lead List");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                </div>\r\n            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </div>\r\n    </main>\r\n    <footer>\r\n    </footer>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StrongBartending.Pages.Report.ProposalModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<StrongBartending.Pages.Report.ProposalModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<StrongBartending.Pages.Report.ProposalModel>)PageContext?.ViewData;
        public StrongBartending.Pages.Report.ProposalModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
