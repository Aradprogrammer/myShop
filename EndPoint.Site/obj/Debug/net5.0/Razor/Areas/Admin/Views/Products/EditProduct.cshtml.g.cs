#pragma checksum "C:\Users\aradprogrammer\source\repos\asp_store_bugeto\EndPoint.Site\Areas\Admin\Views\Products\EditProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52505b6e094892386fa03d210e9cc9134bc5aa00"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Products_EditProduct), @"mvc.1.0.view", @"/Areas/Admin/Views/Products/EditProduct.cshtml")]
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
#line 7 "C:\Users\aradprogrammer\source\repos\asp_store_bugeto\EndPoint.Site\Areas\Admin\Views\Products\EditProduct.cshtml"
using asp_store_bugeto.Application.Services.Products.Queries.GetProductForAdmin;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52505b6e094892386fa03d210e9cc9134bc5aa00", @"/Areas/Admin/Views/Products/EditProduct.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Products_EditProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductDto>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("ProductCategory"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "PCategory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-thumbnail img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Image description"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("FormProduct"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/sweetalert2/sweetalert2.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/sweetalert2/sweetalert2.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\aradprogrammer\source\repos\asp_store_bugeto\EndPoint.Site\Areas\Admin\Views\Products\EditProduct.cshtml"
  
    ViewData["Title"] = "EditProduct";
    Layout = "~/Areas/Admin/Views/Shared/_Adminlayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
<div class=""col-md-12"">
    <div class=""card"">
        <div class=""card-header"">
            <div class=""card-title-wrap bar-success"">
                <h4 class=""card-title"" id=""basic-layout-form"">ویرایش کالا</h4>
            </div>
        </div>
        <div class=""card-body"">
            <div class=""px-3"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52505b6e094892386fa03d210e9cc9134bc5aa007611", async() => {
                WriteLiteral(@"
                    <div class=""form-body"">
                        <h4 class=""form-section"">
                            <i class=""icon-box-seam""></i> اطلاعات کالا
                        </h4>
                        <div class=""row"">
                            <div class=""col-md-6"">
                                <div class=""form-group"">
                                    <label for=""ProductName"">نام کالا</label>
                                    <input type=""text"" id=""ProductName"" class=""form-control"" name=""PName""");
                BeginWriteAttribute("value", " value=\"", 1181, "\"", 1200, 1);
#nullable restore
#line 28 "C:\Users\aradprogrammer\source\repos\asp_store_bugeto\EndPoint.Site\Areas\Admin\Views\Products\EditProduct.cshtml"
WriteAttributeValue("", 1189, Model.Name, 1189, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                </div>
                            </div>
                            <div class=""col-md-6"">
                                <div class=""form-group"">
                                    <label for=""ProductBrand"">برند کالا</label>
                                    <input type=""text"" id=""ProductBrand"" class=""form-control"" name=""PBrand""");
                BeginWriteAttribute("value", " value=\"", 1578, "\"", 1598, 1);
#nullable restore
#line 34 "C:\Users\aradprogrammer\source\repos\asp_store_bugeto\EndPoint.Site\Areas\Admin\Views\Products\EditProduct.cshtml"
WriteAttributeValue("", 1586, Model.Brand, 1586, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                </div>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-md-6"">
                                <div class=""form-group"">
                                    <label for=""ProductPrice"">فیمت کالا</label>
                                    <input type=""number"" id=""ProductPrice"" class=""form-control"" name=""PPrice""");
                BeginWriteAttribute("value", " value=\"", 2053, "\"", 2073, 1);
#nullable restore
#line 42 "C:\Users\aradprogrammer\source\repos\asp_store_bugeto\EndPoint.Site\Areas\Admin\Views\Products\EditProduct.cshtml"
WriteAttributeValue("", 2061, Model.Price, 2061, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                                </div>
                            </div>
                            <div class=""col-md-6"">
                                <div class=""form-group"">
                                    <label for=""ProductInventory"">موجودی کالا</label>
                                    <input type=""number"" id=""ProductInventory"" class=""form-control"" name=""PInventory""");
                BeginWriteAttribute("value", " value=\"", 2469, "\"", 2493, 1);
#nullable restore
#line 48 "C:\Users\aradprogrammer\source\repos\asp_store_bugeto\EndPoint.Site\Areas\Admin\Views\Products\EditProduct.cshtml"
WriteAttributeValue("", 2477, Model.Inventory, 2477, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                </div>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-md-6"">
                                <div class=""form-group"">
                                    <label for=""ProductCategory"">دسته بندی</label>
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52505b6e094892386fa03d210e9cc9134bc5aa0011739", async() => {
                    WriteLiteral("\r\n                                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 56 "C:\Users\aradprogrammer\source\repos\asp_store_bugeto\EndPoint.Site\Areas\Admin\Views\Products\EditProduct.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.Categoreis;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
                            <div class=""col-md-6"">
                                <div class=""form-group"">
                                    <label for=""DiplayeProduct"">نمایش داده شود؟</label>
");
#nullable restore
#line 63 "C:\Users\aradprogrammer\source\repos\asp_store_bugeto\EndPoint.Site\Areas\Admin\Views\Products\EditProduct.cshtml"
                                     if (Model.Displayed)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <input type=\"checkbox\" id=\"DiplayeProduct\" class=\"form-control\" checked=\"checked\" />\r\n");
#nullable restore
#line 66 "C:\Users\aradprogrammer\source\repos\asp_store_bugeto\EndPoint.Site\Areas\Admin\Views\Products\EditProduct.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <input type=\"checkbox\" id=\"DiplayeProduct\" class=\"form-control\" />\r\n");
#nullable restore
#line 70 "C:\Users\aradprogrammer\source\repos\asp_store_bugeto\EndPoint.Site\Areas\Admin\Views\Products\EditProduct.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                </div>
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label for=""ProductImg"">تصاویر کالا</label>
                            <input type=""file"" accept=""image/*"" multiple class=""form-control-file"" id=""ProductImg"" />
                        </div>
                        <div class=""row"">
");
#nullable restore
#line 79 "C:\Users\aradprogrammer\source\repos\asp_store_bugeto\EndPoint.Site\Areas\Admin\Views\Products\EditProduct.cshtml"
                             for (int i = 0; i < Model.Images.Count; i++)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <figure class=\" col-4\"");
                BeginWriteAttribute("id", " id=\"", 4377, "\"", 4389, 2);
                WriteAttributeValue("", 4382, "imag-", 4382, 5, true);
#nullable restore
#line 81 "C:\Users\aradprogrammer\source\repos\asp_store_bugeto\EndPoint.Site\Areas\Admin\Views\Products\EditProduct.cshtml"
WriteAttributeValue("", 4387, i, 4387, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                    <div class=\"carousel-caption\">\r\n                                        <p class=\"textalign\" style=\"text-align:center;color:gray;\"><i id=\"trashimag\"");
                BeginWriteAttribute("onclick", " onclick=\"", 4577, "\"", 4632, 6);
                WriteAttributeValue("", 4587, "deleteimagep(", 4587, 13, true);
#nullable restore
#line 83 "C:\Users\aradprogrammer\source\repos\asp_store_bugeto\EndPoint.Site\Areas\Admin\Views\Products\EditProduct.cshtml"
WriteAttributeValue("", 4600, Model.Images[i].ID, 4600, 19, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 4619, ",", 4620, 2, true);
                WriteAttributeValue(" ", 4621, "\'imag-", 4622, 7, true);
#nullable restore
#line 83 "C:\Users\aradprogrammer\source\repos\asp_store_bugeto\EndPoint.Site\Areas\Admin\Views\Products\EditProduct.cshtml"
WriteAttributeValue("", 4628, i, 4628, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4630, "\')", 4630, 2, true);
                EndWriteAttribute();
                WriteLiteral(" class=\"fa fa-trash font-large-3\"></i></p>\r\n                                    </div>\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "52505b6e094892386fa03d210e9cc9134bc5aa0017743", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 4799, "~/", 4799, 2, true);
#nullable restore
#line 85 "C:\Users\aradprogrammer\source\repos\asp_store_bugeto\EndPoint.Site\Areas\Admin\Views\Products\EditProduct.cshtml"
AddHtmlAttributeValue("", 4801, Model.Images[i].Src, 4801, 20, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                                </figure>\r\n");
#nullable restore
#line 88 "C:\Users\aradprogrammer\source\repos\asp_store_bugeto\EndPoint.Site\Areas\Admin\Views\Products\EditProduct.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        </div>
                        <div class=""form-group"">
                            <label for=""ProductDescription"">توضیحات کالا</label>
                            <textarea id=""ProductDescription"" rows=""5"" class=""form-control"">");
#nullable restore
#line 92 "C:\Users\aradprogrammer\source\repos\asp_store_bugeto\EndPoint.Site\Areas\Admin\Views\Products\EditProduct.cshtml"
                                                                                       Write(Model.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</textarea>
                        </div>
                    </div>
                    <h4 class=""form-section"">
                        <i class=""icon-receipt""></i>مشخصات کالا
                    </h4>

                    <div class=""form-group"">
                        <label for=""FeaturesName"">نام ویژگی</label>
                        <input type=""text"" id=""FeaturesName"" class=""form-control"" name=""Features_Name"">
                    </div>
                    <div class=""form-group"">
                        <label for=""FeaturesValue"">مقدار ویژگی</label>
                        <input type=""text"" id=""FeaturesValue"" class=""form-control"" name=""FeaturesValue"">
                    </div>
                    <button type=""button"" id=""btn-addfeature"" class=""btn btn-success"">
                        <i class=""icon-note""></i> افزودن
                    </button>
                    <div class=""form-group"">
                        <label>ویژگی های ثبت شده</label>
                        <tabl");
                WriteLiteral(@"e class=""table table-striped table-bordered zero-configuration dataTable"" id=""Table_Features"" role=""grid"">
                            <thead>
                                <tr role=""row"">
                                    <th>نام ویژگی</th>
                                    <th>مقدار ویژگی</th>
                                    <th></th>
                                </tr>
                            </thead>
                            <tbody id=""TableTbody"">
");
#nullable restore
#line 121 "C:\Users\aradprogrammer\source\repos\asp_store_bugeto\EndPoint.Site\Areas\Admin\Views\Products\EditProduct.cshtml"
                                 foreach (var item in Model.Featurs)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <tr role=\"row\" class=\"even notnew\">\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 125 "C:\Users\aradprogrammer\source\repos\asp_store_bugeto\EndPoint.Site\Areas\Admin\Views\Products\EditProduct.cshtml"
                                       Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 128 "C:\Users\aradprogrammer\source\repos\asp_store_bugeto\EndPoint.Site\Areas\Admin\Views\Products\EditProduct.cshtml"
                                       Write(item.Value);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            <button");
                BeginWriteAttribute("onclick", " onclick=\"", 7282, "\"", 7321, 3);
                WriteAttributeValue("", 7292, "removeFeaturproduct(", 7292, 20, true);
#nullable restore
#line 131 "C:\Users\aradprogrammer\source\repos\asp_store_bugeto\EndPoint.Site\Areas\Admin\Views\Products\EditProduct.cshtml"
WriteAttributeValue("", 7312, item.ID, 7312, 8, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 7320, ")", 7320, 1, true);
                EndWriteAttribute();
                WriteLiteral(" type=\"button\" class=\"btn btn-danger\" id=\"deletefeaturp\">حذف</button>\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 134 "C:\Users\aradprogrammer\source\repos\asp_store_bugeto\EndPoint.Site\Areas\Admin\Views\Products\EditProduct.cshtml"

                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </tbody>\r\n                        </table>\r\n                        <input type=\"hidden\" id=\"ProductId\" name=\"PId\"");
                BeginWriteAttribute("value", " value=\"", 7662, "\"", 7679, 1);
#nullable restore
#line 138 "C:\Users\aradprogrammer\source\repos\asp_store_bugeto\EndPoint.Site\Areas\Admin\Views\Products\EditProduct.cshtml"
WriteAttributeValue("", 7670, Model.ID, 7670, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                    </div>
                    <div class=""form-actions"">
                        <button type=""button"" onclick=""cancelEdite()"" class=""btn btn-danger mr-1"">
                            <i class=""icon-trash""></i> لغو
                        </button>
                        <button type=""button"" id=""btn_add"" class=""btn btn-success"">
                            <i class=""icon-note""></i> ذخیره
                        </button>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n");
            DefineSection("Script", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52505b6e094892386fa03d210e9cc9134bc5aa0026786", async() => {
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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "52505b6e094892386fa03d210e9cc9134bc5aa0027886", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script>

        function deleteimagep(id, tagid) {
            Swal.fire({
                title: 'حذف عکس',
                text: ""آیا از حذف عکس مطمئن هستید؟"",
                icon: 'warning',
                showCancelButton: true,
                confirmButtonColor: '#3085d6',
                cancelButtonColor: '#d33',
                confirmButtonText: 'بله ',
                cancelButtonText: 'خیر'
            }).then((result) => {
                if (result.value) {

                    var postData = {
                        'ImageId': id,

                    };


                    $.ajax({
                        contentType: 'application/x-www-form-urlencoded',
                        dataType: 'json',
                        type: ""POST"",
                        url: ""deleteimage"",
                        data: postData,
                        success: function(data) {
                            if (data.isSuccess == true) {
                               ");
                WriteLiteral(@" swal.fire(
                                    'موفق!',
                                    data.message,
                                    'success'
                                ).then(function(isConfirm) {
                                    $('#' + tagid).remove();
                                });


                            }
                            else {

                                swal.fire(
                                    'هشدار!',
                                    data.message,
                                    'warning'
                                );

                            }
                        },
                        error: function(request, status, error) {
                            alert(request.responseText);
                            alert(error.text);

                        }

                    });

                }
            })

        }

        function removeFeaturproduct(id) {
            var postDa");
                WriteLiteral(@"ta = {
                'FeaturId': id,
            };


            $.ajax({
                contentType: 'application/x-www-form-urlencoded',
                dataType: 'json',
                type: ""POST"",
                url: ""deletefeaturs"",
                data: postData,
                success: function(data) {
                    if (data.isSuccess == true) {
                        swal.fire(
                            'موفق!',
                            data.message,
                            'success'
                        ).then(function(isConfirm) {
                            $('#deletefeaturp').closest('tr').remove();
                        });


                    }
                    else {

                        swal.fire(
                            'هشدار!',
                            data.message,
                            'warning'
                        );

                    }
                },
                error: function(request, st");
                WriteLiteral(@"atus, error) {
                    alert(request.responseText);
                    alert(error.text);

                }

            });
        }
        function cancelEdite() {
            window.location = ""\."";
        }


        $('#btn-addfeature').on('click', function() {
            var Displaye = $('#FeaturesName').val();
            var Value = $('#FeaturesValue').val();
            if (Displaye != '' && Value != '') {
                $('#TableTbody').append('<tr role=""row"" class=""even""><td>' + Displaye + '</td><td>' + Value + '</td><td>   <button type=""button"" class=""btn btn-danger"" id=""deletefeatur"">حذف</button></td></tr>')
                $('#FeaturesName').val('');
                $('#FeaturesValue').val('');
            }
            else {
                swal.fire(
                    'هشدار!',
                    ""نام ویژگی و مقدار ویژگی را باید وارد کنید"",
                    'warning'
                );
            }
        });


        $('#Table_Featur");
                WriteLiteral(@"es').on('click', '#deletefeatur', function() {
            this.closest('tr').remove();
        });


        var data = new FormData();
        $('#btn_add').on('click', function() {
            data.append('ID', $('#ProductId').val());
            data.append('Name', $('#ProductName').val());
            data.append('Brand', $('#ProductBrand').val());
            data.append('Description', $('#ProductDescription').val());
            data.append('Inventory', $('#ProductInventory').val());
            data.append('Price', $('#ProductPrice').val());
            data.append('CategoryID', $('#ProductCategory').find(""option:selected"").val());
            data.append('Displayed', $('#DiplayeProduct').is("":checked""));
            var imagesifiles = document.getElementById(""ProductImg"");
            if (imagesifiles.files.length > 0) {

                for (var i = 0; i < imagesifiles.files.length; i++) {
                    data.append('[' + i + '].ProductImages', imagesifiles.files[i]);
      ");
                WriteLiteral(@"          }

            }

            var featuers = $('#Table_Features tr:gt(0)').not("".notnew"").map(function() {
                return {
                    DisplayeName: $(this.cells[0]).text(),
                    Value: $(this.cells[1]).text()
                };
            }).get();
            console.log(featuers);
            $.each(featuers, function(inde, item) {
                data.append('Featurs[' + inde + '].Name', item.DisplayeName);
                data.append('Featurs[' + inde + '].Value', item.Value);
            });

            $.ajax({
                type: ""POST"",
                url: ""EditProduct"",
                contentType: false,
                processData: false,
                data: data,
                success: function(data) {
                    if (data.isSuccess == true) {

                        swal.fire(
                            'موفق!',
                            data.message,
                            'success'
                ");
                WriteLiteral(@"        ).then(function(isConfirm) {
                            location.reload();
                        });
                    }
                    else {

                        swal.fire(
                            'هشدار!',
                            data.message,
                            'warning'
                        );

                    }
                },
                error: function(request, status, error) {
                    if (request.responseText != null) {
                        alert(request.responseText);
                    } else {
                        alert(error.text);
                    }

                }

            });


        });












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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductDto> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
