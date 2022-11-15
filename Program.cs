using ExercicioHeranca_Polimorfismo.Entities;

Console.Write("Enter the number of products: ");
int productAmount = int.Parse(Console.ReadLine());

List<Product> list = new List<Product>();

for (int i = 1; i <= productAmount; i++)
{
    Console.WriteLine($"Product {i} data: ");
    Console.Write("Common, used or imported (c/u/i)? ");
    char type = Char.Parse(Console.ReadLine());
    
    if (type == 'u')
    {
        Console.Write("Name: ");
        string productName = Console.ReadLine();
        Console.Write("Price: ");
        double productPrice = double.Parse(Console.ReadLine());
        Console.Write("Manufacture date (DD/MM/YYYY): ");
        DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
        list.Add(new UsedProduct(productName, productPrice, manufactureDate));
    } else if (type == 'i')
    {
        Console.Write("Name: ");
        string productName = Console.ReadLine();
        Console.Write("Price: ");
        double productPrice = double.Parse(Console.ReadLine());
        Console.Write("Customs fee: ");
        double productFee = Double.Parse(Console.ReadLine());
        list.Add(new ImportedProduct(productName, productPrice, productFee));
    }
    else
    {
        Console.Write("Name: ");
        string productName = Console.ReadLine();
        Console.Write("Price: ");
        double productPrice = double.Parse(Console.ReadLine());
        list.Add(new Product(productName, productPrice));
    }

    foreach (var product in list)
    {
        Console.WriteLine(product.priceTag());
    }
}
