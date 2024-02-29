using System.Collections.Generic;
using IDAL;
using Model;

/// <summary>
/// BLLProduct 的摘要说明
/// </summary>
namespace BLL
{
    /// <summary>
    /// 该实现针对类别信息的聚合数据缓存依赖
    /// </summary>
    public class Product
    {
        private static readonly IProduct dal = DALFactory.DataAccess.CreateProduct();
        public IList<ProductInfo> GetProduct()
        {

            return dal.GetProduct();

        }
        public IList<ProductInfo> GetProductById(string nProductId)
        {

            if (string.IsNullOrEmpty(nProductId))
                return new List<ProductInfo>();

            return dal.GetProductById(nProductId);

        }
        public IList<ProductInfo> GetProductByCategory(string nCategoryId)
        {

            if (string.IsNullOrEmpty(nCategoryId))
                return new List<ProductInfo>();

            return dal.GetProductByCategory(nCategoryId);

        }
    }
}