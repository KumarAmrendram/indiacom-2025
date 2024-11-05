using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace college.Pages;

public class CallForPapers : PageModel
{
private readonly ILogger<CallForPapers> _logger;

    public CallForPapers(ILogger<CallForPapers> logger)
        {
        _logger = logger;
        }

        public void OnGet()
        {

        }
        }
