namespace BussinesLayer.Services.Contracts
{
    public interface IOrderService<T>
    {
        T GetOrders();
        void CreateOrder();
        void UpdateOrder();
        void DeleteOrder(string id);
        T SearchOrder(int includeOrderNumber, int includeDate, string search);
    }
}
