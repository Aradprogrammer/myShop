using EndPoint.Site.Utilities;
using Microsoft.AspNetCore.Http;
using System;

namespace EndPoint.Site.Utilities
{
    public class DefauletMethodCoockies
    {
        CookiesManeger coocki =new CookiesManeger();
        public string TakeBrowserId(HttpContext context)
        {
            if (coocki.Contains(context, "BrowserId"))
            {
                return coocki.GetValue(context, "BrowserId");
            }
            else
            {
                Guid guid = Guid.NewGuid();
                coocki.Add(context, "BrowserId", guid.ToString());
                return guid.ToString();
            }
        }
    }
}
