using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class OrderInfo
    {
        public string txtId = string.Empty;
        public string txtUserName = string.Empty;
        public string txtItemName = string.Empty;
        public decimal txtPrice;
        public int txtItemTotal;
        public string txtCarrayMode = string.Empty;
        public string txtUserAdress = string.Empty;
        public int txtPostalcode;
        public string txtUserPhone = string.Empty;
        public Int64 txtTelePhone;
        public bool txtStatus;
        public bool txtIsPay;
        public bool txtIsCheckOrder;
        public int txtIsFeedBack;
        public OrderInfo()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }
        public OrderInfo(string nId, string nUserName, string nItemName, decimal nPrice, int nItemTotal, string nCarryModel, string nUserAdress, int nPostalcode, string nUserPhone, Int64 nTelePhone, bool nStatus)
        {
            this.txtId = nId;
            this.txtUserName = nUserName;
            this.txtItemName = nItemName;
            this.txtPrice = nPrice;
            this.txtItemTotal = nItemTotal;
            this.txtCarrayMode = nCarryModel;
            this.txtUserAdress = nUserAdress;
            this.txtPostalcode = nPostalcode;
            this.txtUserPhone = nUserPhone;
            this.txtTelePhone = nTelePhone;
            this.txtStatus = nStatus;

        }
        public OrderInfo(string nId, string nCarryModel, string nAdress, int nPostalcode, string nPhone, Int64 nPhonetele)
        {
            this.txtId = nId;
            this.txtPostalcode = nPostalcode;
            this.txtUserAdress = nAdress;
            this.txtPostalcode = nPostalcode;
            this.txtUserPhone = nPhone;
            this.txtTelePhone = nPhonetele;

        }
        //会员中心数据
        public OrderInfo(string nId, string nUserName, string nItemName, decimal nPrice,int nTotal,bool nIsPay,bool nIsCheckOrder,int nIsFeedBack)
        {
            this.txtId = nId;
            this.txtUserName = nUserName;
            this.txtItemName = nItemName;
            this.txtPrice = nPrice;
            this.txtItemTotal = nTotal;
            this.txtIsPay = nIsPay;
            this.txtIsCheckOrder = nIsCheckOrder;
            this.txtIsFeedBack = nIsFeedBack;

        }

        public OrderInfo(string nId, string nUserName, string nItemName, decimal nPrice, int nItemTotal)
        {
            this.txtId = nId;
            this.txtUserName = nUserName;
            this.txtItemName = nItemName;
            this.txtPrice = nPrice;
            this.txtItemTotal = nItemTotal;

        }
        public string OrderId
        {

            get { return txtId; }
            set { txtId = value; }

        }
        public string UserName
        {

            get { return txtUserName; }
            set { txtUserName = value; }

        }
        public string ItemName
        {

            get { return txtItemName; }
            set { txtItemName = value; }

        }
        public decimal Price
        {

            get { return txtPrice; }
            set { txtPrice = value; }

        }
        public int ItemTotal
        {

            get { return txtItemTotal; }
            set { txtItemTotal = value; }

        }
        public string CarrayModel
        {

            get { return txtCarrayMode; }
            set { txtCarrayMode = value; }

        }
        public string UserAdress
        {

            get { return txtUserAdress; }
            set { txtUserAdress = value; }

        }
        public int Postalcode
        {

            get { return txtPostalcode; }
            set { txtPostalcode = value; }

        }
        public string UserPhone
        {

            get { return txtUserPhone; }
            set { txtUserPhone = value; }

        }
        public Int64 TelePhone
        {

            get { return txtTelePhone; }
            set { txtTelePhone = value; }

        }
        public bool Status
        {

            get { return txtStatus; }
            set { txtStatus = value; }

        }
        public bool Pay {

            get { return txtIsPay; }
            set { txtIsPay = value; }
        
        }
        public bool CheckOrder {

            get { return txtIsCheckOrder; }
            set { txtIsCheckOrder = value; }
        
        }
        public int FeedBack {

            get { return txtIsFeedBack; }
            set { txtIsFeedBack = value; }
        
        }
    }
}