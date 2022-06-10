using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SampleIdentity.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Username is required")]
        public string Username { set; get; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(50, MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { set; get; }
    }
    public static class LoggedInuser //for session purpose
    {
        public static List<LoginModel> loginModels = new List<LoginModel>();
    }
}
