using BookStore.API.Filters;
using BookStore.Business.Service;
using BookStore.DTO.Request;
using BookStore.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet("{id}")]
        [IsExists]
        public IActionResult GetById(int id)
        {
            var book = _bookService.GetById(id);
            return Ok(book);
            

        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var book = _bookService.GetAll();
            return Ok(book);

        }
        [HttpPost]
        public IActionResult Add(AddBookDTO book)
        {
            _bookService.Add(book);
            return Ok("Ekleme Başarılı");
        }
        [HttpPut]
        public IActionResult Update(UpdateBookDTO book)
        {
            _bookService.Update(book);
            return Ok("Güncelleme Başarılı");
        }
        [HttpDelete]
        [IsExists]
        public IActionResult Delete(int id)
        {
           _bookService.Delete(id);
            return Ok("Silme Başarılı");
        }

    }
}
