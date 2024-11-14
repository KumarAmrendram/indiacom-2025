using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace college.Pages;

public class Memberlogin : PageModel
{
    private readonly ILogger<Memberlogin> _logger;

    public Memberlogin(ILogger<Memberlogin> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
