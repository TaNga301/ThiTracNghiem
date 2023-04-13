using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ThiTracNghiem.Areas.Admin.Models
{
    public class LoginModel
    {
        [Required]
        public string user_name { set; get;}
        public string user_pass { set; get; }
        public bool RememberMe { set; get; }

        //public static implicit operator string(LoginModel v)
        //{
        //    throw new NotImplementedException();
        //}
    }
}