using System;
using System.Collections.Generic;

class Colony {
    private Dictionary<string,Colonist> colonists = new Dictionary<string,Colonist>();

    // TODO think about how you will handle duplicate names or namechanges. Using name as a key is powerful but comes with costs.
    public Colonist GetColonist(string name) {
        Colonist colonist;
        if (!colonists.TryGetValue(name, out colonist)) {
            // TODO csharp normal exception handling, I haven't looked into this yet.
            Console.WriteLine("Couldn't find colonist {name}");
        }
        return colonist;
    }

    public void AddColonist(Colonist colonist) {
        colonists[colonist.name] = colonist;
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