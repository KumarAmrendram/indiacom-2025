using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace college.Pages;

public class Registrations : PageModel
{
    private readonly ILogger<Registrations> _logger;

    public Registrations(ILogger<Registrations> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
