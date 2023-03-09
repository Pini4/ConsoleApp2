// See https://aka.ms/new-console-template for more information
using ConsoleApp2.DB;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static GoodsContext _ef;
    private static void Main(string[] args)
    {
        _ef = new GoodsContext();
        _ef.Database.Migrate();

        Console.WriteLine($"Can connected to db: {_ef.Database.CanConnect()}");

        foreach (var item in _ef.Categories.ToList())
        {
            Console.WriteLine(item.Name);
        }
        var find_category = _ef.Categories.FirstOrDefault(x => x.Name == "Снэки");
        if (find_category == null)
        {
            find_category = new Category() { Name = "Снеки" };
        }
        foreach (var item in _ef.Goods.ToList())
        {
            double total_sale = item.Price - item.Sale;

            Console.WriteLine($"{item.Name}" + $"With Sale : {total_sale}");
        }



       
    }
}
