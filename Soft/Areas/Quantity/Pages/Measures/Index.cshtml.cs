﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Abc.Domain.Quantity;
using Abc.Facade.Quantity;
using Abc.Pages.Quantity;

namespace Abc.Soft.Areas.Quantity.Pages.Measures
{
    public class IndexModel : MeasuresPage
    {

        public IndexModel(IMeasureRepository r) : base(r)
    {
    }

        public async Task OnGetAsync(string sortOrder,
            string currentFilter, string searchString, int? pageIndex) {
            sortOrder = string.IsNullOrEmpty(sortOrder) ? "Name" : sortOrder;
            CurrentSort = sortOrder;
            NameSort = sortOrder == "Name" ? "Name_desc" : "Name";
            IdSort = sortOrder == "Id" ? "Id_desc" : "Id";
            CodeSort = sortOrder == "Code" ? "Code_desc" : "Code";
            DefinitionSort = sortOrder == "Definition" ? "Definition_desc" : "Definition";
            ValidFromSort = sortOrder == "ValidFrom" ? "ValidFrom_desc" : "ValidFrom";
            ValidToSort = sortOrder == "ValidTo" ? "ValidTo_desc" : "ValidTo";

            if (searchString != null)
            {
                pageIndex = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            CurrentFilter = searchString;

            db.SortOrder = sortOrder;
            SearchString = CurrentFilter;
            db.SearchString = SearchString;
            db.PageIndex = pageIndex ?? 1;
            PageIndex = db.PageIndex;
            var l = await db.Get();
           Items = new List<MeasureView>();
           foreach (var e in l) Items.Add(MeasureViewFactory.Create(e));
           HasNextPage = db.HasNextPage;
           HasPreviousPage = db.HasPreviousPage;
        }

        public string CurrentSort { get; set; }
        public string ValidFromSort { get; set; }
        public string NameSort { get; set; }
        public string IdSort { get; set; }
        public string CodeSort { get; set; }
        public string DefinitionSort { get; set; }
        public string ValidToSort { get; set; }

        public bool HasPreviousPage { get; set; }
        public bool HasNextPage { get; set; }
        public int PageIndex { get; set; }

        public string SearchString { get; set; }
        public string CurrentFilter { get; set; }

    }
}
