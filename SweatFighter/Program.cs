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
			Filet filetOriginal = new Filet ("Filet", 3, 5, 30, 0);
			// Get a clone of filet: (Filet)filetOriginal.Clone();
			// Armures
			Equipment bouclier = new Equipment ("Bouclier", 8, 30);
			Equipment targe = new Equipment ("Targe", 5, 20);
			Equipment casque = new Equipment ("Casque", 2, 10);

			Player Martin = new Player ("Georges", "Martin", "Martin");
			Player Arthur = new Player ("Arthur", "Pendragon", "Roi Arthur");
			Player Tolkien = new Player ("J.R.R.", "Tolkien", "Tolkien");
			Player Lucas = new Player ("Georges", "Lucas", "G.Lucas");

			// ******************
			// Compagnie de l'Anneau
			// ******************
			Gladiator Aragorn = new Gladiator ("Aragorn");
			Aragorn.addEquipment (epee);
			Aragorn.addEquipment (dague);
			Aragorn.addEquipment (casque);
			Gladiator Legolas = new Gladiator ("Legolas");
			Legolas.addEquipment (epee);
			Legolas.addEquipment (epee);
			Gladiator Boromir = new Gladiator ("Boromir");
			Boromir.addEquipment (epee);
			Boromir.addEquipment (targe);
			Team CompagnieDeLAnneau = new Team ("la Compagnie de l'Anneau", "Pour le Gondor !", Tolkien);
			CompagnieDeLAnneau.addGladiator (Aragorn);
			CompagnieDeLAnneau.addGladiator (Legolas);
			CompagnieDeLAnneau.addGladiator (Boromir);
			// ******************
			// Ordre Jedi
			// ******************
			Gladiator Obiwan = new Gladiator ("Obiwan Kenobi");
			Obiwan.addEquipment (dague);
			Obiwan.addEquipment (casque);
			Gladiator Yoda = new Gladiator ("Yoda");
			Yoda.addEquipment (trident);
			Yoda.addEquipment (casque);
			Gladiator Anakin = new Gladiator ("Anakin");
			Anakin.addEquipment (dague);
			Anakin.addEquipment (bouclier);
			Team OrdreJedi = new Team ("Ordre Jedi", "Que le force soit avec vous.", Lucas);
			OrdreJedi.addGladiator (Obiwan);
			OrdreJedi.addGladiator (Yoda);
			OrdreJedi.addGladiator (Anakin);
			// ******************
			// Game of Thrones
			// ******************
			Gladiator Oberyn = new Gladiator ("Oberyn Martell");
			Oberyn.addEquipment (lance);
			Oberyn.addEquipment (casque);
			Gladiator Snow = new Gladiator ("Jon Snow");
			Snow.addEquipment (epee);
			Snow.addEquipment (targe);
			Gladiator Jaime = new Gladiator ("Jaime Lannister");
			Jaime.addEquipment (bouclier);
			Jaime.addEquipment (dague);
			Team GoT = new Team ("Game of Thrones", "Winter is coming", Martin);
			GoT.addGladiator (Oberyn);
			GoT.addGladiator (Snow);
			GoT.addGladiator (Jaime);
			// ******************
			// Arthur & co
			// ******************
			Gladiator RoiArthur = new Gladiator("Roi Arthur");
			RoiArthur.addEquipment (epee);
			RoiArthur.addEquipment (targe);
			Gladiator Perceval = new Gladiator ("Perceval le Gallois");
			Perceval.addEquipment (lance);
			Perceval.addEquipment (casque);
			Gladiator Karadoc = new Gladiator ("Karadoc");
			Karadoc.addEquipment (trident);
			Karadoc.addEquipment (casque);
			Team TableRonde = new Team ("la Table Ronde", "Le gras c'est la vie", Arthur);
			TableRonde.addGladiator (RoiArthur);
			TableRonde.addGladiator (Perceval);
			TableRonde.addGladiator (Karadoc);

			Fight Try = new Fight (CompagnieDeLAnneau, OrdreJedi);
			Try.beginFight ();
			Fight yolo = new Fight (GoT, TableRonde);
			yolo.beginFight ();

			// Begin tournament
			Tournament Colisee = new Tournament ();
			Colisee.addteam (CompagnieDeLAnneau);
			Colisee.addteam (OrdreJedi);
			Colisee.addteam (GoT);
			Colisee.addteam (TableRonde);
			Colisee.begin ();
		}
	}
}
