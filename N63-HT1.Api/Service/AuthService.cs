using System.Security.Authentication;
using N63_HT1.Api.DTOs;
using N63_HT1.Api.Model;

namespace N63_HT1.Api.Service;

public class AuthService
{
    private readonly TokenGeneratorService _tokenGeneratorService;

    public AuthService(TokenGeneratorService tokenGeneratorService)
    {
        _tokenGeneratorService = tokenGeneratorService;
    }
    
    private static List<User> _users = new (); 

    public ValueTask<bool> Register(RegistrationDetails registrationDetails)
    {
        var user = new User
        {
                        Id = Guid.NewGuid(),
                        FirstName = registrationDetails.FirstName,
                        LastName = registrationDetails.LastName,
                        Age = registrationDetails.Age,
                        EmailAddress = registrationDetails.EmailAddress,
                        Password = registrationDetails.Password
        };
        
        _users.Add(user);

        return new(true);
    }

    public ValueTask<string> Login(LoginDetails loginDetails)
    {
        var foundUser = _users.FirstOrDefault(user => user.EmailAddress == loginDetails.EmailAddress && user.Password == loginDetails.Password);
        if (foundUser is null)
            throw new AuthenticationException("Login details are invalid, contact support");

        var accessToken = _tokenGeneratorService.GetToken(foundUser);
        return new(accessToken);
    }
}