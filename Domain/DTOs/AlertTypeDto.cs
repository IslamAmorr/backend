﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class AlertTypeDto
    {
        public int Id { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}
