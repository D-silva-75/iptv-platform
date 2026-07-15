using Iptv.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Iptv.Infrastructure.Data;
public class ApplicationDbContext:IdentityDbContext<ApplicationUser,IdentityRole<Guid>,Guid>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    public DbSet<Playlist> Playlists => Set<Playlist>();
    public DbSet<Device> Devices => Set<Device>();
    
}