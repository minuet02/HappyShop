using System.Collections.Generic;
using IDAL;
using Model;

/// <summary>
/// BLLOrderStatus 的摘要说明
/// </summary>
namespace BLL
{
    /// <summary>
    /// 实现商品类别的业务逻辑类
    /// </summary>
    public class OrderStatus
    {
        public static readonly IOrderStatus dal = DALFactory.DataAccess.CreateOrderStatus();

        public IList<OrderStatusInfo> GetOrderStatus(int nOrderId)
        {

            if (nOrderId < 0)
                return new List<OrderStatusInfo>();

            return dal.GetOrderStatus(nOrderId);

        }
    }
}