using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace college.Pages;

public class Reviewprocess : PageModel
{
    private readonly ILogger<Reviewprocess> _logger;

    public Reviewprocess(ILogger<Reviewprocess> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
