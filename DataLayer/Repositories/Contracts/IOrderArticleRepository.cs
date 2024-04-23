using System.Collections.Generic;

namespace DataLayer.Repositories.Contracts
{
    public interface IOrderArticleRepository<T> : IArticleRepository<T>
    {
        IEnumerable<T> GetByIdOrder(int id);

        int GetArticlesStock(int id);
    }
}
