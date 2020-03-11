using System.Threading.Tasks;
using Abc.Domain.Quantity;
using Abc.Facade.Quantity;
using Abc.Pages.Quantity;
using Microsoft.AspNetCore.Mvc;

namespace Abc.Soft.Areas.Quantity.Pages.Measures
{
    public class EditModel : MeasuresPage
    {
        public EditModel(IMeasureRepository r) : base(r)
        {
        }


        public async Task<IActionResult> OnGetAsync(string id)
        {
            var o = await db.Get(id);

            Item = MeasureViewFactory.Create(o);
            return Page();
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync() {

            await db.Update(MeasureViewFactory.Create(Item));
            return RedirectToPage("./Index");
        }

    }
}
