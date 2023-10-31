namespace N63_HT1.Api.Settings;

public class JwtSetting
{
    public bool ValidateIssuer { get; set; }
    public string ValidIssuer { get; set; } = string.Empty;
    
    public bool ValidateAudience { get; set; }
    public string ValidAudience { get; set; } = string.Empty;
    
    public bool ValidateLifeTime { get; set; }
    public int ValidLifeTimeInMinute { get; set; }
    
    public bool ValidateIssuerSigningKey { get; set; }
    public string SecretKey { get; set; } = string.Empty;
}