using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace college.Pages;

public class AddMember : PageModel
{
    private readonly ILogger<AddMember> _logger;

    public AddMember(ILogger<AddMember> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
