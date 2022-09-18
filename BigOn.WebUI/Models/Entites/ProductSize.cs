using BigOn.WebUI.AppCode.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace BigOn.WebUI.Models.Entites
{
    public class ProductSize: BaseEntity
    {
        [Required]
        public string Name { get; set; }
        public string SmallName { get; set; }


    }
}
