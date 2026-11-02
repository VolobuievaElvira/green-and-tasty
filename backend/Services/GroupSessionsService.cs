using backend.Data;
using backend.Models;

namespace backend.Services;

public static class GroupSessionsService
{
    public static GroupSessionsResponse Snapshot()
    {
        foreach (var participant in MockData.Participants)
        {
            participant.Sum();
        }

        return new GroupSessionsResponse
        {
            Participants = MockData.Participants,
            Total = MockData.Participants.Sum(p => p.Total)
        };
    }
}