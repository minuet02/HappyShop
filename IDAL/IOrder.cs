using System;
using System.Collections.Generic;
using Model;
/// <summary>
/// IOrder 的摘要说明
/// </summary>

namespace IDAL
{
    public interface IOrder
    {
        IList<OrderInfo> GetOrder();
        IList<OrderInfo> GetOrderByOneName(string nUserName);
        IList<OrderInfo> GetOrderByTwoName(string nId, string nUserName);
        IList<OrderInfo> GetOrderAndOrderStatus(string nName);
        //新加一个订单
        int InsertOrder(OrderInfo nOrder);
        //更新详细资料
        int UpdateDataOrder(OrderInfo nOrder, string nId);
        //更新购买的数量
        int UpdateItemTotal(int nNum, string nId);
        int DeleteOrder(string nId);

    }
}