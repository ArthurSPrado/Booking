using Bookify.Application.Abstractions.Email;

namespace Bookify.Infrastructure.Email;

internal sealed class EmailService : IEmailService
{
    public Task SendAsync(Domain.Users.Email recipient, string subject, string message)
    {
        return Task.CompletedTask;
    }
}