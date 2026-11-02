namespace backend.Models;

public class ParticipantItem
{
    public DishShort Dish { get; set; } = new();
    public int Quantity { get; set; }
}