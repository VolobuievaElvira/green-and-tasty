using backend.Data;
using backend.Models;
using backend.Services;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/guest/groups/{groupReservationId}/sessions",
    (string groupReservationId) =>
    {
        if (groupReservationId != MockData.GroupId)
            return Results.NotFound();

        return Results.Ok(GroupSessionsService.Snapshot());
    }
);

app.MapGet("/reservations/{reservationId}/guest-session-id",
    (string reservationId) =>
    {
        var reservation = MockData.Reservations
            .FirstOrDefault(r => r.Id == reservationId);

        if (reservation == null)
            return Results.NotFound();

        return Results.Ok(new GuestSessionIdResponse
        {
            GuestSessionId = reservation.OwnerGuestSessionId
        });
    }
);


app.Run();