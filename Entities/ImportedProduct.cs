namespace ExercicioHeranca_Polimorfismo.Entities;

public class ImportedProduct : Product
{
    public double CustomsFee { get; set; }

    public double TotalPrice()
    {
        return Price + CustomsFee;
    }
}