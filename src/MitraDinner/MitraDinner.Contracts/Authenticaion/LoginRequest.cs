namespace MitraDinner.Contracts.Authenticaion
{
    public record LoginRequest
    (
        string Email,
        string Password
    );
}