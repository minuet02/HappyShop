using System.Collections.Generic;
using Model;
using IDAL;

/// <summary>
/// BLLCategory 的摘要说明
/// </summary>
namespace BLL
{
    /// <summary>
    /// 实现商品类别的业务逻辑类
    /// </summary>
    public class Category
    {
        private static readonly ICategory dal = DALFactory.DataAccess.CreateCategory();
        public IList<CategoryInfo> GetCategoryById(string nCategoryId)
        {
            if (string.IsNullOrEmpty(nCategoryId))
                return new List<CategoryInfo>();

            return dal.GetCategoryById(nCategoryId);

        }
        public IList<CategoryInfo> GetCategory()
        {

            return dal.GetCategory();

        }
    }
}