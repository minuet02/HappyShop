using System;
using System.Collections.Generic;
using Model;

/// <summary>
/// Item 的摘要说明
/// </summary>
namespace IDAL
{
    public interface IItem
    {
        string GetTitle(int nItemId);
        //获得点击率比较高的商品
        IList<ItemInfo> GetItemByClickTime();

        //获得最新的商品
        IList<ItemInfo> GetItemByNew();

        //获得推荐的商品
        IList<ItemInfo> GetItemByCommend();

        //通过商品的ID获得商品的详细资料
        IList<ItemInfo> GetItemById(int nItemId);

        //通过目录的Id来获得该目录下的所有商品
        IList<ItemInfo> GetItemByProduct(string nProductId);

        //通过类别的Id来获得该类别下的前20项商品
        IList<ItemInfo> GetItemByCategory(string nCategoryId);

        //通过类别的Id来获得该类别下的所有商品
        IList<ItemInfo> GetItemByAllCategory(string nCategoryId);

        IList<ItemInfo> SearchItemByCategoryId(string nCaegory, string nItemName);
        IList<ItemInfo> SearchItemByCategoryIdByItem(string nCaegory, string nProduct, decimal nPriceStart, decimal nPriceEnd, string nItemName);

        //通过类别的ID来获取它的名称
        string GetCategoryName(string nCategoryId);

        //通过目录的ID来获得类别的名称
        string GetCategoryNameByProductId(string nProductId);

        //通过项目的ID来获得类别的名称
        string GetCategoryNameByItemId(int nItemId);

        int UpdateClick(int nId);

    }
}