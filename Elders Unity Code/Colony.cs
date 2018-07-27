using System;
using System.Collections.Generic;
using ColonistConstructor;

namespace Colony {
    


    class ColonyState
    {
        List<Colonist> colonists = new List<Colonist>(); //TODO: Make a method that takes a newly generated colonist and adds them to the list

        public int population() {
            return colonists.Count;

        }
        private int happiness;

    private static void Main()
    {
        Colonist unga = new Colonist("Unga","Human","NEET",100);
        Colonist bae = new Colonist("Bae", "Orc", "Warrior",150);
        ColonyState testColony = new ColonyState();
        testColony.colonists.Add(unga);
        testColony.colonists.Add(bae);
        testColony.colonists.Add(Colonist.babyMaker(unga, bae));
        Console.WriteLine(testColony.population());
        testColony.colonists.ForEach(Console.WriteLine);
    }

    }

}