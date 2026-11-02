using backend.Models;

namespace backend.Data;

public static class MockData
{
    public const string GroupId = "demo-group";

    public static List<Participant> Participants { get; } =
    [
        new Participant
        {
            Id = "gs-owner",
            Type = "Owner",
            Name = "Yevhenii",
            IsSubmitted = true,
            Total = 0,
            Items =
            [
                new ParticipantItem
                {
                    Dish = new DishShort
                    {
                        Id = "dish-spring-salad",
                        Name = "Spring Salad",
                        Price = 12m
                    },
                    Quantity = 1
                },
                new ParticipantItem
                {
                    Dish = new DishShort
                    {
                        Id = "dish-avocado-bowl",
                        Name = "Avocado Pine Nut Bowl",
                        Price = 14.5m
                    },
                    Quantity = 1
                }
            ]
        },

        new Participant
        {
            Id = "gs-kateryna",
            Type = "Guest",
            Name = "Kateryna",
            IsSubmitted = true,
            Total = 0,
            Items =
            [
                new ParticipantItem
                {
                    Dish = new DishShort
                    {
                        Id = "dish-spring-salad",
                        Name = "Spring Salad",
                        Price = 12m
                    },
                    Quantity = 2
                }
            ]
        },

        new Participant
        {
            Id = "gs-mariia",
            Type = "Guest",
            Name = "Mariia",
            IsSubmitted = false,
            Total = 0,
            Items =
            [
                new ParticipantItem
                {
                    Dish = new DishShort
                    {
                        Id = "dish-strawberry-salad",
                        Name = "Fresh Strawberry Mint Salad",
                        Price = 11m
                    },
                    Quantity = 1
                },
                new ParticipantItem
                {
                    Dish = new DishShort
                    {
                        Id = "dish-potato-lentil",
                        Name = "Roasted Sweet Potato & Lentil Salad",
                        Price = 13m
                    },
                    Quantity = 1
                }
            ]
        },

        new Participant
        {
            Id = "gs-mariana",
            Type = "Guest",
            Name = "Mariana",
            IsSubmitted = false,
            Total = 0,
            Items = []
        }
    ];
}