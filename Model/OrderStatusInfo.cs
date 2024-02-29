using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class OrderStatusInfo
    {
        public int txtId;
        public int txtOrderId;
        public bool txtPayment;
        public bool txtCheckItem;
        public int txtFeedback;

        public OrderStatusInfo()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }
        public OrderStatusInfo(int nId, int nOrderId, bool nPayment, bool nCheckItem, int nFeedback)
        {

            this.txtId = nId;
            this.txtOrderId = nOrderId;
            this.txtPayment = nPayment;
            this.txtCheckItem = nCheckItem;
            this.txtFeedback = nFeedback;

        }
        public int OrderStatusId
        {

            get { return txtId; }
            set { txtId = value; }

        }
        public int OrderId
        {

            get { return txtOrderId; }
            set { txtOrderId = value; }

        }
        public bool PayMent
        {

            get { return txtPayment; }
            set { txtPayment = value; }

        }
        public bool CheckItem
        {

            get { return txtCheckItem; }
            set { txtCheckItem = value; }

        }
        public int Feedback
        {

            get { return txtFeedback; }
            set { txtFeedback = value; }

        }
    }
}