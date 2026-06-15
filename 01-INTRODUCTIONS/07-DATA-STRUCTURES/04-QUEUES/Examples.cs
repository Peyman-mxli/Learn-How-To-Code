/*
=========================================================
EXAMPLES.CS
Module: 07-DATA-STRUCTURES
Topic: 04-QUEUES
=========================================================

Author: Peyman Miyandashti
University: Polytechnic University of Baja California
Program: Information Technology Engineering & Digital Innovation
Origin: IRAN (Mexico)
Year: 2026
=========================================================
*/

using System;
using System.Collections.Generic;

namespace QueuesExamples
{
    public class Patient
    {
        public string Name { get; set; }
        public string Symptom { get; set; }
        public DateTime ArrivalTime { get; set; }

        public Patient(string name, string symptom)
        {
            Name = name;
            Symptom = symptom;
            ArrivalTime = DateTime.Now;
        }

        public override string ToString()
        {
            return $"Patient: {Name}, Symptom: {Symptom}, Arrival: {ArrivalTime.ToShortTimeString()}";
        }
    }

    public class WaitingRoomManager
    {
        private Queue<Patient> patientQueue = new Queue<Patient>();

        public void RegisterArrival(Patient patient)
        {
            patientQueue.Enqueue(patient);
            Console.WriteLine($"{patient.Name} was added to the waiting room queue.");
        }

        public void ShowNextPatient()
        {
            if (patientQueue.Count > 0)
            {
                Patient nextPatient = patientQueue.Peek();
                Console.WriteLine($"Next patient: {nextPatient.Name}");
            }
            else
            {
                Console.WriteLine("The waiting room queue is empty.");
            }
        }

        public void AttendNextPatient()
        {
            if (patientQueue.Count > 0)
            {
                Patient attendedPatient = patientQueue.Dequeue();
                Console.WriteLine($"Attending: {attendedPatient.Name}");
            }
            else
            {
                Console.WriteLine("There are no patients waiting.");
            }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Example1_QueueOfOrders();

            Console.WriteLine("\nPress ENTER for Example 2...");
            Console.ReadLine();

            Example2_QueueOfNumbers();

            Console.WriteLine("\nPress ENTER for Example 3...");
            Console.ReadLine();

            Example3_HospitalWaitingRoom();

            Console.WriteLine("\nEnd of queue examples.");
        }

        public static void Example1_QueueOfOrders()
        {
            Console.Clear();
            Console.WriteLine("=== EXAMPLE 1: Queue of Orders ===\n");

            Queue<string> orders = new Queue<string>();

            orders.Enqueue("Order 1: Coffee");
            orders.Enqueue("Order 2: Toast");
            orders.Enqueue("Order 3: Juice");
            orders.Enqueue("Order 4: Muffins");

            Console.WriteLine("--- Elements in the queue ---");

            foreach (string order in orders)
            {
                Console.WriteLine(order);
            }

            Console.WriteLine("\n--- Processing orders ---");

            Console.WriteLine($"Next order to process: {orders.Peek()}");

            while (orders.Count > 0)
            {
                string processedOrder = orders.Dequeue();
                Console.WriteLine($"Processing: {processedOrder}. Remaining orders: {orders.Count}");
            }

            Console.WriteLine("\n--- Final queue state ---");

            if (orders.Count == 0)
            {
                Console.WriteLine("The order queue is empty.");
            }
        }

        public static void Example2_QueueOfNumbers()
        {
            Console.Clear();
            Console.WriteLine("=== EXAMPLE 2: Queue of Numbers ===\n");

            Queue<int> numbersQueue = new Queue<int>();

            numbersQueue.Enqueue(10);
            numbersQueue.Enqueue(20);
            numbersQueue.Enqueue(30);

            Console.WriteLine("After enqueue: " + string.Join(", ", numbersQueue));

            int firstElement = numbersQueue.Peek();
            Console.WriteLine("First element using Peek(): " + firstElement);

            Console.WriteLine("After Peek(): " + string.Join(", ", numbersQueue));

            int removedElement = numbersQueue.Dequeue();
            Console.WriteLine("Removed element using Dequeue(): " + removedElement);

            Console.WriteLine("After Dequeue(): " + string.Join(", ", numbersQueue));

            int totalElements = numbersQueue.Count;
            Console.WriteLine("Number of elements: " + totalElements);
        }

        public static void Example3_HospitalWaitingRoom()
        {
            Console.Clear();
            Console.WriteLine("=== EXAMPLE 3: Hospital Waiting Room ===\n");

            WaitingRoomManager manager = new WaitingRoomManager();

            manager.RegisterArrival(new Patient("Juan", "Headache"));
            manager.RegisterArrival(new Patient("Maria", "Fracture"));
            manager.RegisterArrival(new Patient("Pedro", "General checkup"));

            Console.WriteLine();

            manager.ShowNextPatient();

            Console.WriteLine();

            manager.AttendNextPatient();
            manager.AttendNextPatient();
            manager.AttendNextPatient();
            manager.AttendNextPatient();
        }
    }
}
