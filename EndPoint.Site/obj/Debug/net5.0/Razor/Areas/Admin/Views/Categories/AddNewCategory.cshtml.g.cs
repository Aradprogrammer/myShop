#pragma checksum "C:\Users\aradprogrammer\source\repos\asp_store_bugeto\EndPoint.Site\Areas\Admin\Views\Categories\AddNewCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd0186519f116a6563389d95181c7bab499001b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Categories_AddNewCategory), @"mvc.1.0.view", @"/Areas/Admin/Views/Categories/AddNewCategory.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd0186519f116a6563389d95181c7bab499001b9", @"/Areas/Admin/Views/Categories/AddNewCategory.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Categories_AddNewCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/sweetalert2/sweetalert2.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/sweetalert2/sweetalert2.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\Users\aradprogrammer\source\repos\asp_store_bugeto\EndPoint.Site\Areas\Admin\Views\Categories\AddNewCategory.cshtml"
  
    ViewData["Title"] = "AddNewCategry";
    Layout = "~/Areas/Admin/Views/Shared/_Adminlayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""col-md-12"">
    <div class=""card"">
        <div class=""card-header"">
            <div class=""card-title-wrap bar-success"">
                <h4 class=""card-title"" id=""basic-layout-form"">فرم افزودن دسته بندی جدید</h4>
            </div>
        </div>
        <div class=""card-body"">
            <div class=""px-3"">
                <div class=""form"">
                    <div class=""form-body"">
                        <h4 class=""form-section""></h4>
                        <div class=""row"">
                            <div class=""col-md-6"">
                                <div class=""form-group"">
                                    <label for=""Name"">نام</label>
                                    <input type=""text"" id=""Name"" class=""form-control border-primary"">
                                    <input type=""hidden"" id=""ParentId""");
            BeginWriteAttribute("value", " value=", 977, "", 1001, 1);
#nullable restore
#line 22 "C:\Users\aradprogrammer\source\repos\asp_store_bugeto\EndPoint.Site\Areas\Admin\Views\Categories\AddNewCategory.cshtml"
WriteAttributeValue("", 984, ViewBag.parentId, 984, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control border-primary"">
                                </div>
                                <button type=""button"" class=""btn btn-success"" onclick=""Addcategory()"">
                                    <i class=""icon-note""></i> ذخیره
                                </button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

");
            DefineSection("Script", async() => {
                WriteLiteral("\r\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd0186519f116a6563389d95181c7bab499001b96032", async() => {
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
                WriteLiteral("\r\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bd0186519f116a6563389d95181c7bab499001b97127", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
<script>
   function Addcategory()
   {
         Swal.fire({
             title: 'هشدار',
             text: ""ایا از افزودن دسته بندی اطمینان دارید؟"",
             icon: 'warning',
             showCancelButton: true,
             confirmButtonColor: '#3085d6',
             cancelButtonColor: '#d33',
             confirmButtonText: 'بله',
             cancelButtonText:'خیر'
         }).then((result) =>{
             if(result.isConfirmed){

                 var postdata={
                     parentId:document.getElementById('ParentId').value,
                     name:document.getElementById('Name').value}
                     console.log(postdata);
                 $.ajax({
                     contentType: 'application/x-www-form-urlencoded',
                     dataType: 'json',
                     type: ""POST"",
                     url: ""AddNewCategory"",
                     data: postdata,
                     success: function (data) {
                         if (data.isS");
                WriteLiteral(@"uccess == true) {
                             swal.fire(
                                 'موفق!',
                                 data.message,
                                 'success'
                              )
                              .then
                              (function (isConfirm) 
                              {
                                  location.reload();
                              }
                              );
                             }
                             else 
                             {
                                 swal.fire
                                 (
                                     'هشدار!',
                                     data.message,
                                     'warning' 
                                 );
                             }
                         },
                         error: function (request, status, error) 
                         {
                            ");
                WriteLiteral(@" if(request.responseText != null)
                             {
                                 alert(request.responseText );
                             }
                             else
                             {
                                 alert(error.text);
                             } 
                         }

                     });
                    }
                 });
   }
</script>
");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
