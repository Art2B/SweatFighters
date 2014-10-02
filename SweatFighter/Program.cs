using System;

namespace SweatFighter
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Welcome in Sweat Fighters ! \nGet ready for the rumble !");

			//Armes
			Weapon dague = new Weapon ("Dague", 2, 1, 60, 1);
			Weapon epee = new Weapon ("Épée", 5, 2, 70, 1);
			Weapon lance = new Weapon ("Lance", 7, 4, 50, 1);
			Weapon trident = new Weapon ("Trident", 7, 3, 40, 1, 10);
			// Filet goes here
			// Armures
			Equipment bouclier = new Equipment ("Bouclier", 8, 30);
			Equipment targe = new Equipment ("Targe", 5, 20);
			Equipment casque = new Equipment ("Casque", 2, 10);

//			Console.WriteLine ("Voici un "+dague.name+". Coût: "+dague.cost+". Initiative: "+dague.init+". Chance de toucher: "+dague.touchChance+". Dégâts: "+dague.damage);
//			Console.WriteLine ("Voici un "+bouclier.name+". Chance de parade:"+bouclier.parryChance+"%. Son coût: "+bouclier.cost);
//			Console.WriteLine ("Voici un "+trident.name+". Coût: "+trident.cost+". Initiative: "+trident.init+". Chance de toucher: "+trident.touchChance+". Dégâts: "+trident.damage);

			Gladiator jonJon = new Gladiator ("Jon Snow");
			Gladiator Conan = new Gladiator ("Conan");
			Gladiator julien = new Gladiator ("Julien");
			Gladiator thomas = new Gladiator ("Thomas");

			jonJon.addEquipment (epee);
			jonJon.addEquipment (targe);
			Conan.addEquipment (epee);
			Conan.addEquipment (epee);

			julien.addEquipment (lance);
			julien.addEquipment (casque);
			thomas.addEquipment (trident);
			thomas.addEquipment (dague);

			Team superTeam = new Team ("Les guerriers des steppes", "");
			superTeam.addGladiator (jonJon);
			superTeam.addGladiator (Conan);

			Team leftTeam = new Team ("La team de gauche", "");
			leftTeam.addGladiator (julien);
			leftTeam.addGladiator (thomas);

			Fight firstRound = new Fight(superTeam, leftTeam);
			firstRound.beginFight ();
		}
	}
}
