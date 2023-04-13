using model.Framework;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class AdminAcountModel
    {
        private ThiTracNgiem context = null;
        public AdminAcountModel()
        {
            context = new ThiTracNgiem();
        }
        public bool AdminLogin(string user_name, string user_pass)
        {
            object[] sqlParams =
            {
                new SqlParameter("@user_name",user_name),
                new SqlParameter("@user_pass", user_pass),

            };
            var res = context.Database.SqlQuery<bool>("Sp_AdminAccount_Login @user_name, @user_pass", sqlParams).SingleOrDefault();
            return res;
        }
    }
}
