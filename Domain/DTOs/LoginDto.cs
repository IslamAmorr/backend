﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class LoginDto
    {
        public string Login { get; set; } = null!;
        public string Password { get; set; } = null!;

    }
}
