using Microsoft.EntityFrameworkCore;
using sharpHeroesAPI.Model;

namespace sharpHeroesAPI.Domain;

public class HeroContext : DbContext
{
    public DbSet<Hero> Heroes { get; set; }
    public HeroContext(DbContextOptions options) : base(options)
    {

    }
}
