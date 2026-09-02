using System;
using System.Reflection;

namespace ReflectionTasksSolutions
{
    public class Student
    {
        public string Name { get; set; } = "Peyman";
        public int Age { get; set; } = 25;
        public string Grade { get; set; } = "A";

        public Student()
        {
        }

        public void Study()
        {
            Console.WriteLine($"{Name} is studying.");
        }

        public void TakeExam()
        {
            Console.WriteLine($"{Name} is taking an exam.");
        }

        public void Introduce()
        {
            Console.WriteLine($"Hello, my name is {Name}.");
        }

        public void StudySubject(string subject)
        {
            Console.WriteLine($"{Name} is studying {subject}.");
        }
    }

    public class Product
    {
        public string Name { get; set; } = "Gaming Laptop";
        public decimal Price { get; set; } = 1500.00m;
        public string Category { get; set; } = "Electronics";

        public Product()
        {
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Product: {Name}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Category: {Category}");
        }

        public void ApplyDiscount()
        {
            Price -= 100;
            Console.WriteLine($"Discount applied. New price: {Price}");
        }
    }

    class Program
    {
        static void Main()
        {
            Type studentType = typeof(Student);

            Console.WriteLine("TASK 1 - UNDERSTAND TYPE");
            Console.WriteLine(studentType);
            Console.WriteLine();

            Console.WriteLine("TASK 2 - GET CLASS NAME");
            Console.WriteLine(studentType.Name);
            Console.WriteLine();

            Console.WriteLine("TASK 3 - GET FULL CLASS NAME");
            Console.WriteLine(studentType.FullName);
            Console.WriteLine();

            Console.WriteLine("TASK 4 - LIST PROPERTIES");
            PropertyInfo[] studentProperties = studentType.GetProperties();

            foreach (PropertyInfo property in studentProperties)
            {
                Console.WriteLine(property.Name);
            }

            Console.WriteLine();

            Console.WriteLine("TASK 5 - LIST METHODS");
            MethodInfo[] studentMethods = studentType.GetMethods();

            foreach (MethodInfo method in studentMethods)
            {
                Console.WriteLine(method.Name);
            }

            Console.WriteLine();

            Console.WriteLine("TASK 6 - CREATE OBJECT DYNAMICALLY");
            object studentObject = Activator.CreateInstance(typeof(Student));
            Console.WriteLine("Student object created dynamically.");
            Console.WriteLine();

            Console.WriteLine("TASK 7 - READ PROPERTY VALUE");
            PropertyInfo nameProperty = studentType.GetProperty("Name");
            object currentName = nameProperty.GetValue(studentObject);
            Console.WriteLine($"Current Name: {currentName}");
            Console.WriteLine();

            Console.WriteLine("TASK 8 - CHANGE PROPERTY VALUE");
            nameProperty.SetValue(studentObject, "Nova");
            Console.WriteLine($"Updated Name: {nameProperty.GetValue(studentObject)}");
            Console.WriteLine();

            Console.WriteLine("TASK 9 - INVOKE METHOD");
            MethodInfo introduceMethod = studentType.GetMethod("Introduce");
            introduceMethod.Invoke(studentObject, null);
            Console.WriteLine();

            Console.WriteLine("TASK 10 - INVOKE METHOD WITH PARAMETER");
            MethodInfo studySubjectMethod = studentType.GetMethod("StudySubject");
            studySubjectMethod.Invoke(studentObject, new object[] { "C#" });
            Console.WriteLine();

            Console.WriteLine("TASK 11 - LIST CONSTRUCTORS");
            ConstructorInfo[] constructors = studentType.GetConstructors();

            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor);
            }

            Console.WriteLine();

            Console.WriteLine("TASK 12 - CHECK IF PROPERTY EXISTS");
            PropertyInfo propertyCheck = studentType.GetProperty("Name");

            if (propertyCheck != null)
            {
                Console.WriteLine("The Name property exists.");
            }
            else
            {
                Console.WriteLine("The Name property does not exist.");
            }

            Console.WriteLine();

            Console.WriteLine("TASK 13 - CHECK IF METHOD EXISTS");
            MethodInfo methodCheck = studentType.GetMethod("Study");

            if (methodCheck != null)
            {
                Console.WriteLine("The Study method exists.");
            }
            else
            {
                Console.WriteLine("The Study method does not exist.");
            }

            Console.WriteLine();

            Console.WriteLine("TASK 14 - GET ASSEMBLY NAME");
            Assembly assembly = Assembly.GetExecutingAssembly();
            Console.WriteLine(assembly.GetName().Name);
            Console.WriteLine();

            Console.WriteLine("TASK 15 - LIST TYPES IN ASSEMBLY");
            Type[] allTypes = assembly.GetTypes();

            foreach (Type type in allTypes)
            {
                Console.WriteLine(type.Name);
            }

            Console.WriteLine();

            Console.WriteLine("TASK 16 - CUSTOM ATTRIBUTE IDEA");
            Console.WriteLine("Reflection can read attributes placed above classes, methods, or properties.");
            Console.WriteLine();

            Console.WriteLine("TASK 17 - REAL-WORLD REFLECTION");
            Console.WriteLine("Reflection is used in frameworks, testing tools, and JSON serializers.");
            Console.WriteLine();

            Console.WriteLine("TASK 18 - REFLECTION SAFETY");
            Console.WriteLine("I should check if a property or method exists before using it.");
            Console.WriteLine();

            Console.WriteLine("TASK 19 - REFLECTION PERFORMANCE");
            Console.WriteLine("Reflection can be slower because it inspects metadata at runtime.");
            Console.WriteLine();

            Console.WriteLine("TASK 20 - MINI PROJECT");
            Type productType = typeof(Product);

            Console.WriteLine($"Class Name: {productType.Name}");

            Console.WriteLine("Properties:");

            foreach (PropertyInfo property in productType.GetProperties())
            {
                Console.WriteLine(property.Name);
            }

            Console.WriteLine("Methods:");

            foreach (MethodInfo method in productType.GetMethods())
            {
                Console.WriteLine(method.Name);
            }

            object productObject = Activator.CreateInstance(typeof(Product));

            MethodInfo printInfoMethod = productType.GetMethod("PrintInfo");

            printInfoMethod.Invoke(productObject, null);
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
