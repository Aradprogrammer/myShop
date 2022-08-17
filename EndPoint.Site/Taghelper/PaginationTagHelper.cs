using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Text;

namespace EndPoint.Site.Taghelper
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    [HtmlTargetElement("tag-Paging")]
    public class PaginationTagHelper : TagHelper
    {
        public int CurrentPage { get; set; } = 1;
        public int RowCount { get; set; }
        public int PageSize { get; set; } = 20;
        public bool Lastbt { get; set; } = false;
        public bool Nextbt { get; set; } = true;
        public bool Firstbt { get; set; } = false;
        public bool Previousbt { get; set; } = true;
        public string Parameters { get; set; } = "";
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            int pages = RowCount / PageSize;
            if (RowCount % PageSize > 0)
            {
                pages++;
            }
            RowCount = pages;
            Parameters = getparametr(Parameters);
            StringBuilder html = new StringBuilder();
            html.AppendLine(" <nav aria-label = \" Page navigation mb-3 \" >");
            html.AppendLine("<ul class = \" pagination justify-content-center \" > ");
            string visibelf = "";
            if (CurrentPage == 1)
                visibelf = "disabled";
            if (Firstbt)
                html.AppendLine("<li class = \" page-item " + visibelf + $" \" > <a class = \" page-link \" href = \" " + Parameters + "Page=1 \" aria-label = \" First \" ><span aria-hidden = \" true \" >اولین</span><span class = \" sr-only \" >اولین</span></a> </li>");
            if (Previousbt)
                html.AppendLine($"<li class = \" page-item " + visibelf + $" \" > <a class = \" page-link \" href = \" {Parameters}Page={CurrentPage - 1} \" aria-label = \" Previous \" ><span aria-hidden = \" true \" >قبلی</span><span class = \" sr-only \" >قبلی</span></a> </li>");

            bool theredotf = false;
            bool theredotd = false;
            bool theredotc = false;
            for (int i = 1; i < RowCount + 1; i++)
            {
                //ok
                if (CurrentPage == i)
                {
                    html.AppendLine($"<li class = \" page-item active \" ><a class = \" page-link \" href = \" {Parameters}Page={CurrentPage} \"> {i.ToString()} </a></li>");
                    continue;
                }
                //ok
                if (i < CurrentPage + 3 && i > CurrentPage - 3 || CurrentPage < 4 && i > RowCount - 3 || CurrentPage > RowCount - 3 && i < 4)
                {
                    html.AppendLine($"<li class = \" page-item \" ><a class = \" page-link \" href = \" {Parameters}Page={i.ToString()} \" >{i.ToString()}</a></li>");
                    continue;
                }


                if (RowCount > 7)
                {

                    //ok
                    if (CurrentPage > 3 && CurrentPage < RowCount - 2 && i < CurrentPage)
                    {
                        if (!theredotf)
                        {
                            html.AppendLine("<li class = \" page-item active \" ><a class = \" page-link \" href= \" # \">...</a></li>");
                            theredotf = true;
                        }
                        continue;
                    }
                    //ok
                    if (CurrentPage < 4 && i < RowCount - 2 || CurrentPage > RowCount - 3 && i < RowCount - 3)
                    {

                        if (!theredotc)
                        {
                            html.AppendLine("<li class= \" page-item active \" ><a class = \" page-link \" href= \" # \">...</a></li>");
                            theredotc = true;
                        }
                        continue;
                    }
                    if (CurrentPage > 3 && CurrentPage < RowCount - 2 && i > CurrentPage)
                    {
                        if (!theredotd)
                        {
                            html.AppendLine("<li class = \" page-item active \" ><a class = \" page-link \" href = \" # \" >...</a></li>");
                            theredotd = true;
                        }
                        continue;
                    }
                }

            }
            string visibel = "";
            if (CurrentPage == RowCount)
                visibel = "disabled";
            if (Nextbt)
                html.AppendLine($"<li class = \" paginate_button page-item next " + visibel + $" \" > <a class = \" page-link \" href = \" {Parameters}Page={CurrentPage + 1} \" aria-label = \" Next \" ><span aria-hidden = \" true \" >بعدی</span><span class=\"sr-only\" > بعدی</span></a> </li>");
            if (Lastbt)
                html.AppendLine($"<li class = \" page-item " + visibel + $" \" > <a class = \" page-link \" href = \" {Parameters}Page={RowCount} \" aria-label=\"Last\"><span aria-hidden=\"true\">اخرین</span> <span class=\"sr-only\">آخرین</span> </a></li>");

            html.AppendLine("</ul> </nav>");
            output.Content.AppendHtml(html.ToString());
        }
        private string getparametr(string parameters)
        {
            var parametrlist = parameters.Split('&');
            string result = "";
            for (int j = 0; j < parametrlist.Length; j++)
            {
                if (!parametrlist[j].Contains("Page=") && !string.IsNullOrEmpty(parametrlist[j]))
                {
                    result += parametrlist[j] + "&";
                }
            }
            parameters = result;
            if (string.IsNullOrEmpty(parameters))
                parameters = "?";
            return parameters;
        }
    }
}
