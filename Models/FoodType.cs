namespace Stix.Models;


public class FoodType{
    public int Id { get; set; }
    public string Name { get; set; }

    public virtual List<Food> Foods { get; set; }
}