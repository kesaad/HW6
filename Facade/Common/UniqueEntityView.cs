using System.ComponentModel.DataAnnotations;

namespace Abc.Facade.Quantity
{
    public abstract class UniqueEntityView : PeriodView
    {
        [Required]
        public string Id { get; set; }
    }
}
