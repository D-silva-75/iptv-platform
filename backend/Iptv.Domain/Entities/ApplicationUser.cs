using System;
using Microsoft.AspNetCore.Identity;

namespace Iptv.Domain.Entities;

public class ApplicationUser : IdentityUser<Guid>
{
 public string FullName { get; set; } = string.Empty;
 public DateTime CreatedAt { get; set; } = DateTime.UtcNow;  
 public bool Enabled { get; set; } = true;
}
