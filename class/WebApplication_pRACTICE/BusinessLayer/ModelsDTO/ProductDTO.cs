using System.Collections.Generic;

namespace BusinessLayer.ModelsDTO
{
    public class ProductDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<GroupDTO> Groups { get; set; }
    }
}
