using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _3_MVCCRUDUsingEFDBFrist.Common
{
    public class DateRangeAttribute : RangeAttribute
    {
        public DateRangeAttribute() : base(typeof(DateTime), "2006/01/01", DateTime.Now.ToLongDateString())
        {

        }

        public override bool IsValid(object value)
        {
            if (value != null && value is DateTime)
            {
                DateTime dateOfBirth = (DateTime)value;
                if (dateOfBirth >= DateTime.Now)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }
    }
}