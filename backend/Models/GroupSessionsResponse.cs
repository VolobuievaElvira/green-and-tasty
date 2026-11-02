namespace backend.Models;

public class GroupSessionsResponse
{
    public List<Participant> Participants { get; set; } = [];
    public decimal Total { get; set; }
}