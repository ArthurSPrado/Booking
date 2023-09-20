using Bookify.Domain.Abstractions;

namespace Bookify.Domain.Bookings;

public class BookingErrors
{
    public static readonly Error NotFound = new(
        "Booking.Found",
        "The booking with the specific identifier was not found.");
    
    public static readonly Error Overlap = new(
        "Booking.Overlap",
        "The booking overlaps with another booking.");
    
    public static readonly  Error NotReserved = new (
        "Booking.NotReserved",
        "The booking is not pending.");
    
    public static readonly Error NotConfirmed = new (
        "Booking.NotConfirmed",
        "The booking is not confirmed.");
    
    public static readonly Error AlreadyStarted = new(
        "Booking.AlreadyStarted", 
        "The booking has already started.");
    
}