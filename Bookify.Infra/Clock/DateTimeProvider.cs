using Bookify.Application.Abstractions.Clock;

namespace Bookify.Infra.Clock;

internal sealed class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}