using BlazorApp1.Models;

namespace BlazingPizza;

public class Order
{
    public int OrderId { get; set; }

<<<<<<< Updated upstream
        public string UserId { get; set; }
=======
    public string UserId { get; set; } = "";
>>>>>>> Stashed changes

    public DateTime CreatedTime { get; set; }

    public Address DeliveryAddress { get; set; } = new();

    public List<Pizza> Pizzas { get; set; } = new();

    public decimal GetTotalPrice()
    {
        return Pizzas.Sum(p => p.GetTotalPrice());
    }

    public string GetFormattedTotalPrice()
    {
        return GetTotalPrice().ToString("0.00");
    }
}