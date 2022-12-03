namespace MitraDinner.Contracts.Authenticaion
{
    public record RegisterRequest
    (
        string FirstName,
        string LastName,
        string Email,
        string Password
    );
}