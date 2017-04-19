﻿using Architecture.Models.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace Architecture.Services.Product
{
    public interface IWriteProductService
    {
        void AddProduct(string name, string description, double price, int brandId);
        void AddProduct(string name, string description, double price, int brandId, IEnumerable<int> categoriesIds);
        void UpdateProductBase(ProductBase product, int selectedBrandId, IEnumerable<int> selectedCategoriesIds);
    }
}
