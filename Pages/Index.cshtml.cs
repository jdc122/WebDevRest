using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace OceansideRestaurant.Pages
{
    public class IndexModel : PageModel
    {
        public int[] X = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
        public void OnGet()
        {

        }

        public IActionResult OnPostIncrement()
        {
            int[] Z = { 2, 4, 6, 8, 10, 12, 14 };
            X = Z;
            return Page();
        }
    }
}
