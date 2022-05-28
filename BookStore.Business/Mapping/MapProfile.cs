using AutoMapper;
using BookStore.DTO.Request;
using BookStore.DTO.Response;
using BookStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Business.Mapping
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<Book, GetByIdBookDTO>();
            CreateMap<Book, GetAllBookDTO>();
            CreateMap<Category, GetByIdCategoryDTO>();
            CreateMap<Category, GetAllCategoryDTO>();
            CreateMap<AddBookDTO, Book>();
            CreateMap<AddCategoryDTO, Category>();
            CreateMap<UpdateBookDTO, Book>();
            CreateMap<UpdateCategoryDTO, Category>();
        }
    }
}
