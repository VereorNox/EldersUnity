using System;

namespace Main {
    class Program {
        private static void Main() {
            Colony colony = new Colony();
            
            //Ingest our test data from input.txt
            string[] colonists = System.IO.File.ReadAllLines(@"input.txt");
            foreach (string colonist in colonists) {
                string[] fields = colonist.Split(',');
                colony.AddColonist(int.Parse(fields[0]),new Colonist(fields[1],fields[2],fields[3],int.Parse(fields[4])));
            }

            colony.AddColonist(3,Colonist.BabyMaker(colony.GetColonist(1),colony.GetColonist(2)));
            Console.WriteLine(colony.Population());
            colony.PrintColony();
        }
    }
}