using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UserControlApp.Models;

namespace UserControlApp.Data
{
    public class Context:IdentityDbContext<User>
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
    }
}
