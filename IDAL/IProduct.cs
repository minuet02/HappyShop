using System;
using System.Collections.Generic;
using Model;

/// <summary>
/// IProduct 的摘要说明
/// </summary>
namespace IDAL
{
    public interface IProduct
    {
        IList<ProductInfo> GetProduct();
        IList<ProductInfo> GetProductById(string nProductId);
        IList<ProductInfo> GetProductByCategory(string nCategoryId);
    }
}