using BookStore.Entities;

namespace BookStore.DataAccess.Repository
{
    public interface IBookRepository: IRepository<Book>
    {
        bool isExist (int id);
    }
}
