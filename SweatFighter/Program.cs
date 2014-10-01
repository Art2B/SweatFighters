using System;

namespace SweatFighter
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Welcome in Sweat Fighters ! \nGet ready for the rumble !");

			Weapon dague = new Weapon ("Dague", 2, 1, 60, 1);
			Equipment bouclier = new Equipment ("Bouclier", 8, 30);

			Console.WriteLine ("Voici un "+dague.name+". Coût: "+dague.cost+". Initiative: "+dague.init+". Chance de toucher: "+dague.touchChance+". Dégâts: "+dague.damage);
			Console.WriteLine ("Voici un "+bouclier.name+". Chance de parade:"+bouclier.parryChance+"%. Son coût: "+bouclier.cost);
		}
	}
}
