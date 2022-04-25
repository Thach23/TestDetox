﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Outsourcing.Data.Models;

namespace Labixa.ViewModels
{
    public class ShopFormModel
    {
        public IEnumerable<Blog> blogsRelated { get; set; }

        public List<WebsiteAttribute> websiteAttributes { get; set; }

        public IEnumerable<ProductCategory> productCategories { get; set; }

        public IEnumerable<Blog> blogsHelper { get; set; }

        public IEnumerable<Product> hotProducts { get; set; }

        
    }
}