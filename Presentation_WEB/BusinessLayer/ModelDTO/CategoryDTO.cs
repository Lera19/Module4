using System.Collections.Generic;

namespace BusinessLayer.ModelDTO
{
    public class CategoryDTO
    {
        public int ID { get; set; }
        public string NameCategory { get; set; }
        public ICollection<BookDTO> Books { get; set; }
    }
}