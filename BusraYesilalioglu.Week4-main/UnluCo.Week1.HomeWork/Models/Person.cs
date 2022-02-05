using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using UnluCo.Week1.HomeWork.MyIdentity;

namespace UnluCo.Week1.HomeWork.Models
{
    public class Person : MyIdentityUser
    {
        [Required]
        [Compare("Email", ErrorMessage = "Email giriniz")]
        public string Email { get; set; }


        [Compare("Password", ErrorMessage = "Parola giriniz")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Şifreler uyuşmuyor")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        [Compare("PersonName", ErrorMessage = "PersonName zorunludur")]
        [Required]
        public string PersonName { get; set; }

       



    }
}
