﻿using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.DTOs
{
    public class BookOnLoanDto
    {
        public int BookId { get; set; }
       
        public int LendId { get; set; }
    }
}
