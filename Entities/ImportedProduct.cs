namespace ExercicioHeranca_Polimorfismo.Entities;

public class ImportedProduct : Product
{
    public double CustomsFee { get; set; }

    public ImportedProduct(string name, double price, double customsFee) : base(name, price)
    {
        CustomsFee = customsFee;
    }
    public double TotalPrice()
    {
        return Price + CustomsFee;
    }
}