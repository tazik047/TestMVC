using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestAspMvc.Models
{
    public class User
    {
        [Required(ErrorMessage = "Вы не ввели логин")]
        [MinLength(6, ErrorMessage = "Логин должен быть больше 6 символов")]
        [DisplayName("Логин")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Вы не ввели пароль")]
        [MinLength(6, ErrorMessage = "Пароль должен быть больше 6 символов")]
        [DisplayName("Пароль")]
        public string Password { get; set; }
    }
}