namespace ExercicioHeranca_Polimorfismo.Entities;

public class UsedProduct : Product
{
    public DateTime ManufactureDate { get; set; }

    public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price)
    {
        ManufactureDate = manufactureDate;
    }

    public override string priceTag()
    {
        string tag = $"{Name} (used) $ {Price} (Manufacture date: {ManufactureDate}";
        return tag;
    }
}