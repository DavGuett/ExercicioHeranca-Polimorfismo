namespace ExercicioHeranca_Polimorfismo.Entities;

public class Product
{
    public string Name { get; set; }
    public double Price { get; set; }

    public string priceTag()
    {
        return Price.ToString();
    }
    
}