#pragma checksum "C:\Users\aradprogrammer\source\repos\asp_store_bugeto\EndPoint.Site\Areas\Admin\Views\Email\SenderEmailsList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4cc4cf3fbadac7375e62c23f87e3e6563c21565e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Email_SenderEmailsList), @"mvc.1.0.view", @"/Areas/Admin/Views/Email/SenderEmailsList.cshtml")]
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
#line 2 "C:\Users\aradprogrammer\source\repos\asp_store_bugeto\EndPoint.Site\Areas\Admin\Views\Email\SenderEmailsList.cshtml"
using asp_store_bugeto.Application.Services.Emails.Queries.GetSenderEmail;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4cc4cf3fbadac7375e62c23f87e3e6563c21565e", @"/Areas/Admin/Views/Email/SenderEmailsList.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Email_SenderEmailsList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SendersEmailDto>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "10", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "25", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "50", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "100", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("SenderEmailsList"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display:inline;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\aradprogrammer\source\repos\asp_store_bugeto\EndPoint.Site\Areas\Admin\Views\Email\SenderEmailsList.cshtml"
  
    ViewData["Title"] = "SenderEmailsList";
    Layout = "~/Areas/Admin/Views/Shared/_Adminlayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
 <div class=""content-wrapper"">
        <div class=""container-fluid"">
            <!-- Zero configuration table -->
            <section id=""configuration"">
                <div class=""row"">
        
                    <div class=""col-12"">
           
                        <div class=""card"">
             
                            <div class=""card-header"">
               
                                <div class=""card-title-wrap bar-success"">
                                    <h4 class=""card-title"">لیست ارسال کننده ایمیل </h4>
                                </div>
                
                            </div>
               
                            <div class=""card-body collapse show"">
                   
                                <div class=""card-block card-dashboard"">                        
                                    <div id=""DataTables_Table_0_wrapper"" class=""dataTables_wrapper container-fluid dt-bootstrap4"">
                                       ");
            WriteLiteral(@" <div class=""row"">
                                            <div class=""col-sm-12 col-md-6"">
                                                <div class=""dataTables_length"" id=""DataTables_Table_0_length"">
                                                    <label>نمایش 
                                                        <select name=""DataTables_Table_0_length"" aria-controls=""DataTables_Table_0"" class=""form-control form-control-sm"">
                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4cc4cf3fbadac7375e62c23f87e3e6563c21565e8607", async() => {
                WriteLiteral("10");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4cc4cf3fbadac7375e62c23f87e3e6563c21565e9822", async() => {
                WriteLiteral("25");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4cc4cf3fbadac7375e62c23f87e3e6563c21565e11037", async() => {
                WriteLiteral("50");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4cc4cf3fbadac7375e62c23f87e3e6563c21565e12253", async() => {
                WriteLiteral("100");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                        </select> 
                                                        سطر
                                                    </label>
                                                    </div>
                                                    </div>
                                                    <div class=""col-sm-12 col-md-6"">
                                                        <div id=""DataTables_Table_0_filter"" class=""dataTables_filter"">
                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4cc4cf3fbadac7375e62c23f87e3e6563c21565e13992", async() => {
                WriteLiteral("\r\n                                                                <label>جستجو:\r\n                                                                    <input type=\"search\" name=\"serchkey\" id=\"serchkey\" class=\"form-control form-control-sm\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 2994, "\"", 3008, 0);
                EndWriteAttribute();
                WriteLiteral(@" aria-controls=""DataTables_Table_0"">
                                                                </label>
                                                                <input class=""btn btn-info mine-a-css"" type=""submit"" style=""margin:0;"" value=""جستوجو""/>
                                                               
                                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                            <button class=""btn btn-success mine-a-css"" style=""margin:0; margin-right:10px;"" onclick=""AddNewSender()"">افزودن</button>
                                                            </div>
                                                            </div>
                                                                </div>
                                                                <div class=""row""><div class=""col-sm-12"">
                                                                    
                                                                    
                                                                    
                                                                    <table class=""table table-striped table-bordered zero-configuration dataTable"" id=""DataTables_Table_0"" role=""grid"" aria-describedby=""DataTables_Table_0_info"">
                         
                                        <thead>
            ");
            WriteLiteral(@"                 
                                        <tr role=""row"">
                                            <th class=""sorting_asc col-1"" tabindex=""0"" aria-controls=""DataTables_Table_0"" rowspan=""1"" colspan=""1"" aria-sort=""ascending"" aria-label=""نام: activate to sort column descending"" >
                                                شماره
                                                </th>
                                                <th class=""sorting col-2 "" tabindex=""0"" aria-controls=""DataTables_Table_0"" rowspan=""1"" colspan=""1"" aria-label=""موقعیت: activate to sort column ascending"">
                                                    ایمیل

                                                </th>
                                                <th class=""sorting col-2"" tabindex=""0"" aria-controls=""DataTables_Table_0"" rowspan=""1"" colspan=""1"" aria-label=""اداره: activate to sort column ascending"" >
                                               رمز
                                       ");
            WriteLiteral(@"         </th>
                                                <th class=""sorting col-3"" tabindex=""0"" aria-controls=""DataTables_Table_0"" rowspan=""1"" colspan=""1"" aria-label=""اداره: activate to sort column ascending"" >
                                               
                                                </th>
                                                </tr>
                                    </thead>
                                    <tbody>
");
#nullable restore
#line 83 "C:\Users\aradprogrammer\source\repos\asp_store_bugeto\EndPoint.Site\Areas\Admin\Views\Email\SenderEmailsList.cshtml"
                                                         foreach(var item in Model.Senders)
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <tr role=\"row\" class=\"odd\">\r\n                                                                <td class=\"sorting_1\">");
#nullable restore
#line 86 "C:\Users\aradprogrammer\source\repos\asp_store_bugeto\EndPoint.Site\Areas\Admin\Views\Email\SenderEmailsList.cshtml"
                                                                                 Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                                                <td>");
#nullable restore
#line 87 "C:\Users\aradprogrammer\source\repos\asp_store_bugeto\EndPoint.Site\Areas\Admin\Views\Email\SenderEmailsList.cshtml"
                                                               Write(item.Addres);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                                <td>");
#nullable restore
#line 88 "C:\Users\aradprogrammer\source\repos\asp_store_bugeto\EndPoint.Site\Areas\Admin\Views\Email\SenderEmailsList.cshtml"
                                                               Write(item.Password);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                                <td>\r\n                                                                    <button class=\"btn btn-info\"");
            BeginWriteAttribute("onclick", " onclick=\"", 6608, "\"", 6670, 7);
            WriteAttributeValue("", 6618, "EditSender(", 6618, 11, true);
#nullable restore
#line 90 "C:\Users\aradprogrammer\source\repos\asp_store_bugeto\EndPoint.Site\Areas\Admin\Views\Email\SenderEmailsList.cshtml"
WriteAttributeValue("", 6629, item.Id, 6629, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6637, ",\'", 6637, 2, true);
#nullable restore
#line 90 "C:\Users\aradprogrammer\source\repos\asp_store_bugeto\EndPoint.Site\Areas\Admin\Views\Email\SenderEmailsList.cshtml"
WriteAttributeValue("", 6639, item.Addres, 6639, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6651, "\',\'", 6651, 3, true);
#nullable restore
#line 90 "C:\Users\aradprogrammer\source\repos\asp_store_bugeto\EndPoint.Site\Areas\Admin\Views\Email\SenderEmailsList.cshtml"
WriteAttributeValue("", 6654, item.Password, 6654, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6668, "\')", 6668, 2, true);
            EndWriteAttribute();
            WriteLiteral("> ویرایش </button>\r\n                                                                    <button class=\"btn btn-danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 6789, "\"", 6820, 3);
            WriteAttributeValue("", 6799, "DeletSender(", 6799, 12, true);
#nullable restore
#line 91 "C:\Users\aradprogrammer\source\repos\asp_store_bugeto\EndPoint.Site\Areas\Admin\Views\Email\SenderEmailsList.cshtml"
WriteAttributeValue("", 6811, item.Id, 6811, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6819, ")", 6819, 1, true);
            EndWriteAttribute();
            WriteLiteral("> حذف </button>\r\n                                                                 \r\n                                                                </td>\r\n                                                            </tr> \r\n");
#nullable restore
#line 95 "C:\Users\aradprogrammer\source\repos\asp_store_bugeto\EndPoint.Site\Areas\Admin\Views\Email\SenderEmailsList.cshtml"
                                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                       \r\n                                                        \r\n                                                     \r\n                                                    </tbody>\r\n");
            WriteLiteral(@"                        </table></div></div><div class=""row""><div class=""col-sm-12 col-md-5""><div class=""dataTables_info"" id=""DataTables_Table_0_info"" role=""status"" aria-live=""polite"">نمایش 1 تا 10 از 57 سطرها</div></div><div class=""col-sm-12 col-md-7""><div class=""dataTables_paginate paging_simple_numbers"" id=""DataTables_Table_0_paginate""><ul class=""pagination""><li class=""paginate_button page-item previous disabled"" id=""DataTables_Table_0_previous""><a href=""#"" aria-controls=""DataTables_Table_0"" data-dt-idx=""0"" tabindex=""0"" class=""page-link"">قبلی</a></li><li class=""paginate_button page-item active""><a href=""#"" aria-controls=""DataTables_Table_0"" data-dt-idx=""1"" tabindex=""0"" class=""page-link"">1</a></li><li class=""paginate_button page-item ""><a href=""#"" aria-controls=""DataTables_Table_0"" data-dt-idx=""2"" tabindex=""0"" class=""page-link"">2</a></li><li class=""paginate_button page-item ""><a href=""#"" aria-controls=""DataTables_Table_0"" data-dt-idx=""3"" tabindex=""0"" class=""page-link"">3</a></li><li class=""paginate_button pa");
            WriteLiteral(@"ge-item ""><a href=""#"" aria-controls=""DataTables_Table_0"" data-dt-idx=""4"" tabindex=""0"" class=""page-link"">4</a></li><li class=""paginate_button page-item ""><a href=""#"" aria-controls=""DataTables_Table_0"" data-dt-idx=""5"" tabindex=""0"" class=""page-link"">5</a></li><li class=""paginate_button page-item ""><a href=""#"" aria-controls=""DataTables_Table_0"" data-dt-idx=""6"" tabindex=""0"" class=""page-link"">6</a></li><li class=""paginate_button page-item next"" id=""DataTables_Table_0_next""><a href=""#"" aria-controls=""DataTables_Table_0"" data-dt-idx=""7"" tabindex=""0"" class=""page-link"">بعدی</a></li></ul></div></div></div></div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!--/ Zero configuration table -->

       </div>
    </div>
");
            DefineSection("Script", async() => {
                WriteLiteral("\r\n   ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4cc4cf3fbadac7375e62c23f87e3e6563c21565e25604", async() => {
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
                WriteLiteral("\r\n   ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4cc4cf3fbadac7375e62c23f87e3e6563c21565e26703", async() => {
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
   function AddNewSender(){
(async () => {

const { value: formValues } = await Swal.fire({
  title: 'افزودن ارسال کننده',
  html:
    '<div class=""form-group"">'+
    '<label>ایمیل</label>'+
    '<input class=""form-control border-primary"" type=""email"" id=""new-email"">'+
    '</div>'+
    '<div class=""form-group"">'+
    '<label>گذرواژه</label>'+
    '<input class=""form-control border-primary"" type=""text"" id=""new-password"">'+
    '</div>',
  focusConfirm: false,
  preConfirm: () => {
    return [
      document.getElementById('new-email').value,
      document.getElementById('new-password').value
    ]
  }
})

if (formValues) {
    var postdata={
        Email:formValues[0],
        Password:formValues[1]
    }
   $.ajax({
                       contentType: 'application/x-www-form-urlencoded',
                       dataType: 'json',
                       type: ""POST"",
                       url: ""AddSenderEmail"",
                       data: postdata,
         ");
                WriteLiteral(@"              success: function (data) {
                           if (data.isSuccess == true) {
                               swal.fire(
                                   'موفق!',
                                   data.message,
                                   'success'
                               ).then(function (isConfirm) {
                                   location.reload();
                               });
                   
                   
                           }
                           else {
                   
                               swal.fire(
                                   'هشدار!',
                                   data.message,
                                   'warning'
                               ) ;
                   
                           }
                       },
                       error: function (request, status, error) {
                           if(request.responseText != null){
                           aler");
                WriteLiteral(@"t(request.responseText );
                           }else{
                           alert(error.text );}
                   
                       }
                   
                   });
}

})()
   }
   function EditSender(id,email,password){
       (async () => {

const { value: formValues } = await Swal.fire({
  title: 'ویرایش ارسال کننده',
  html:
    '<div class=""form-group"">'+
    '<label>ایمیل</label>'+
    '<input value=""'+email+'"" class=""form-control border-primary"" type=""email"" id=""edit-email"">'+
    '</div>'+
    '<div class=""form-group"">'+
    '<label>گذرواژه</label>'+
    '<input value=""'+password+'"" class=""form-control border-primary"" type=""text"" id=""edit-password"">'+
    '<input value=""'+id+'"" class=""form-control border-primary"" type=""hidden"" id=""edit-id"">'+
    '</div>',
  focusConfirm: false,
  preConfirm: () => {
    return [
      document.getElementById('edit-email').value,
      document.getElementById('edit-password').value,
      document.getElemen");
                WriteLiteral(@"tById('edit-id').value
    ]
  }
})

if (formValues) {
    var postdata={
        Id:formValues[2],
        Email:formValues[0],
        Password:formValues[1]
    }
   $.ajax({
                       contentType: 'application/x-www-form-urlencoded',
                       dataType: 'json',
                       type: ""POST"",
                       url: ""EditSenderEmail"",
                       data: postdata,
                       success: function (data) {
                           if (data.isSuccess == true) {
                               swal.fire(
                                   'موفق!',
                                   data.message,
                                   'success'
                               ).then(function (isConfirm) {
                                   location.reload();
                               });
                   
                   
                           }
                           else {
                   
                  ");
                WriteLiteral(@"             swal.fire(
                                   'هشدار!',
                                   data.message,
                                   'warning'
                               ) ;
                   
                           }
                       },
                       error: function (request, status, error) {
                           if(request.responseText != null){
                           alert(request.responseText );
                           }else{
                           alert(error.text);
                           }
                   
                       }
                   
                   });
}

})()
   }
   function DeletSender(id){
       Swal.fire({
  title: 'هشدار',
  text: ""ایا از حذف ارسال کننده مطمئن هستید؟"",
  icon: 'warning',
  showCancelButton: true,
  confirmButtonColor: '#3085d6',
  cancelButtonColor: '#d33',
  confirmButtonText: 'بله',
  cancelButtonText:'خیر'
}).then((result) => {
  if (result.isConfirmed) {
");
                WriteLiteral(@"    var postdata={
        Id:id
    }
   $.ajax({
                       contentType: 'application/x-www-form-urlencoded',
                       dataType: 'json',
                       type: ""POST"",
                       url: ""DeleteSenderEmail"",
                       data: postdata,
                       success: function (data) {
                           if (data.isSuccess == true) {
                               swal.fire(
                                   'موفق!',
                                   data.message,
                                   'success'
                               ).then(function (isConfirm) {
                                   location.reload();
                               });
                   
                   
                           }
                           else {
                   
                               swal.fire(
                                   'هشدار!',
                                   data.message,
            ");
                WriteLiteral(@"                       'warning'
                               ) ;
                   
                           }
                       },
                       error: function (request, status, error) {
                           if(request.responseText != null){
                           alert(request.responseText );
                           }else{
                           alert(error.text);
                           }
                   
                       }
                   
                   });
  }
})
       
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SendersEmailDto> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
