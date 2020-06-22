using System.Collections.Generic;

namespace BusinessLayer.ModelDTO
{
    public class BookDTO
    {
        public BookDTO()
        {
            Authors = new List<AuthorDTO>();
        }
        public int ID { get; set; }
        public string NameBook { get; set; }
        public CategoryDTO Categories { get; set; }
        public ICollection<AuthorDTO> Authors { get; set; }
    }
}
