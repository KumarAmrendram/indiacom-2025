using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace college.Pages;

public class Downloads : PageModel
{
    private readonly ILogger<Downloads> _logger;

    public Downloads(ILogger<Downloads> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}