using asp_store_bugeto.Domain.Entities.Users;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp_store_bugeto.Common
{
    public class EmailTextAnalyzer
    {
        public static string Analyz(string EmailBody, RequestAnalyzDto userinfo, string Link, string content = "")
        {
            var result = EmailBody;
            if (result.Contains("$Link"))
                result = result.Replace("$Link", Link);
            if (result.Contains("$Email"))
                result = result.Replace("$Email", userinfo.Email);
            if (userinfo.FullName != null)
            {
                if (result.Contains("$UserName"))
                    result = result.Replace("$UserName", userinfo.FullName);
            }
            if (string.IsNullOrEmpty(content))
                if (result.Contains("$Content"))
                    result = result.Replace("$Content", content);
            return result;


        }






        //public static string EmailAnalyz(string EmailBody, User user, string Link = "")
        //{
        //    var result = EmailBody;
        //    if (result.Contains("$Link"))
        //        result = result.Replace("$Link", Link);
        //    if (result.Contains("$Email"))
        //        result = result.Replace("$Email", user.Email);
        //    if (user != null)
        //    {
        //        if (result.Contains("$UserName"))
        //            result = result.Replace("$UserName", user.FullName);
        //    }
        //    return result;
        //}
        //public static string EmailAnalyz(string EmailBody, string useremail, string Link)
        //{
        //    var result = EmailBody;
        //    if (result.Contains("$Email"))
        //        result = result.Replace("$Email", useremail);
        //    if (result.Contains("$Link"))
        //        result = result.Replace("$Link", Link);
        //    return result;
        //}
        //public static string EmailAnalyznolink(string EmailBody, User user, string body)
        //{
        //    var result = EmailBody;
        //    if (result.Contains("$Email"))
        //        result = result.Replace("$Email", user.Email);
        //    if (result.Contains("$content"))
        //        result = result.Replace("$content", body);
        //    if (user != null)
        //    {
        //        if (result.Contains("$UserName"))
        //            result = result.Replace("$UserName", user.FullName);
        //    }
        //    return result;
        //}

    }

    public class RequestAnalyzDto
    {
        public string Email { get; set; }
        public string? FullName { get; set; }

    }
}
