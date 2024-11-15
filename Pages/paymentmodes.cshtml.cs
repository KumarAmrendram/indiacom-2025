using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace college.Pages;

public class PaymentModes : PageModel
{
    private readonly ILogger<PaymentModes> _logger;

    public PaymentModes(ILogger<PaymentModes> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}
