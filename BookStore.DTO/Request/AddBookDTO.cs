using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DTO.Request
{
    public class AddBookDTO
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Author { get; set; }
    }
}
