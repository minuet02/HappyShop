using System;
using System.Collections.Generic;
using Model;
//该源码首发自www.51aspx.com(５１ａsｐｘ．ｃｏｍ)

/// <summary>
/// IOrderStatus 的摘要说明
/// </summary>
namespace IDAL
{
    public interface IOrderStatus
    {
        IList<OrderStatusInfo> GetOrderStatus(int nOrderId);
    }
}