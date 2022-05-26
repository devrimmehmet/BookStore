using BookStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Business.Service
{
    public interface IBookService
    {
        void Add(Book entity);
        void Update(Book entity);
        void Delete(Book entity);
        Book GetById(int id);
        List<Book> GetAll();
    }
}
