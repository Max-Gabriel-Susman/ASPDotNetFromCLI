using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace myWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
	
	public string Heading { get; set; } 
	
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
	
        public void OnGet()
        {
	    Heading = "Straight out of the page model ol' son";
        }
    }
}
