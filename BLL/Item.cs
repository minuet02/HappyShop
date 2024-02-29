using System.Collections.Generic;
using IDAL;
using Model;

/// <summary>
/// BLLItem 的摘要说明
/// </summary>
namespace BLL
{
    /// <summary>
    /// 实现商品类别的业务逻辑类
    /// </summary>
    public class Item
    {
        private static readonly IItem dal = DALFactory.DataAccess.CreateItem();

        public string GetTitle(int nItemId){

            if (nItemId < 0)
            {

                return null;

            }
            else {


                return dal.GetTitle(nItemId);
            }
        
        }
        //获得点击率比较高的商品
        public IList<ItemInfo> GetItemByClickTime()
        {

            return dal.GetItemByClickTime();

        }
        //获得最新的商品
        public IList<ItemInfo> GetItemByNew()
        {

            return dal.GetItemByNew();

        }

        //获得推荐的商品
        public IList<ItemInfo> GetItemByCommend()
        {

            return dal.GetItemByCommend();

        }

        //通过商品的ID获得商品的详细资料
        public IList<ItemInfo> GetItemById(int nItemId)
        {

            if (nItemId < 0)
                return new List<ItemInfo>();

            return dal.GetItemById(nItemId);

        }

        //通过目录的Id来获得该目录下的所有商品
        public IList<ItemInfo> GetItemByProduct(string nProductId)
        {
            if (string.IsNullOrEmpty(nProductId))
                return new List<ItemInfo>();

            return dal.GetItemByProduct(nProductId);

        }

        //通过类别的Id来获得该类别下的前20项商品
        public IList<ItemInfo> GetItemByCategory(string nCategoryId)
        {

            if (string.IsNullOrEmpty(nCategoryId))
                return new List<ItemInfo>();

            return dal.GetItemByCategory(nCategoryId);

        }
        //通过类别的Id来获得该类别下的所有商品
        public IList<ItemInfo> GetItemByAllCategory(string nCategoryId)
        {

            if (string.IsNullOrEmpty(nCategoryId))
                return new List<ItemInfo>();

            return dal.GetItemByAllCategory(nCategoryId);

        }
        public IList<ItemInfo> SearchItemByCategoryId(string nCaegory, string nItemName)
        {

            if (string.IsNullOrEmpty(nCaegory) && string.IsNullOrEmpty(nItemName))
                return new List<ItemInfo>();
            return dal.SearchItemByCategoryId(nCaegory, nItemName);

        }
        public IList<ItemInfo> SearchItemByCategoryIdByItem(string nCaegory, string nProduct, decimal nPriceStart, decimal nPriceEnd, string nItemName)
        {


            return dal.SearchItemByCategoryIdByItem(nCaegory, nProduct, nPriceStart, nPriceEnd, nItemName);

        }
        public string GetCategoryName(string nCategoryId)
        {

            if (string.IsNullOrEmpty(nCategoryId))
                return null;
            return dal.GetCategoryName(nCategoryId);

        }
        public string GetCategoryNameByProductId(string nProductId)
        {

            if (string.IsNullOrEmpty(nProductId))
                return null;
            return dal.GetCategoryNameByProductId(nProductId);

        }
        public string GetCategoryNameByItemId(int nItemId)
        {

            if (nItemId < 0)
                return null;
            return dal.GetCategoryNameByItemId(nItemId);

        }
        public int UpdateClick(int nId) {

            if (nId < 0)
            {

                return 0;

            }
            else {

                return dal.UpdateClick(nId);
            
            }
                
        }

    }
}