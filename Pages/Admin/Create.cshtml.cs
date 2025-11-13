using System.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OceansideRestaurant.Data;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace OceansideRestaurant.Pages.Admin
{
    [Authorize(Roles = "Admin")]
    public class CreateModel : PageModel
    {

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Menu.Active = true;
            foreach (var file in Request.Form.Files)
            {
                MemoryStream ms = new MemoryStream();
                file.CopyTo(ms);
                Menu.ImageData = ms.ToArray();

                ms.Close();
                ms.Dispose();
            }

            _db.MenuItems.Add(Menu);
            await _db.SaveChangesAsync();
            return RedirectToPage("/Admin/Create");
        }

        private AppDbContext _db;
        [BindProperty]
        public MenuItems Menu { get; set; }
        public CreateModel(AppDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
        }
    }
}
