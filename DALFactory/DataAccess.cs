using System.Reflection;
/// <summary>
/// DataAccess 的摘要说明
/// </summary>
namespace DALFactory
{
    /// <summary>
    /// 此类用于实现抽象工厂模式去创建指定的数据访问层的类的实例
    /// </summary>
    public sealed class DataAccess
    {
        public static readonly string txtPath = "SQLServer";

        private DataAccess() { }

        public static IDAL.IItem CreateItem()
        {

            string className = txtPath + ".Item";
            return (IDAL.IItem)Assembly.Load(txtPath).CreateInstance(className);

        }
        public static IDAL.IProduct CreateProduct()
        {

            string className = txtPath + ".Product";
            return (IDAL.IProduct)Assembly.Load(txtPath).CreateInstance(className);

        }
        public static IDAL.ICategory CreateCategory()
        {

            string className = txtPath + ".Category";
            return (IDAL.ICategory)Assembly.Load(txtPath).CreateInstance(className);

        }
        public static IDAL.IOrder CreateOrder()
        {

            string className = txtPath + ".Order";
            return (IDAL.IOrder)Assembly.Load(txtPath).CreateInstance(className);

        }
        public static IDAL.IOrderStatus CreateOrderStatus()
        {

            string className = txtPath + ".OrderStatus";
            return (IDAL.IOrderStatus)Assembly.Load(txtPath).CreateInstance(className);

        }
        public static IDAL.IUser CreateUser()
        {

            string className = txtPath + ".User";
            return (IDAL.IUser)Assembly.Load(txtPath).CreateInstance(className);

        }
        public static IDAL.IVote CreateVote()
        {

            string className = txtPath + ".Vote";
            return (IDAL.IVote)Assembly.Load(txtPath).CreateInstance(className);

        }
        public static IDAL.IUserMess CreateUserMess() {

            string className = txtPath + ".UserMess";
            return (IDAL.IUserMess)Assembly.Load(txtPath).CreateInstance(className);
        
        }
    }
}