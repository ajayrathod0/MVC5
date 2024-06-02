using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _3_MVCCRUDUsingEFDBFrist.Models
{
    public partial class Product
    {
        public HttpPostedFileBase Image { get; set; }
    }
}