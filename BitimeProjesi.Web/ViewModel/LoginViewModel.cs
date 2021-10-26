using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BitimeProjesi.Web.ViewModel
{
    public class LoginViewModel
    {
        [DisplayName("Kullanıcı Adı"),Required(ErrorMessage ="Boş Geçilemez")]
        public string Username { get; set; }
        [DisplayName("Kullanıcı Adı"), Required(ErrorMessage = "Boş Geçilemez"), DataType(DataType.Password)]
        public string Password { get; set; }
    }
}