using Bookify.Domain.Abstractions;

namespace Bookify.Domain.Apartments;

public static class ApartmentErrors
{
    public static Error ApartmentNotFound = new(
        "Property.NotFound",
        "The property with the specified identifier was not found");
}