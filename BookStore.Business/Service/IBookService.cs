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
    public interface IBookService
    {
        void Add(AddBookDTO entity);
        void Update(UpdateBookDTO entity);
        void Delete(int id);
        GetByIdBookDTO GetById(int id);
        List<GetAllBookDTO> GetAll();

        bool isExist (int id);
    }
}
