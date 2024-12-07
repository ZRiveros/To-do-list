//using System.Reflection.Metadata;

//ÖVNINGSUPPGIFT - ATT - GÖRA - LISTA


//I denna uppgift ska du skapa en enkel ATT-GÖRA-app i C# och .NET. Appen låter användaren lägga till och visa ATT-GÖRA-uppgifter.

//Exempel på hur det kan se ut:

//Att göra:

//-Handla mat(pågående)

//- Tvätta bilen(slutförd)



//Instruktioner


//Mål: Skapa ett program som låter användaren skapa och visa en lista med ATT-GÖRA-uppgifter.


//1. Skapa en Todo-klass

//    Skapa en klass Todo med två egenskaper: Description(beskrivning av uppgiften) och IsCompleted(status på uppgiften, t.ex.om den är klar eller ej).


//2.Skapa en lista för att lagra att göra-uppgifter

//    I huvudprogrammet, skapa en List<Todo> för att lagra alla ATT-GÖRA-uppgifter som användaren skapar.


//3. Bygg huvudmenyn

//    Skapa en enkel meny som låter användaren välja mellan att:
//    Lägg till en ny ATT-GÖRA-uppgift
//    Visa alla ATT-GÖRA-uppgifter
//    Avsluta programmet


//4. Lägg till funktionalitet för att hantera uppgifter

//    Om användaren väljer att lägga till en uppgift:
//    Be dem skriva in uppgiften och lägg sedan till den i listan.
//    Om användaren väljer att visa uppgifterna:
//    Skriv ut alla uppgifter och deras status (klar eller ej).


//5. Avsluta programmet

//    Om användaren väljer att avsluta, avslutas programmet.

//ÖVNINGSUPPGIFT 2 - ATT-GÖRA-LISTA

using System;
using System.Collections.Generic;

namespace TodoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lista för att lagra uppgifter
            List<Todo> todos = new List<Todo>();
            bool running = true;

            while (running)
            {
                // Visa huvudmenyn
                Console.WriteLine("\nATT-GÖRA APP");
                Console.WriteLine("1. Lägg till en ny uppgift");
                Console.WriteLine("2. Visa alla uppgifter");
                Console.WriteLine("3. Avsluta");
                Console.Write("Välj ett alternativ (1-3): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        // Lägg till en ny uppgift
                        AddTodo(todos);
                        break;
                    case "2":
                        // Visa alla uppgifter
                        ShowTodos(todos);
                        break;
                    case "3":
                        // Avsluta programmet
                        running = false;
                        Console.WriteLine("Programmet avslutas. Hej då!");
                        break;
                    default:
                        Console.WriteLine("Ogiltigt val, försök igen.");
                        break;
                }
            }
        }

        static void AddTodo(List<Todo> todos)
        {
            Console.Write("Ange beskrivningen för uppgiften: ");
            string description = Console.ReadLine();

            Todo newTodo = new Todo
            {
                Description = description,
                IsCompleted = false
            };

            todos.Add(newTodo);
            Console.WriteLine("Uppgift tillagd!");
        }

        static void ShowTodos(List<Todo> todos)
        {
            if (todos.Count == 0)
            {
                Console.WriteLine("Det finns inga uppgifter ännu.");
                return;
            }

            Console.WriteLine("\nATT-GÖRA:");
            for (int i = 0; i < todos.Count; i++)
            {
                string status = todos[i].IsCompleted ? "(slutförd)" : "(pågående)";
                Console.WriteLine($"- {todos[i].Description} {status}");
            }
        }
    }

    // Klassen för ATT-GÖRA-uppgifter
    class Todo
    {
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
    }
}
