using System;

namespace ColonistConstructor {
	public class Colonist
	{
		private string name;
		private string race;
		private string profession;
		private int health;
		private int curse;
		
		public Colonist(string colonistName, string colonistRace, string colonistProfession, int colonistHealth)
		{
			name = colonistName;
			race = colonistRace;
			profession = colonistProfession;
			health = colonistHealth;
			curse = 0;
		}

			public override string ToString() 
			{
				return name+" the "+race+" "+profession+" has "+health+" HP. Their curse is: "+curse;
			}

		public static Colonist babyMaker(Colonist parentA, Colonist parentB)
			{
				Colonist baby = new Colonist("Baby", "Unknown", "Baby", 100);
				if (parentA.race == parentB.race) {
					baby.race = parentA.race;
				} else if (parentA.race != parentB.race) {
					if (parentA.race == "Human" && parentB.race == "Orc") {
						baby.race = "Half-Orc";
					}
					else if (parentA.race == "Orc" && parentB.race == "Human") {
						baby.race = "Half-Orc";
					}
				}
				else {
					baby.race = "Unidentified";
				}
				return baby;
			}
				
	}

}


