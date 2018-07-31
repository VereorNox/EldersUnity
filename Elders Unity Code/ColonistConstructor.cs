using System;

public class Colonist
{
    private string name, race, profession;
    private int health, curse;
    
    public Colonist(string n, string r, string p, int h)
    {
        name = n;
        race = r;
        profession = p;
        health = h;
        // TODO?
        curse = 0;
    }

    public override string ToString() 
    {
        return name+" the "+race+" "+profession+" has "+health+" HP. Their curse is: "+curse;
    }

    public static Colonist BabyMaker(Colonist parentA, Colonist parentB)
    {
        string race = "Unknown";
        if (parentA.race == parentB.race) {
            race = parentA.race;
        } else if ((parentA.race == "Human" && parentB.race == "Orc") || (parentA.race == "Orc" && parentB.race == "Human")) {
            race = "Half-Orc";
        }
        
        // TODO do you want all babies to have the same name? Should the babymaker signature accept a name?
        return new Colonist("Baby", race, "Baby", 100);
    }
}