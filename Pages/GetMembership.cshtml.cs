using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace college.Pages;

public class GetMembership : PageModel
{
    private readonly ILogger<GetMembership> _logger;

    public GetMembership(ILogger<GetMembership> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
