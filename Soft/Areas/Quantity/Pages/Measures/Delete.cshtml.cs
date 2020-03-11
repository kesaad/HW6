using System.Threading.Tasks;
using Abc.Domain.Quantity;
using Abc.Facade.Quantity;
using Abc.Pages.Quantity;
using Microsoft.AspNetCore.Mvc;

namespace Abc.Soft.Areas.Quantity.Pages.Measures
{
    public class DeleteModel : MeasuresPage
    {
        public DeleteModel(IMeasureRepository r) : base(r)
        {
        }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            var o = await db.Get(id);
            Item = MeasureViewFactory.Create(o);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id) {
            await db.Delete(id);
            return RedirectToPage("./Index");
        }
    }
}
