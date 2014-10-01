using System;
using System.Collections.Generic;

namespace SweatFighter
{
	public class Gladiator:Fighters
	{
		private string _name;
		private List<Equipment> _inventory = new List<Equipment>();
		private int _equipmentPoints;

		public List<Equipment> inventory {
			get {
				return this._inventory;
			}
		}
		public int equipmentPoints {
			get { return this._equipmentPoints;}
			set {
				this._equipmentPoints = value;
			}
		}
		public string name {
			get {return this._name;}
			set {
				if(value != String.Empty){
					this._name = value;
				} else {
					Random random = new Random();
					this._name = "Gladiator #"+random.Next(0, 10000).ToString();
				}
			}
		}


		public Gladiator (string n_name){
			name = n_name;
			equipmentPoints = 10;
		}
			
		public void addEquipment(Equipment n_equip){
			if (equipmentPoints - n_equip.cost >= 0) {
				equipmentPoints -= n_equip.cost;
				this._inventory.Add (n_equip);
			} else {
				Console.WriteLine ("Vous n'avez pas assez de points d'équipements pour vous équiper de "+n_equip.name);
			}
		}
	}
}

