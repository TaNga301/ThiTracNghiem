using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThiTracNghiem.Areas.Admin.Code
{
    public class SessionHelper
    {
        public static void SetSession(AdminSession session)
        {
            HttpContext.Current.Session["loginSession"] = session;
        }
        public static AdminSession GetSession()
        {
            var session = HttpContext.Current.Session["loginSession"]; 
            if (session == null)
                return null;
            else
            {
                return session as AdminSession;
            }
                

        }

        internal static void SetSession(string user_name)
        {
            throw new NotImplementedException();
        }
    }
}