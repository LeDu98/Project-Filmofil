﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Filmofil.Models.Users
{
    public class LoginViewModel
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }

        [Required]
        public string FirstNameReg { get; set; }
        [Required]
        public string LastNameReg { get; set; }
        [Required]
        public string UsernameReg { get; set; }
        [Required]
        public string EmailReg { get; set; }
        [Required]
        public string PasswordReg { get; set; }
        [Compare("Password")]
        [Required]
        public string PasswordCheckReg { get; set; }
    }
}
