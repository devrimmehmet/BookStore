using Microsoft.AspNetCore.Mvc;

namespace BookStore.API.Filters
{
    public class IsExistsAttribute : TypeFilterAttribute
    {
        public IsExistsAttribute() : base(typeof(IsExistsOperation))
        {

        }
    }
}
