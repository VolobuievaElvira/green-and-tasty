namespace backend.Models;

public class Reservation
{
    public string Id { get; set; } = string.Empty;
    public string OwnerId { get; set; } = string.Empty;
    public string OwnerGuestSessionId { get; set; } = string.Empty;
}