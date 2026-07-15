using Iptv.Domain.Common;
using Iptv.Domain.Enums;

namespace Iptv.Domain.Entities;

public class Playlist : BaseEntity
{
    public Guid DeviceId { get; set; }
    public string Name { get; set; } = string.Empty;
    public PlaylistType Type { get; set; }
    public string? Server { get; set; }
    public string? UserName { get; set; }
    public string? Password { get; set; }
    public string? M3uUrl { get; set; }
    public string ?EpgUrl { get; set; }

    public bool IsDefault { get; set; }

    public bool Enabled { get; set; } = true;
}