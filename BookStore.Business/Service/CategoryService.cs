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
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public void Add(AddCategoryDTO entity)
        {
            var cagetory = _mapper.Map<Category>(entity);
            _categoryRepository.Add(cagetory);
        }

        public void Delete(int id)
        {
            var category = _categoryRepository.GetById(id);
            _categoryRepository.Delete(category);
        }

        public void Update(UpdateCategoryDTO entity)
        {
            var result = _mapper.Map<Category>(entity);
            
            _categoryRepository.Update(result);
        }

       public List<GetAllCategoryDTO> GetAll()
        {
            var category = _categoryRepository.GetAll();
            var result = _mapper.Map<List<GetAllCategoryDTO>>(category);
            return result;
        }

       public GetByIdCategoryDTO GetById(int id)
        {
            var category = _categoryRepository.GetById(id);
            var result = _mapper.Map<GetByIdCategoryDTO>(category);
            return result;
        }
    }
}
