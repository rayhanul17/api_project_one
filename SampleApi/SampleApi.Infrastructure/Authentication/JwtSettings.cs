namespace SampleApi.Infrastructure.Authentication;

public class JwtSettings
{
    public const string SectionName = "JwtSettings";
    public string Issuer { get; init; }
    public string Audience { get; init; }
    public int ExpiryMinutes { get; init; }
    public string Secret { get; init; }
}
