using System;
using System.Collections.Generic;

class Product
{
    public string Name { get; set; }
    public int Price { get; set; }

    public Product(string name, int price)
    {
        Name = name;
        Price = price;
    }
}

class Player
{
    public string Name { get; set; }
    public int Score { get; set; }

    public Player(string name)
    {
        Name = name;
        Score = 0;
    }

    public void AddScore()
    {
        Score++;
    }
}

class Game
{
    private List<Product> products;
    private Player player;

    public Game(Player player)
    {
        this.player = player;
        products = new List<Product>()
        {
            new Product("Tivi", 10000000),
            new Product("Tủ lạnh", 8000000),
            new Product("Máy giặt", 7000000)
        };
    }

    public void Start()
    {
        Console.WriteLine("===== GAME HÃY CHỌN GIÁ ĐÚNG =====");

        foreach (var product in products)
        {
            Console.WriteLine("\nSản phẩm: " + product.Name);
            Console.Write("Nhập giá bạn đoán: ");
            int guess = int.Parse(Console.ReadLine());

            if (guess == product.Price)
            {
                Console.WriteLine("Chính xác!");
                player.AddScore();
            }
            else
            {
                Console.WriteLine("Sai! Giá đúng là: " + product.Price);
            }
        }

        Console.WriteLine("\nKết thúc game!");
        Console.WriteLine("Điểm của bạn: " + player.Score);
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Nhập tên người chơi: ");
        string name = Console.ReadLine();

        Player player = new Player(name);
        Game game = new Game(player);

        game.Start();
    }
}