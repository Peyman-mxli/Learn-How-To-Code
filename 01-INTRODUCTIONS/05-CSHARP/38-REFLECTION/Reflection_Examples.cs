using System;
using System.Reflection;

namespace ReflectionExamples
{
    public class Person
    {
        public string Name { get; set; } = "Peyman";

        public int Age { get; set; } = 25;

        public void SayHello()
        {
            Console.WriteLine($"Hello, my name is {Name}.");
        }

        public void Introduce(string city)
        {
            Console.WriteLine($"I live in {city}.");
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("====================================");
            Console.WriteLine("EXAMPLE 1 - GET TYPE INFORMATION");
            Console.WriteLine("====================================");

            Type personType = typeof(Person);

            Console.WriteLine($"Name: {personType.Name}");
            Console.WriteLine($"Full Name: {personType.FullName}");
            Console.WriteLine($"Namespace: {personType.Namespace}");

            Console.WriteLine();


            Console.WriteLine("====================================");
            Console.WriteLine("EXAMPLE 2 - LIST ALL PROPERTIES");
            Console.WriteLine("====================================");

            PropertyInfo[] properties = personType.GetProperties();

            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.Name);
            }

            Console.WriteLine();


            Console.WriteLine("====================================");
            Console.WriteLine("EXAMPLE 3 - LIST ALL METHODS");
            Console.WriteLine("====================================");

            MethodInfo[] methods = personType.GetMethods();

            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.Name);
            }

            Console.WriteLine();


            Console.WriteLine("====================================");
            Console.WriteLine("EXAMPLE 4 - CREATE OBJECT DYNAMICALLY");
            Console.WriteLine("====================================");

            object personObject =
                Activator.CreateInstance(typeof(Person));

            Console.WriteLine("Person object created successfully.");

            Console.WriteLine();


            Console.WriteLine("====================================");
            Console.WriteLine("EXAMPLE 5 - INVOKE METHOD");
            Console.WriteLine("====================================");

            MethodInfo sayHelloMethod =
                personType.GetMethod("SayHello");

            sayHelloMethod.Invoke(personObject, null);

            Console.WriteLine();


            Console.WriteLine("====================================");
            Console.WriteLine("EXAMPLE 6 - INVOKE METHOD WITH PARAMETERS");
            Console.WriteLine("====================================");

            MethodInfo introduceMethod =
                personType.GetMethod("Introduce");

            introduceMethod.Invoke(
                personObject,
                new object[] { "Mexicali" });

            Console.WriteLine();


            Console.WriteLine("====================================");
            Console.WriteLine("EXAMPLE 7 - READ PROPERTY VALUE");
            Console.WriteLine("====================================");

            PropertyInfo nameProperty =
                personType.GetProperty("Name");

            object currentName =
                nameProperty.GetValue(personObject);

            Console.WriteLine($"Current Name: {currentName}");

            Console.WriteLine();


            Console.WriteLine("====================================");
            Console.WriteLine("EXAMPLE 8 - MODIFY PROPERTY VALUE");
            Console.WriteLine("====================================");

            nameProperty.SetValue(personObject, "Nova");

            Console.WriteLine(
                $"Updated Name: {nameProperty.GetValue(personObject)}");

            Console.WriteLine();


            Console.WriteLine("====================================");
            Console.WriteLine("EXAMPLE 9 - CALL METHOD AFTER UPDATE");
            Console.WriteLine("====================================");

            sayHelloMethod.Invoke(personObject, null);

            Console.WriteLine();


            Console.WriteLine("====================================");
            Console.WriteLine("EXAMPLE 10 - LIST CONSTRUCTORS");
            Console.WriteLine("====================================");

            ConstructorInfo[] constructors =
                personType.GetConstructors();

            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor);
            }

            Console.WriteLine();


            Console.WriteLine("====================================");
            Console.WriteLine("EXAMPLE 11 - ASSEMBLY INFORMATION");
            Console.WriteLine("====================================");

            Assembly assembly =
                Assembly.GetExecutingAssembly();

            Console.WriteLine($"Assembly Name: {assembly.GetName().Name}");

            Console.WriteLine();


            Console.WriteLine("====================================");
            Console.WriteLine("EXAMPLE 12 - LIST TYPES IN ASSEMBLY");
            Console.WriteLine("====================================");

            Type[] types = assembly.GetTypes();

            foreach (Type type in types)
            {
                Console.WriteLine(type.Name);
            }

            Console.WriteLine();


            Console.WriteLine("====================================");
            Console.WriteLine("REFLECTION EXAMPLES COMPLETED");
            Console.WriteLine("====================================");
        }
    }
}

/*
👤 Author Peyman Miyandashti
📨 250161@upbc.edu.mx // mxli.peyman@gmail.com
📞 +526865090453
🎓 Polytechnic University of Baja California
💻 Information Technology Engineering & Digital Innovation
📍 From IRAN (Mexico)
📅 Year: 2026
🆔 ID: 250161
*/
