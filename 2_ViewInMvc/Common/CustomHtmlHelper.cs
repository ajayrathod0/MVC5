using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace _2_ViewInMvc.Common
{
    public static class CustomHtmlHelper
    {
        public static MvcHtmlString Button(this HtmlHelper helper, string type, string value)
        {
            TagBuilder tb = new TagBuilder("Input");
            tb.Attributes.Add("type", type);
            tb.Attributes.Add("value", value);

            return new MvcHtmlString(tb.ToString());
        }
    }
}