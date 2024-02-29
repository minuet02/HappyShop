using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class ItemInfo
    {
        public int txtId;
        public string txtName = string.Empty;
        public string txtProductId = string.Empty;
        public decimal txtAgoraPrice;
        public decimal txtVipPrice;
        public decimal txtMemberPrice;
        public string txtArea = string.Empty;
        public string txtFresh = string.Empty;
        public string txtBrand = string.Empty;
        public int txtClickTime;
        public int txtSale;
        public int txtRemnant;
        public string txtSmallImg = string.Empty;
        public string txtBigImg = string.Empty;
        public string txtCommend;
        public bool txtVis;
        public ItemInfo()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }
        public ItemInfo(int nId, string nName, string nProductId, decimal nAgoraPrice, decimal nVipPrice, decimal nMemberPrice, string nArea, string nFresh, string nBrand, int nClickTime, int nSale, int nRemnant, string nSmallImage, string nBigImage, string nCommend, bool nVis)
        {

            this.txtId = nId;
            this.txtName = nName;
            this.txtProductId = nProductId;
            this.txtAgoraPrice = nAgoraPrice;
            this.txtVipPrice = nVipPrice;
            this.txtMemberPrice = nMemberPrice;
            this.txtArea = nArea;
            this.txtFresh = nFresh;
            this.txtBrand = nBrand;
            this.txtClickTime = nClickTime;
            this.txtSale = nSale;
            this.txtRemnant = nRemnant;
            this.txtSmallImg = nSmallImage;
            this.txtBigImg = nBigImage;
            this.txtCommend = nCommend;
            this.txtVis = nVis;

        }
        public ItemInfo(int nId, string nName, decimal nAgoraPrice, decimal nVipPrice, decimal nMemberPrice, string nSmallImage)
        {

            this.txtId = nId;
            this.txtName = nName;
            this.txtAgoraPrice = nAgoraPrice;
            this.txtVipPrice = nVipPrice;
            this.txtMemberPrice = nMemberPrice;
            this.txtSmallImg = nSmallImage;
        }
        public int ItemId
        {

            get { return txtId; }
            set { txtId = value; }

        }
        public string ProductId
        {

            get { return txtProductId; }
            set { txtProductId = value; }

        }

        public string ItemName
        {

            get { return txtName; }
            set { txtName = value; }

        }
        public decimal AgoraPrice
        {

            get { return txtAgoraPrice; }
            set { txtAgoraPrice = value; }

        }
        public decimal VipPrice
        {

            get { return txtVipPrice; }
            set { txtVipPrice = value; }

        }
        public decimal MemberPrice
        {

            get { return txtMemberPrice; }
            set { txtMemberPrice = value; }

        }
        public string Area
        {

            get { return txtArea; }
            set { txtArea = value; }

        }
        public string Fresh
        {

            get { return txtFresh; }
            set { txtFresh = value; }

        }
        public string Brand
        {

            get { return txtBrand; }
            set { txtBrand = value; }

        }
        public int ClickTime
        {

            get { return txtClickTime; }
            set { txtClickTime = value; }

        }
        public int Sale
        {

            get { return txtSale; }
            set { txtSale = value; }

        }
        public int Remnant
        {

            get { return txtRemnant; }
            set { txtRemnant = value; }

        }
        public string ItemImage
        {

            get { return txtSmallImg; }
            set { txtSmallImg = value; }

        }
        public string ItemBigImage
        {

            get { return txtBigImg; }
            set { txtBigImg = value; }

        }
        public string Comment
        {

            get { return txtCommend; }
            set { txtCommend = value; }

        }
        public bool Vis
        {

            get { return txtVis; }
            set { txtVis = value; }

        }
    }
}
