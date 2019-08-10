using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CRUDproject.Model.Common
{
    public static class Enums
    {
        public enum SexStatus
        {
            [Description("男")]
            Man = 0,
            [Description("女")]
            Woman = 1
        }
    }
   
}
