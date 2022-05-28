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
    public interface ICategoryService
    {
        void Add(AddCategoryDTO entity);
        void Update(UpdateCategoryDTO entity);
        void Delete(int id);
        GetByIdCategoryDTO GetById(int id);
        List<GetAllCategoryDTO> GetAll();
    }
}
