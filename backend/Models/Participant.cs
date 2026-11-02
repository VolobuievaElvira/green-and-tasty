namespace backend.Models;

public class Participant
{
    public string Id { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public List<ParticipantItem> Items { get; set; } = [];
    public decimal Total { get; set; } = 0;
    public bool IsSubmitted { get; set; } = false;

    public void Sum()
    {
        Total = Items.Sum(item => item.Dish.Price * item.Quantity);
    }
}