using Iptv.Domain.Common;

namespace Iptv.Domain.Entities;

public class Device : BaseEntity
{
    public Guid UserId { get; set; }
    public string DeviceId { get; set; }=string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Platform { get; set; } = string.Empty;

    public bool Enabled { get; set; } = true;
    public DateTime? LastConnection { get; set; }

    public bool Activated { get; set; } = true;

    public string ActivationCode { get; set; }= string.Empty;
}