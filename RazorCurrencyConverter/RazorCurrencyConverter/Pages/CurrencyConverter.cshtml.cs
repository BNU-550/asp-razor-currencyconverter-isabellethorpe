using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace RazorCurrencyConverter.Pages
{
    public class CurrencyConverterModel : PageModel
    {
        public const double USD_TO_JPY = 113.40;

        [BindProperty]
        public double InputUSD { get; set; }
        [BindProperty]
        public double OutputJPY { get; set; }

        // Stops user from entering negative numeric 
        // User feedback when currency conversion successful 
        public void OnPost()
        {
            if (double.IsNegative(InputUSD))
            {
                ViewData["Message"] = "Please enter a number above 0";
            }
            else
            {
                OutputJPY = InputUSD * USD_TO_JPY;
                ViewData["Message"] = "Your currency has been converted!";
            }
        }
    }
}
    