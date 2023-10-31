using Microsoft.Extensions.Options;
using N63_HT1.Api.Settings;

namespace N63_HT1.Api.Service;

public class TokenGeneratorService
{
    private readonly JwtSetting _jwtSetting;

    public TokenGeneratorService(IOptions<JwtSetting> jwtSetting)
    {
        _jwtSetting = jwtSetting.Value;
    }
    
    
}