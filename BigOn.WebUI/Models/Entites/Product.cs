using BigOn.WebUI.AppCode.Infrastructure;

namespace BigOn.WebUI.Models.Entites
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public decimal Rate { get; set; }
        public decimal Price { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }



    }
}
