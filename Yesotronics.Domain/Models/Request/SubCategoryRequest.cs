﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yesotronics.Domain.Models.Request
{
    public class SubCategoryRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public long CategoryId { get; set; }
    }
}
