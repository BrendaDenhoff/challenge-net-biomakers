namespace BussinesLayer.Services.Contracts
{
    public interface IArticleService<T>
    {
        T GetArticles();
        void CreateArticle(string name, string description, string stock, string categoryId, string price);
        void UpdateArticle(string name, string description, string stock, string id, string categoryId, string price);
        void DeleteArticle(string id);
        T SearchArticle(int includeName, int includeDescription, string search);
    }
}
