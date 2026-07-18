namespace Iptv.Application.Features.Authentication;
public class LoginResponse
{
    public string AccessToken { get; set; } = string.Empty;
    public string RefreshToken { get; set; } = string.Empty;
    public DateTime ExpiredAt { get; set; }
}