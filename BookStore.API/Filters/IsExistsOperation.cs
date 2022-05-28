using BookStore.Business.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace BookStore.API.Filters
{
    public class IsExistsOperation:IAsyncActionFilter
    {
        private readonly IBookService _bookService;

        public IsExistsOperation(IBookService bookService)
        {
            _bookService = bookService;
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if (!context.ActionArguments.ContainsKey("id"))
            {
                context.Result = new BadRequestObjectResult("Id değeri zorunludur.");
            }
            else
            {
                var id=(int)context.ActionArguments["id"];
                if (!_bookService.isExist(id))
                {
                    context.Result= new NotFoundObjectResult("Kitap bulunamadı.");
                }
                else
                {
                    next.Invoke();
                }

            }
        }
    }
}
