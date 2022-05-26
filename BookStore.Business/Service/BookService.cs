using BookStore.DataAccess.Repository;
using BookStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Business.Service
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public void Add(Book entity)
        {
            _bookRepository.Add(entity);
        }

        public void Delete(Book entity)
        {
            _bookRepository.Delete(entity);
        }

        public List<Book> GetAll()
        {
            var books=_bookRepository.GetAll();
            return books;
        }

        public Book GetById(int id)
        {
            var book = _bookRepository.GetById(id);
            return book;
        }

        public void Update(Book entity)
        {
            _bookRepository.Update(entity);
        }
    }
}
