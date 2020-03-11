using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LinqDemoCode
{
    class LinqDemo
    {

        static void Main(string[] args)
        {
            // QueryStringArray();
            //QueryIntArray();
            //QueryArrayList();
            //QueryCollection();
            QueryAnimalData();
            Console.WriteLine("LINQ Demo Code. Press the [any] key to continue.");
            //Video Link
            //www.bing.com/videos/search?q=c%23+tutorial+15+linq+tutorial&view=detail&mid=009F7E77719E6668876B009F7E77719E6668876B&FORM=VIRE
            Console.ReadLine();

        }
        static void QueryStringArray()
        {
            string[] dogs =
            {
                "K 9",
                "Brian",
                "Scooby Doo",
                "Old Yeller",
                "Underdog",
                "Rin Tin Tin",
                "Charlie B. Barkin",
                "Lasie",
                "Snoopy",
            };

            var dogSpaces = from dog in dogs
                            where dog.Contains(" ")
                            orderby dog descending
                            select dog;

            foreach (var i in dogSpaces)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }
        static int[] QueryIntArray()
        {
            int[] nums =
            {
                5,10,15,20,25,30,35
            };
            var gt20 = from num in nums
                       where num > 20
                       orderby num
                       select num;

            foreach (var i in gt20)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            Console.WriteLine($"type is {gt20.GetType()}");

            var listGT20 = gt20.ToList<int>();
            var arrayGT20 = gt20.ToArray<int>();

            nums[0] = 40;

            foreach (var i in gt20)
            {
                Console.WriteLine(i);
            }
            return nums;
        }
        static void QueryArrayList()
        {
            ArrayList famAnimals = new ArrayList()
            {
                new Animal{Name = "Heidi", Height = .8, Weigth = 18},
                new Animal{Name = "Shrek", Height = 4, Weigth = 130},
                new Animal{Name = "Congo", Height = 3.8, Weigth = 90}
            };
            var famAnimalEnum = famAnimals.OfType<Animal>();
            var smAnimal = from Animal in famAnimalEnum
                           where Animal.Weigth <= 90
                           orderby Animal.Name
                           select Animal;

            foreach (var i in smAnimal)
            {
                Console.WriteLine(i);
                Console.WriteLine();
            }
        }
        static void QueryCollection()
        {
            var animalList = new List<Animal>()
                {
                    new Animal{Name = "German Shepherd", Height = 25, Weigth = 77 },
                    new Animal{Name = "Chihuahua", Height = 7, Weigth = 4.4 },
                    new Animal{Name = "St Bernard", Height = 30, Weigth = 200 },
                };
            var bigDogs = from dog in animalList
                          where (dog.Weigth > 70) &&
                                (dog.Height > 25)
                          orderby dog.Name
                          select dog;

            foreach (var i in bigDogs)
            {
                Console.WriteLine(i);
                Console.WriteLine();
            }
        }
        static void QueryAnimalData()
        {

        }

    }
}
