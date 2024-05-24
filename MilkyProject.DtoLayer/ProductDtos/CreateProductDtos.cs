﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkyProject.DtoLayer.ProductDtos
{
    public class CreateProductDtos
    {
        public string? Name { get; set; }
        public decimal OldPrice { get; set; }
        public decimal NewPrice { get; set; }
        public string? ImageUrl { get; set; }
        public bool Status { get; set; }
        public int? CategoryId { get; set; }
    }
}
