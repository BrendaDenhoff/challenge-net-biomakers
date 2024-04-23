namespace BussinesLayer.Services.Contracts
{
    public interface IOrderArticleService<T>
    {
        T GetOrderArticles();
        T GetOrderArticlesById(int id);
        int GetArticlesStock(int id);
        void CreateOrderArticle(string orderId, string articleId, string numberOfArticle);
        void UpdateOrderArticle(string id, string orderId, string articleId, string numberOfArticle);
        void DeleteOrderArticle(string id);

        T SearchOrderArticle(int includeName, int includeDescription, string search, int orderId);

    }
}
