using model.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class AdminModel
    {
        private ThiTracNgiem context = null;
        public AdminModel()
        {
            context = new ThiTracNgiem();
        }
        public List<Admin> listAll()
        {
            var list = context.Database.SqlQuery<Admin>("Quiz_Account_ListAll").ToList();
            return list;
        }
    }
}
