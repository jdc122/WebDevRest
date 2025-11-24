using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Identity;
using OceansideRestaurant.Data;

namespace OceansideRestaurant.Pages.Account
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public LoginUser Input { get; set; }

        //  private readonly SignInManager<ApplicationUser> _signInManager;

        public LoginModel()
        {
            // Empty constructor
        }

        /*  public LoginModel(SignInManager<ApplicationUser> signInManager)
          {
              _signInManager = signInManager;
          }
        */
        public async Task<IActionResult> OnPOstAsync()
        {
            return RedirectToPage("/Index");
        }
    }
}
