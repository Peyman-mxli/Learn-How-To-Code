```csharp
/*
=========================================
34 - OPERATOR OVERLOADING
OperatorOverloading_Examples.cs
=========================================
*/

using System;

namespace OperatorOverloadingExamples
{
    // =========================================
    // Money Example
    // =========================================

    class Money
    {
        public decimal Amount;

        public Money(decimal amount)
        {
            Amount = amount;
        }

        public static Money operator +(Money a, Money b)
        {
            return new Money(a.Amount + b.Amount);
        }

        public static Money operator -(Money a, Money b)
        {
            return new Money(a.Amount - b.Amount);
        }

        public override string ToString()
        {
            return $"${Amount}";
        }
    }

    // =========================================
    // Vector Example
    // =========================================

    class Vector2D
    {
        public int X;
        public int Y;

        public Vector2D(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static Vector2D operator +(Vector2D a, Vector2D b)
        {
            return new Vector2D
            (
                a.X + b.X,
                a.Y + b.Y
            );
        }

        public static Vector2D operator -(Vector2D a, Vector2D b)
        {
            return new Vector2D
            (
                a.X - b.X,
                a.Y - b.Y
            );
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }

    // =========================================
    // Score Example
    // =========================================

    class Score
    {
        public int Points;

        public Score(int points)
        {
            Points = points;
        }

        public static bool operator >(Score a, Score b)
        {
            return a.Points > b.Points;
        }

        public static bool operator <(Score a, Score b)
        {
            return a.Points < b.Points;
        }

        public static bool operator >=(Score a, Score b)
        {
            return a.Points >= b.Points;
        }

        public static bool operator <=(Score a, Score b)
        {
            return a.Points <= b.Points;
        }
    }

    // =========================================
    // Counter Example
    // =========================================

    class Counter
    {
        public int Value;

        public Counter(int value)
        {
            Value = value;
        }

        public static Counter operator ++(Counter counter)
        {
            counter.Value++;
            return counter;
        }

        public static Counter operator --(Counter counter)
        {
            counter.Value--;
            return counter;
        }
    }

    // =========================================
    // Equality Example
    // =========================================

    class Product
    {
        public string Name;

        public Product(string name)
        {
            Name = name;
        }

        public static bool operator ==(Product a, Product b)
        {
            return a.Name == b.Name;
        }

        public static bool operator !=(Product a, Product b)
        {
            return a.Name != b.Name;
        }

        public override bool Equals(object obj)
        {
            if (obj is Product product)
            {
                return Name == product.Name;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=================================");
            Console.WriteLine("MONEY EXAMPLE");
            Console.WriteLine("=================================");

            Money wallet1 = new Money(100);
            Money wallet2 = new Money(50);

            Money totalMoney = wallet1 + wallet2;
            Money remainingMoney = wallet1 - wallet2;

            Console.WriteLine($"Wallet 1: {wallet1}");
            Console.WriteLine($"Wallet 2: {wallet2}");
            Console.WriteLine($"Total: {totalMoney}");
            Console.WriteLine($"Remaining: {remainingMoney}");

            Console.WriteLine();

            Console.WriteLine("=================================");
            Console.WriteLine("VECTOR EXAMPLE");
            Console.WriteLine("=================================");

            Vector2D position = new Vector2D(10, 20);
            Vector2D movement = new Vector2D(5, 3);

            Vector2D newPosition = position + movement;
            Vector2D difference = position - movement;

            Console.WriteLine($"Position: {position}");
            Console.WriteLine($"Movement: {movement}");
            Console.WriteLine($"New Position: {newPosition}");
            Console.WriteLine($"Difference: {difference}");

            Console.WriteLine();

            Console.WriteLine("=================================");
            Console.WriteLine("COMPARISON EXAMPLE");
            Console.WriteLine("=================================");

            Score player1 = new Score(500);
            Score player2 = new Score(300);

            Console.WriteLine(player1 > player2);
            Console.WriteLine(player1 < player2);
            Console.WriteLine(player1 >= player2);
            Console.WriteLine(player1 <= player2);

            Console.WriteLine();

            Console.WriteLine("=================================");
            Console.WriteLine("COUNTER EXAMPLE");
            Console.WriteLine("=================================");

            Counter counter = new Counter(10);

            Console.WriteLine($"Current Value: {counter.Value}");

            counter++;

            Console.WriteLine($"After ++ : {counter.Value}");

            counter--;

            Console.WriteLine($"After -- : {counter.Value}");

            Console.WriteLine();

            Console.WriteLine("=================================");
            Console.WriteLine("EQUALITY EXAMPLE");
            Console.WriteLine("=================================");

            Product product1 = new Product("Laptop");
            Product product2 = new Product("Laptop");
            Product product3 = new Product("Mouse");

            Console.WriteLine(product1 == product2);
            Console.WriteLine(product1 != product3);

            Console.WriteLine();

            Console.WriteLine("=================================");
            Console.WriteLine("OPERATOR OVERLOADING COMPLETE");
            Console.WriteLine("=================================");
        }
    }
}

/*
👤 Author Peyman Miyandashti
📨 [250161@upbc.edu.mx](mailto:250161@upbc.edu.mx) // [mxli.peyman@gmail.com](mailto:mxli.peyman@gmail.com)
📞 +526865090453
🎓 Polytechnic University of Baja California
💻 Information Technology Engineering & Digital Innovation
📍 From IRAN (Mexico)
📅 Year: 2026
🆔 ID: 250161
*/
```
