using System.ComponentModel.DataAnnotations;

namespace Abc.Facade.Quantity
{
    public abstract class NamedView : UniqueEntityView
    {
        public string Code { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
