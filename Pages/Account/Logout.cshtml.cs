using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OceansideRestaurant.Data;

namespace OceansideRestaurant.Pages.Account
{
    public class LogoutModel : PageModel
    {
        // Comment out Identity dependencies
        // private readonly SignInManager<ApplicationUser> _signInManager;

        public LogoutModel()
        {
            // Empty constructor
        }

        /*
        public LogoutModel(SignInManager<ApplicationUser> signInManager)
        {
            _signInManager = signInManager;
        }

        public async Task<IActionResult> OnPost()
        {
            await _signInManager.SignOutAsync();
            return RedirectToPage("/Index");
        }
    }
}
