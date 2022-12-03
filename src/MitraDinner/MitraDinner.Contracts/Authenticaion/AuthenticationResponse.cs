namespace MitraDinner.Contracts.Authenticaion
{
    public record AuthenticationRequest
    (
        Guid Id,
        string FirstName,
        string LastName,
        string Email,
        string Token
    );
}