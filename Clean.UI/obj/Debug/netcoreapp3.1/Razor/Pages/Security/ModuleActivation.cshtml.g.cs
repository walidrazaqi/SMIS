#pragma checksum "D:\SMIS\SMIS-Project\Clean.UI\Pages\Security\ModuleActivation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77c69585d1d4d32ccd1750f13c136f921065562a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Clean.UI.Pages.Security.Pages_Security_ModuleActivation), @"mvc.1.0.razor-page", @"/Pages/Security/ModuleActivation.cshtml")]
namespace Clean.UI.Pages.Security
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
#line 1 "D:\SMIS\SMIS-Project\Clean.UI\Pages\_ViewImports.cshtml"
using Clean.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\SMIS\SMIS-Project\Clean.UI\Pages\Security\ModuleActivation.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{handler?}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77c69585d1d4d32ccd1750f13c136f921065562a", @"/Pages/Security/ModuleActivation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4e588d119d3749322bd1c215836697b37532af0", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Security_ModuleActivation : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("dv_Security_ModuleActivation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form main-form page-component"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("prefix", new global::Microsoft.AspNetCore.Html.HtmlString("ux"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\SMIS\SMIS-Project\Clean.UI\Pages\Security\ModuleActivation.cshtml"
  
    ViewData["Title"] = "فعال سازی بخش ها";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 11 "D:\SMIS\SMIS-Project\Clean.UI\Pages\Security\ModuleActivation.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n<div class=\"panel panel-flat\">\r\n    <div class=\"panel-heading\">\r\n        <h1 class=\"panel-title\">فعال سازی بخش ها</h1>\r\n    </div>\r\n\r\n    <div class=\"panel-body\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "77c69585d1d4d32ccd1750f13c136f921065562a5461", async() => {
                WriteLiteral(@"
            <fieldset class=""content-group"">
                <legend class=""text-bold""> فعال سازی بخش ها</legend>
                <div class=""row"">
                    <div class=""col-md-4 "">
                        <div class=""form-group"">
                            <div class=""form-group has-feedback has-feedback-left"">
                                <label class=""text-bold"">
                                    ");
#nullable restore
#line 29 "D:\SMIS\SMIS-Project\Clean.UI\Pages\Security\ModuleActivation.cshtml"
                               Write(_localizer["کود"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                </label>
                                <input id=""uxid"" name=""uxId"" type=""text"" class=""form-control search"" disabled />
                            </div>
                        </div>

                    </div>
                    <div class=""col-md-4 "">
                        <div class=""form-group"">
                            <div class=""form-group has-feedback has-feedback-left"">
                                <label class=""text-bold"">
                                    ");
#nullable restore
#line 40 "D:\SMIS\SMIS-Project\Clean.UI\Pages\Security\ModuleActivation.cshtml"
                               Write(_localizer["نام"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                </label>
                                <input id=""uxname"" name=""uxName"" type=""text"" class=""form-control search"" disabled />
                            </div>
                        </div>

                    </div>
                </div>
                <div class=""row"">
                    <div class=""col-md-4 "">
                        <div class=""form-group"">
                            <div class=""form-group has-feedback has-feedback-left"">
                                <label class=""text-bold"">
                                    ");
#nullable restore
#line 53 "D:\SMIS\SMIS-Project\Clean.UI\Pages\Security\ModuleActivation.cshtml"
                               Write(_localizer["تشریحات"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                </label>
                                <input id=""uxdescription"" name=""uxDescription"" type=""text"" class=""form-control search"" disabled />
                            </div>
                        </div>

                    </div>
                    <div class=""col-md-4 "">
                        <div class=""form-group"">
                            <div class=""form-group has-feedback has-feedback-left"">
                                <label class=""text-bold"">
                                    ");
#nullable restore
#line 64 "D:\SMIS\SMIS-Project\Clean.UI\Pages\Security\ModuleActivation.cshtml"
                               Write(_localizer["سورتر"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                </label>
                                <input id=""uxsorter"" name=""uxSorter"" type=""text"" class=""form-control search"" disabled />
                            </div>
                        </div>

                    </div>
                </div>
                <div class=""row"">
                    <div class=""col-md-2"">
                        <div class=""form-group"">
                            <label class=""text-bold"">حالت</label>
");
                WriteLiteral(@"                            <div class=""form-check form-check-switch"">
                                <label class=""form-check-label"">
                                    <input type=""checkbox"" id=""uxisactive"" name=""uxIsActive"" class=""form-check-switch"" data-on-text=""فعال"" data-off-text=""غیر فعال"">
                                </label>
                            </div>
                        </div>
                    </div>

                    <div class=""form-group"">
                        
                    </div>
                </div>
            </fieldset>
            <hr />


            <div class=""row div-form-control main-form-details"">
                <div class=""col-md-12"">
                    <div class=""form-group actions"">
                        <button type=""button"" class=""btn btn-primary"" action=""save""><i class=""icon-floppy-disk position-left""></i>ثبت </button>
                        <button type=""button"" class=""btn btn-primary"" action=""search""><i class=""icon-");
                WriteLiteral(@"search4 position-left""></i>جستجو </button>
                    </div>
                </div>
            </div>
            <div class=""div-grid-control"" style=""display:none;"">

            </div>
            <div class=""form-grid"">
                <table direction=""rtl"" bindonclick=""true"">
                    <thead>
                        <tr>
                            <th colname=""Id"">کود</th>
                            <th colname=""Name"">تام بخش</th>
                            <th colname=""Description"">توصیحات بخش</th>
                            <th colname=""Sorter"">سورتر</th>
                            <th colname=""IsActiveName"">حالت</th>
                        </tr>
                    </thead>
                    <tbody></tbody>
                </table>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer _localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Clean.UI.Pages.Security.ModuleActivationModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Clean.UI.Pages.Security.ModuleActivationModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Clean.UI.Pages.Security.ModuleActivationModel>)PageContext?.ViewData;
        public Clean.UI.Pages.Security.ModuleActivationModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591