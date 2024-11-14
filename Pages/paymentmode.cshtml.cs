using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace college.Pages;

public class Payment : PageModel
{
    private readonly ILogger<Payment> _logger;

    public Payment(ILogger<Payment> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}