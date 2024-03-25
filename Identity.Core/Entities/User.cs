using Microsoft.AspNetCore.Identity;

namespace Identity.Core;

public class User : IdentityUser<Guid>
{
    public DateOnly DateOfBirth { get; set; }

    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;
}