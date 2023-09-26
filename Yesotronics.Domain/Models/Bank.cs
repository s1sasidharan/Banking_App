﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yosotronics.Persistence.Models
{
    public class Bank 
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string HeadOffice { get; set; }

    }
}
