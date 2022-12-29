using Microsoft.AspNetCore.Identity;

namespace BlazorPractice.ServersideBlazorAuth.Data
{
    public class AspNetUsers : IdentityUser
    {
        public string School { get; set; }
    }
}
