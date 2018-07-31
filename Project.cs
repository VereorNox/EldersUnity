using System;

namespace Main {
    class Program {
        private static void Main() {
            Colony colony = new Colony();
            
            //Ingest our test data from input.txt
            string[] colonists = System.IO.File.ReadAllLines(@"input.txt");
            foreach (string colonist in colonists) {
                string[] fields = colonist.Split(',');
                colony.AddColonist(new Colonist(fields[0],fields[1],fields[2],int.Parse(fields[3])));
            }

            string babyName = "Baby";
            colony.AddColonist(Colonist.BabyMaker(babyName,colony.GetColonist("Unga"),colony.GetColonist("Bae")));
            Console.WriteLine(colony.Population());
            colony.PrintColony();
        }
    }
}