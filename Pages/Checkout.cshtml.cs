using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OceansideRestaurant.Data;
using Stripe;

namespace OceansideRestaurant.Pages
{
    public class CheckoutModel : PageModel
    {
        // Comment out dependencies temporarily
        // private readonly AppDbContext _db;
        // private readonly UserManager<ApplicationUser> _UserManager;
        public IList<CheckoutItems> Items { get; private set; }
        public OrderHistory Order = new OrderHistory();

        public decimal Total = 0;
        public long AmountPayable = 0;

        public CheckoutModel()
        {
            // Empty constructor - no dependencies injected
            Items = new List<CheckoutItems>(); // Initialize to avoid null reference
        }

        /*
        public CheckoutModel(AppDbContext db, UserManager<ApplicationUser> UserManager)
        {
            _db = db;
            _UserManager = UserManager;
        }
        */

        public async Task OnGetAsync()
        {
            // Temporarily disabled - requires database and user authentication
            /*
            var user = await _UserManager.GetUserAsync(User);
            CheckoutCustomer customer = await _db.CheckoutCustomers.FindAsync(user.Email);

            Items = _db.CheckoutItems.FromSqlRaw(
                "SELECT MenuItems.ID, MenuItems.Price, " +
                "MenuItems.Name, " +
                "BasketItems.BasketID, BasketItems.Quantity " +
                "FROM Stationaries INNER JOIN BasketItems " +
                "ON MenuItems.ID = BasketItems.StockID " +
                "WHERE BasketID = {0}", customer.BasketID
                ).ToList();
            Total = 0;
            foreach (var item in Items)
            {
                Total += (item.Quantity * item.Price);
            }
            AmountPayable = (long)(Total * 100);
            */

            // Temporary placeholder - remove when database is connected
            await Task.CompletedTask;
        }

        public async Task Process()
        {
            // Temporarily disabled - requires database
            /*
            var currentOrder = _db.OrderHistories
                .FromSqlRaw("SELECT * From OrderHistories")
                .OrderByDescending(b => b.OrderNo)
                .FirstOrDefault();

            if (currentOrder == null)
            {
                Order.OrderNo = 1;
            }
            else
            {
                Order.OrderNo = currentOrder.OrderNo + 1;
            }

            var user = await _UserManager.GetUserAsync(User);
            Order.Email = user.Email;
            _db.OrderHistories.Add(Order);

            CheckoutCustomer customer = await _db
                .CheckoutCustomers
                .FindAsync(user.Email);

            var basketItems = _db.BasketItems
                .FromSqlRaw("SELECT * From *BasketItems " + "Where BasketID = {0}", customer.BasketID)
                .ToList();

            foreach(var item in basketItems)
            {
                Data.OrderItem oi = new Data.OrderItem
                {
                    OrderNo = Order.OrderNo,
                    StockID = item.StockID,
                    Quantity = item.Quantity
                };
                _db.OrderItems.Add(oi);
                _db.BasketItems.Remove(item);
            }

            await _db.SaveChangesAsync();

            Process().Wait(); 
            */

            // Temporary placeholder - remove when database is connected
            await Task.CompletedTask;
        }

        public IActionResult OnPostCharge(
            string stripeEmail,
            string stripeToken,
            long amount)
        {
            // Temporarily disabled - Stripe functionality
            /*
            var customers = new CustomerService();
            var charges = new ChargeService();

            var customer = customers.Create(new CustomerCreateOptions
            {
                Email = stripeEmail,
                Source = stripeToken
            });

            var charge = charges.Create(new ChargeCreateOptions
            {
                Amount = amount,
                Description = "CO5227 Restaurant Charge",
                Currency = "gbp",
                Customer = customer.Id
            });
            */
            return RedirectToPage("/Index");
        }
    }
}