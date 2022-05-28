using AutoMapper;
using BookStore.DataAccess.Repository;
using BookStore.DTO.Request;
using BookStore.DTO.Response;
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
        private readonly IMapper _mapper;

        public BookService(IBookRepository bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        public void Add(AddBookDTO entity)
        {

            
            var result = _mapper.Map<Book>(entity);
            _bookRepository.Add(result);
        }

        public void Delete(int id)
        {
            var book=_bookRepository.GetById(id);
            _bookRepository.Delete(book);
        }

        public List<GetAllBookDTO> GetAll()
        {
            var books=_bookRepository.GetAll();
           var result=  _mapper.Map<List<GetAllBookDTO>>(books);
            return result;
        }

        public GetByIdBookDTO GetById(int id)
        {
            var book = _bookRepository.GetById(id);
            var result = _mapper.Map<GetByIdBookDTO>(book);
            return result;
        }

        public bool isExist(int id)
        {
        return _bookRepository.isExist(id);
        }

        public void Update(UpdateBookDTO entity)
        {
            var book = _mapper.Map<Book>(entity);
            _bookRepository.Update(book);
        }
    }
}
