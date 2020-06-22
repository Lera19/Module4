using System.Collections.Generic;

namespace BusinessLayer.ModelDTO
{
    public class AuthorDTO
    {
        public AuthorDTO()
        {
            Books = new List<BookDTO>();
        }
        public int ID { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public ICollection<BookDTO> Books { get; set; }
    }
}