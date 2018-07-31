using System;
using System.Collections.Generic;

class Colony {
    // TODO you might want this to be a hashtable in the future. Random access of that will be much more
    private Dictionary<int,Colonist> colonists = new Dictionary<int,Colonist>();

    // TODO you can make one of these for name too, you'll just have to iterate over it. Or implement it with name as the key.
    // I tend to avoid name as key so you don't have to worry about duplicates, mutation, etc., but that's your call.
    // Whatever your key is you want it to be unique and ideally not change (what happens if one part of your game stores a character, another part
    // swaps the names of two colonists, and then the first part tries to refer to the first colonist again. Only you know if this type of thing happens.)
    public Colonist GetColonist(int id) {
        // TODO nilcheck
        return colonists[id];
    }

    public void AddColonist(int key, Colonist colonist) {
        colonists[key] = colonist;
        return;
    }

    public int Population() {
        return colonists.Count;
    }

    public void PrintColony() {
        foreach (var colonist in colonists) {
            Console.WriteLine(colonist.Value);
        }
    }

    //private int happiness;
}