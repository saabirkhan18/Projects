using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{

    public class UserDetails
    {
        public Int64 id { set; get; }
        public string username { set; get; }
        public string full_name { set; get; }
        public string email { set; get; }
        public string mobile { set; get; }
        public string token { set; get; }
        public string ref_token { set; get; }
        public string message { set; get; }
    }
}
