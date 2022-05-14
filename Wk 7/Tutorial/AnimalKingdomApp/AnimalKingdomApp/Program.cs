using System;
using System.Collections.Generic;

namespace AnimalKingdomApp
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Animal> animalList = new List<Animal>();
            InitAnimalList(animalList);
            string option;
            do
            {
                DisplayMenu();
                Console.Write("Enter your option: ");
                option = Console.ReadLine();

                if (animalList.Count <= 0)
                {
                    Console.WriteLine("No animals in the kingdom currently.");
                }
                else
                {
                    if (option == "1")
                    {

                        DisplayAnimals(animalList);

                    }
                    else if (option == "2")
                    {
                        Console.WriteLine("\nAnimal Symphony begins...\n");
                        foreach (Animal a in animalList)
                        {
                            a.MakeSound();
                        }
                    }
                    else if (option == "3")
                    {
                        Console.WriteLine("\nAnimals moving at their best speeds...\n");
                        foreach (Animal a in animalList)
                        {
                            a.Move();
                        }
                    }
                    else if (option == "4")
                    {
                        Console.WriteLine("\nAnimals doing their own activities...\n");
                        DoOwnActivities(animalList);
                    }
                    Console.WriteLine();


                }


            } while (option != "0");

            Console.WriteLine("Exiting program.....");

            // keep console open
            //Console.ReadLine();
        }//end of main
        static void DisplayMenu()
        {
            Console.WriteLine("-----------Menu------------");
            Console.WriteLine("[1] List all animals");
            Console.WriteLine("[2] Animals' Symphony ");
            Console.WriteLine("[3] Make animals move");
            Console.WriteLine("[4] Animals do their own activities");
            Console.WriteLine("[0] Exit");
            Console.WriteLine("---------------------------");
        }

        static void InitAnimalList(List<Animal> animalList)
        {
            animalList.Add(new Ostrich("Masai Ostrich", 60, 1.8));
            animalList.Add(new Dog("German Shepherd", 48));
            animalList.Add(new Human("Jensen from Germany", 30));
            animalList.Add(new Eagle("Bald Eagle", 160, 2.0));
            animalList.Add(new Ostrich("Arabian Ostrich", 70, 2));
            animalList.Add(new Eagle("Red-tailed Hawk", 190, 1.5));
            animalList.Add(new Dog("Doberman Pinscher", 50));

        }

        static void DisplayAnimals(List<Animal> animalList)
        {
            // alternative method
            //for (int i = 0; i < animalList.Count; i++)
            //{
            //    Console.WriteLine("[{0}]\t{1}", i + 1, animalList[i].ToString());
            //}

            int count = 0;
            foreach (Animal a in animalList)
            {
                count++;
                Console.WriteLine("[{0}]\t{1}", count, a.ToString());
            }

        }

        static void DoOwnActivities(List<Animal> animalList)
        {
            //if (animalList.Count > 0)
            //{
            for (int i = 0; i < animalList.Count; i++)
            {
                Animal a = animalList[i];

                if (a is Bird)    // check if it is a Bird object
                {
                    Bird b = (Bird)a;   // downcast to Bird object
                    b.BuildNest();
                }
                else if (a is Dog)   // check if it is a Square object
                {
                    Dog d = (Dog)a; // downcast to Square object
                    d.WagTail();
                }
                else if (a is Human)
                {
                    Human h = (Human)a;
                    h.PlayGames();
                }

            }
            //}
            //else
            //{
            //    Console.WriteLine("No animals in this kingdom currently");
            //}


        }

    }//end of class Program
}
