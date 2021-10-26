using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BitimeProjesi.Web.ViewModel
{
    public class RegisterViewModel
    {
        public string Username  { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        [Compare("Password", ErrorMessage ="Şifreler Uyuşmuyor")]
        public string RePassword { get; set; }
    }
}