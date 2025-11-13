using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OceansideRestaurant.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.Hosting;
using Microsoft.AspNetCore.Authorization;


namespace OceansideRestaurant.Admin
{
    [Authorize]
    public class StockModel : PageModel
    {
        [BindProperty]
        public string Search { get; set; }
        [BindProperty]
        public MenuItems Item { get; set; }
        private readonly AppDbContext _db;
        public IList<MenuItems> Menu { get; set; }
        public StockModel(AppDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            Menu = _db.MenuItems.FromSqlRaw("Select * FROM MenuItems").ToList();
        }

        public IActionResult OnPostSearch()
        {
            Menu = _db.MenuItems
                .FromSqlRaw("SELECT * FROM MenuItems WHERE Name LIKE '" + Search + "%'")
                .ToList();
            return Page();
        }

        public async Task<IActionResult> OnPostDeleteAsync(int itemID)
        {
            var item = await _db.MenuItems.FindAsync(itemID);
            item.Active = false;
            _db.Attach(item).State = EntityState.Modified;
            try
            {
                await _db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new Exception($"Item {item.ID} not found!", e);
            }

            return RedirectToPage();

        }
    }
}
