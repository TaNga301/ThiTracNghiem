using model.Framework;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
        public class ListAdminAccountModel
        {
            private ThiTracNgiem context = null;
            public ListAdminAccountModel()
            {
                context = new ThiTracNgiem();
            }
        public List<AdminAccount> listAll()
        {
            var list = context.Database.SqlQuery<AdminAccount>("Sp_AdminAccount_ListAll").ToList();
            return list;
        }
        }
    
}
