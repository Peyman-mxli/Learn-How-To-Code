/*
=========================================
34 - OPERATOR OVERLOADING
OperatorOverloading_Tasks_Solutions.cs
=========================================
*/

using System;

namespace OperatorOverloadingTasksSolutions
{
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

        public override string ToString()
        {
            return $"${Amount}";
        }
    }

    class Distance
    {
        public double Meters;

        public Distance(double meters)
        {
            Meters = meters;
        }

        public static Distance operator +(Distance a, Distance b)
        {
            return new Distance(a.Meters + b.Meters);
        }
    }

    class Score
    {
        public int Points;

        public Score(int points)
        {
            Points = points;
        }

        public static Score operator -(Score a, Score b)
        {
            return new Score(a.Points - b.Points);
        }
    }

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
            return new Vector2D(a.X + b.X, a.Y + b.Y);
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }

    class Weight
    {
        public double Kilograms;

        public Weight(double kilograms)
        {
            Kilograms = kilograms;
        }

        public static Weight operator +(Weight a, Weight b)
        {
            return new Weight(a.Kilograms + b.Kilograms);
        }

        public static Weight operator -(Weight a, Weight b)
        {
            return new Weight(a.Kilograms - b.Kilograms);
        }
    }

    class BankAccount
    {
        public decimal Balance;

        public BankAccount(decimal balance)
        {
            Balance = balance;
        }

        public static BankAccount operator +(BankAccount account, decimal amount)
        {
            return new BankAccount(account.Balance + amount);
        }

        public static BankAccount operator -(BankAccount account, decimal amount)
        {
            return new BankAccount(account.Balance - amount);
        }
    }

    class Temperature
    {
        public double Value;

        public Temperature(double value)
        {
            Value = value;
        }

        public static bool operator >(Temperature a, Temperature b)
        {
            return a.Value > b.Value;
        }

        public static bool operator <(Temperature a, Temperature b)
        {
            return a.Value < b.Value;
        }
    }

    class Level
    {
        public int LevelNumber;

        public Level(int levelNumber)
        {
            LevelNumber = levelNumber;
        }

        public static bool operator ==(Level a, Level b)
        {
            return a.LevelNumber == b.LevelNumber;
        }

        public static bool operator !=(Level a, Level b)
        {
            return a.LevelNumber != b.LevelNumber;
        }

        public override bool Equals(object obj)
        {
            if (obj is Level level)
            {
                return LevelNumber == level.LevelNumber;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return LevelNumber.GetHashCode();
        }
    }

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

    class Product
    {
        public string Name;
        public decimal Price;

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public static bool operator ==(Product a, Product b)
        {
            return a.Name == b.Name && a.Price == b.Price;
        }

        public static bool operator !=(Product a, Product b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            if (obj is Product product)
            {
                return Name == product.Name && Price == product.Price;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Price);
        }
    }

    class CharacterStats
    {
        public int Strength;
        public int Agility;

        public CharacterStats(int strength, int agility)
        {
            Strength = strength;
            Agility = agility;
        }

        public static CharacterStats operator +(CharacterStats a, CharacterStats b)
        {
            return new CharacterStats
            (
                a.Strength + b.Strength,
                a.Agility + b.Agility
            );
        }

        public void Display()
        {
            Console.WriteLine($"Strength: {Strength}, Agility: {Agility}");
        }
    }

    class Rectangle
    {
        public double Width;
        public double Height;

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double Area
        {
            get { return Width * Height; }
        }

        public static bool operator >(Rectangle a, Rectangle b)
        {
            return a.Area > b.Area;
        }

        public static bool operator <(Rectangle a, Rectangle b)
        {
            return a.Area < b.Area;
        }
    }

    class Currency
    {
        public decimal Amount;

        public Currency(decimal amount)
        {
            Amount = amount;
        }

        public static Currency operator +(Currency a, Currency b)
        {
            return new Currency(a.Amount + b.Amount);
        }

        public static Currency operator -(Currency a, Currency b)
        {
            return new Currency(a.Amount - b.Amount);
        }

        public static bool operator ==(Currency a, Currency b)
        {
            return a.Amount == b.Amount;
        }

        public static bool operator !=(Currency a, Currency b)
        {
            return a.Amount != b.Amount;
        }

        public override bool Equals(object obj)
        {
            if (obj is Currency currency)
            {
                return Amount == currency.Amount;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return Amount.GetHashCode();
        }

        public override string ToString()
        {
            return $"${Amount}";
        }
    }

    class GamePosition
    {
        public int X;
        public int Y;
        public int Z;

        public GamePosition(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static GamePosition operator +(GamePosition a, GamePosition b)
        {
            return new GamePosition(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        }

        public static GamePosition operator -(GamePosition a, GamePosition b)
        {
            return new GamePosition(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
        }

        public override string ToString()
        {
            return $"({X}, {Y}, {Z})";
        }
    }

    class Fraction
    {
        public int Numerator;
        public int Denominator;

        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator == 0 ? 1 : denominator;
            Simplify();
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            return new Fraction
            (
                a.Numerator * b.Denominator + b.Numerator * a.Denominator,
                a.Denominator * b.Denominator
            );
        }

        public static Fraction operator -(Fraction a, Fraction b)
        {
            return new Fraction
            (
                a.Numerator * b.Denominator - b.Numerator * a.Denominator,
                a.Denominator * b.Denominator
            );
        }

        public static Fraction operator *(Fraction a, Fraction b)
        {
            return new Fraction
            (
                a.Numerator * b.Numerator,
                a.Denominator * b.Denominator
            );
        }

        public static Fraction operator /(Fraction a, Fraction b)
        {
            return new Fraction
            (
                a.Numerator * b.Denominator,
                a.Denominator * b.Numerator
            );
        }

        private void Simplify()
        {
            int gcd = GetGreatestCommonDivisor(Math.Abs(Numerator), Math.Abs(Denominator));

            Numerator /= gcd;
            Denominator /= gcd;
        }

        private int GetGreatestCommonDivisor(int a, int b)
        {
            while (b != 0)
            {
                int temporary = b;
                b = a % b;
                a = temporary;
            }

            return a == 0 ? 1 : a;
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }
    }

    class InventoryWeight
    {
        public double Kilograms;

        public InventoryWeight(double kilograms)
        {
            Kilograms = kilograms;
        }

        public static InventoryWeight operator +(InventoryWeight a, InventoryWeight b)
        {
            return new InventoryWeight(a.Kilograms + b.Kilograms);
        }

        public static InventoryWeight operator -(InventoryWeight a, InventoryWeight b)
        {
            return new InventoryWeight(a.Kilograms - b.Kilograms);
        }

        public static bool operator >(InventoryWeight a, InventoryWeight b)
        {
            return a.Kilograms > b.Kilograms;
        }

        public static bool operator <(InventoryWeight a, InventoryWeight b)
        {
            return a.Kilograms < b.Kilograms;
        }

        public override string ToString()
        {
            return $"{Kilograms} kg";
        }
    }

    class Experience
    {
        public int Points;

        public Experience(int points)
        {
            Points = points;
        }

        public static Experience operator +(Experience a, Experience b)
        {
            return new Experience(a.Points + b.Points);
        }

        public static bool operator >=(Experience a, Experience b)
        {
            return a.Points >= b.Points;
        }

        public static bool operator <=(Experience a, Experience b)
        {
            return a.Points <= b.Points;
        }

        public override string ToString()
        {
            return $"{Points} XP";
        }
    }

    class Character
    {
        public string Name;
        public Currency Gold;
        public Experience Experience;
        public InventoryWeight Weight;
        public GamePosition Position;

        public Character(string name)
        {
            Name = name;
            Gold = new Currency(0);
            Experience = new Experience(0);
            Weight = new InventoryWeight(0);
            Position = new GamePosition(0, 0, 0);
        }

        public void Display()
        {
            Console.WriteLine($"Character: {Name}");
            Console.WriteLine($"Gold: {Gold}");
            Console.WriteLine($"Experience: {Experience}");
            Console.WriteLine($"Weight: {Weight}");
            Console.WriteLine($"Position: {Position}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Money money1 = new Money(50);
            Money money2 = new Money(25);
            Money totalMoney = money1 + money2;

            Console.WriteLine($"Money Total: {totalMoney}");

            Distance distance1 = new Distance(100.5);
            Distance distance2 = new Distance(50.25);
            Distance totalDistance = distance1 + distance2;

            Console.WriteLine($"Distance Total: {totalDistance.Meters} meters");

            Score score1 = new Score(500);
            Score score2 = new Score(150);
            Score finalScore = score1 - score2;

            Console.WriteLine($"Final Score: {finalScore.Points}");

            Vector2D vector1 = new Vector2D(10, 20);
            Vector2D vector2 = new Vector2D(5, 3);
            Vector2D vectorResult = vector1 + vector2;

            Console.WriteLine($"Vector Result: {vectorResult}");

            Weight weight1 = new Weight(80.5);
            Weight weight2 = new Weight(20.25);

            Console.WriteLine($"Weight Add: {(weight1 + weight2).Kilograms}");
            Console.WriteLine($"Weight Subtract: {(weight1 - weight2).Kilograms}");

            BankAccount account = new BankAccount(1000);

            account = account + 500;
            Console.WriteLine($"After Deposit: {account.Balance}");

            account = account - 200;
            Console.WriteLine($"After Withdrawal: {account.Balance}");

            Temperature hot = new Temperature(35);
            Temperature cold = new Temperature(10);

            Console.WriteLine($"Hot > Cold: {hot > cold}");
            Console.WriteLine($"Hot < Cold: {hot < cold}");

            Level level1 = new Level(10);
            Level level2 = new Level(10);

            Console.WriteLine($"Same Level: {level1 == level2}");
            Console.WriteLine($"Different Level: {level1 != level2}");

            Counter counter = new Counter(5);

            Console.WriteLine($"Counter: {counter.Value}");
            counter++;
            Console.WriteLine($"After ++: {counter.Value}");
            counter--;
            Console.WriteLine($"After --: {counter.Value}");

            Product product1 = new Product("Laptop", 1200);
            Product product2 = new Product("Laptop", 1200);
            Product product3 = new Product("Mouse", 25);

            Console.WriteLine($"Product 1 == Product 2: {product1 == product2}");
            Console.WriteLine($"Product 1 != Product 3: {product1 != product3}");

            CharacterStats baseStats = new CharacterStats(10, 5);
            CharacterStats bonusStats = new CharacterStats(3, 2);
            CharacterStats finalStats = baseStats + bonusStats;

            finalStats.Display();

            Rectangle rectangle1 = new Rectangle(10, 5);
            Rectangle rectangle2 = new Rectangle(4, 3);

            Console.WriteLine($"Rectangle 1 > Rectangle 2: {rectangle1 > rectangle2}");
            Console.WriteLine($"Rectangle 1 < Rectangle 2: {rectangle1 < rectangle2}");

            Currency currency1 = new Currency(100);
            Currency currency2 = new Currency(50);

            Console.WriteLine($"Currency Add: {currency1 + currency2}");
            Console.WriteLine($"Currency Subtract: {currency1 - currency2}");
            Console.WriteLine($"Currency Equal: {currency1 == currency2}");
            Console.WriteLine($"Currency Not Equal: {currency1 != currency2}");

            GamePosition startPosition = new GamePosition(0, 0, 0);
            GamePosition movement = new GamePosition(5, 0, 2);
            GamePosition newPosition = startPosition + movement;

            Console.WriteLine($"New Position: {newPosition}");

            Fraction fraction1 = new Fraction(1, 2);
            Fraction fraction2 = new Fraction(1, 4);

            Console.WriteLine($"Fraction Add: {fraction1 + fraction2}");
            Console.WriteLine($"Fraction Subtract: {fraction1 - fraction2}");
            Console.WriteLine($"Fraction Multiply: {fraction1 * fraction2}");
            Console.WriteLine($"Fraction Divide: {fraction1 / fraction2}");

            Character character = new Character("Nova Hero");

            character.Gold = new Currency(100) + new Currency(250);
            character.Experience = new Experience(500) + new Experience(750);
            character.Weight = new InventoryWeight(40) + new InventoryWeight(15);
            character.Position = new GamePosition(0, 0, 0) + new GamePosition(10, 0, 5);

            character.Display();

            InventoryWeight maxWeight = new InventoryWeight(100);

            Console.WriteLine($"Inventory Over Limit: {character.Weight > maxWeight}");
            Console.WriteLine($"Has Enough XP: {character.Experience >= new Experience(1000)}");
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
