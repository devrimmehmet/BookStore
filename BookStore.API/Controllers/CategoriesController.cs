using BookStore.Business.Service;
using BookStore.DTO.Request;
using BookStore.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var category= _categoryService.GetById(id);
            return Ok(category);
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var categories = _categoryService.GetAll();
            return Ok(categories);
        }
        [HttpPut]
        public IActionResult Update(UpdateCategoryDTO category)
        {
            _categoryService.Update(category);
            return Ok();
        }
        [HttpPost]
        public IActionResult Add(AddCategoryDTO category)
        {
            _categoryService.Add(category);
            return Ok("Kategori Ekleme Başarılı");
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _categoryService.Delete(id);
            return Ok();
        }
    }
}
