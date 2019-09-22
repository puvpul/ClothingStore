﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClothingStore.Api.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Product> RelatedProducts { get; set; }
    }
}