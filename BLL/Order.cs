using System.Collections.Generic;
using IDAL;
using Model;

/// <summary>
/// BLLOrder 的摘要说明
/// </summary>
namespace BLL
{
    /// <summary>
    /// 实现商品类别的业务逻辑类
    /// </summary>
    public class Order
    {
        private static readonly IOrder dal = DALFactory.DataAccess.CreateOrder();
        public IList<OrderInfo> GetOrder()
        {

            return dal.GetOrder();

        }
        public IList<OrderInfo> GetOrderAndOrderStatus(string nName) {

            if (string.IsNullOrEmpty(nName))
                return new List<OrderInfo>();
            return dal.GetOrderAndOrderStatus(nName);
        
        }
        public IList<OrderInfo> GetOrderByOneName(string nUserName)
        {
            if (string.IsNullOrEmpty(nUserName))
                return new List<OrderInfo>();

            return dal.GetOrderByOneName(nUserName);

        }
        public IList<OrderInfo> GetOrderByTwoName(string nId, string nUserName)
        {

            if (string.IsNullOrEmpty(nId) && string.IsNullOrEmpty(nUserName))
                return new List<OrderInfo>();
            return dal.GetOrderByTwoName(nId, nUserName);

        }
        public int InsertOrder(OrderInfo nOrder)
        {

            return dal.InsertOrder(nOrder);

        }
        public int UpdateDataOrder(OrderInfo nOrder, string nId)
        {

            if (string.IsNullOrEmpty(nId))
                return 0;
            return dal.UpdateDataOrder(nOrder, nId);

        }
        public int DeleteOrder(string nId)
        {

            if (string.IsNullOrEmpty(nId))
                return 0;
            return dal.DeleteOrder(nId);
        }
        public int UpdateItemTotal(int nNum, string nId)
        {

            if (string.IsNullOrEmpty(nId))
                return 0;
            return dal.UpdateItemTotal(nNum, nId);

        }
    }
}