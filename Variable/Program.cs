internal class Program
{
    private static void Main(string[] args)
    {
        int enemy_health = 100;
        Console.WriteLine("Enemy HP: " + enemy_health);

        double game_currency = 2500.50;
        Console.WriteLine("Game currency: " + game_currency);

        string player_name = "John Doe";
        Console.WriteLine("Player's name: " + player_name);

        bool isAlive = true;
        Console.WriteLine("Is alive: " + isAlive);

        char patrol_state = 'S';
        Console.WriteLine("Patrol state: " + patrol_state);

        byte player_age = 25;
        Console.WriteLine("Player age: " + player_age);

        long score = 1000000000;
        Console.WriteLine("Score: " + score);

        decimal price = 100.50m;
        Console.WriteLine("Price: " + price);

        int? null_variable = null;
        Console.WriteLine("Null variable: " + null_variable);

        float speed = 100.50f;
        Console.WriteLine("Speed: " + speed);

        const double Pi = 3.14159;
        Console.WriteLine("Pi: " + Pi);

        const string CompanyName = "ABC Corporation";
        Console.WriteLine("Company name: " + CompanyName);

        const int MaxRetries = 3;
        Console.WriteLine("Maximum number: " + MaxRetries);

        const double gravity = 9.8;
        Console.WriteLine("Gravity: " + gravity);

        const int MonthsInYear = 12;
        Console.WriteLine("Month in year: " + MonthsInYear);
    }
}
