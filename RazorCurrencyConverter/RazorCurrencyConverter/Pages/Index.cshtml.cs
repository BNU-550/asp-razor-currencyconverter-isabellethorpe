using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace RazorCurrencyConverter.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]

        public string FullName { get; set; }

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        // User must enter their name (not left blank)
        // User feedback when registered successfully 
        public void OnPost()
        {
            if (String.IsNullOrWhiteSpace(FullName))
            {
                ViewData["Message"] = "Name is missing!";
            }
            else
            {
                ViewData["Message"] = FullName + " registered successfully!";
            }
        }
    }
}

