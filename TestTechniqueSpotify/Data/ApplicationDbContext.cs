using Microsoft.EntityFrameworkCore;

namespace TestTechniqueSpotify.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
               : base(options)
    {
    }
}