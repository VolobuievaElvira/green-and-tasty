using backend.Data;
using backend.Services;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/guest/groups/{groupReservationId}/sessions",
    (string groupReservationId) =>
    {
        if (groupReservationId != MockData.GroupId)
            return Results.NotFound();

        return Results.Ok(GroupSessionsService.Snapshot());
    });

app.Run();