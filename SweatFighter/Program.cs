using System;

namespace SweatFighter
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Welcome in Sweat Fighters ! \nGet ready for the rumble !");

			Equipment dague = new Equipment (2);
			Equipment bouclier = new Equipment (8, 30);

			Console.WriteLine (dague.costPublic);
			Console.WriteLine ("Voici le bouclier. Chance de parade:"+bouclier.parryPublic+"%. Son coût: "+bouclier.costPublic);
		}
	}
}
