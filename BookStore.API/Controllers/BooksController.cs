using BookStore.Business.Service;
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
        public IActionResult Add(Book book)
        {
            _bookService.Add(book);
            return Ok("Ekleme Başarılı");
        }
        [HttpPut("{id}")]
        public IActionResult Update(Book book, int id)
        {
            _bookService.Update(book);
            return Ok("Güncelleme Başarılı");
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
           
            return Ok("Silme Başarılı");
        }

    }
}
