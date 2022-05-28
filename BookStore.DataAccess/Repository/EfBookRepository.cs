using BookStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DataAccess.Repository
{
    public class EfBookRepository : IBookRepository
    {
        private readonly AppDBContext _appDBContext;

        public EfBookRepository(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }

        public void Add(Book entity)
        {
            _appDBContext.Add(entity);
            _appDBContext.SaveChanges();
        }

        public void Delete(Book entity)
        {
            _appDBContext.Remove(entity);
            _appDBContext.SaveChanges();
        }

        public List<Book> GetAll()
        {
            var books = _appDBContext.Books.ToList();
            return books;
        }

        public Book GetById(int id)
        {
            var book = _appDBContext.Books.FirstOrDefault(x => x.Id == id);
            return book;

        }

        public bool isExist(int id)
        {
            return _appDBContext.Books.Any(x => x.Id == id);
        }

        public void Update(Book entity)
        {
            _appDBContext.Update(entity);
            _appDBContext.SaveChanges();
        }
    }
}
