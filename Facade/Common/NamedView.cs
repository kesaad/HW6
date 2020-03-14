using System.ComponentModel.DataAnnotations;
using Abc.Facade.Quantity;

namespace Abc.Facade.Common
{
    public abstract class NamedView : UniqueEntityView
    {
        public string Code { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
