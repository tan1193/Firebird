using Firebird.Application.Common.Interfaces;

namespace Firebird.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
