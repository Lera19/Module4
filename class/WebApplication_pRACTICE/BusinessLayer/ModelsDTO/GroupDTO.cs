using System.Collections.Generic;

namespace BusinessLayer.ModelsDTO
{
    public class GroupDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<ProductDTO> Products { get; set; }
    }
}
