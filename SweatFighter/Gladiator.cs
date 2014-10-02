using System;
using System.Collections.Generic;

namespace SweatFighter
{
	public class Gladiator:Fighters
	{
		private string _name;
		private List<Equipment> _inventory = new List<Equipment>();
		private int _equipmentPoints;
		private int _lifePoint;
		private Team _team;
		private Random random = new Random();

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
					this._name = "Gladiateur #"+random.Next(0, 10000).ToString();
				}
			}
		}
		public int lifePoint {
			get { return this._lifePoint; }
			set { 
				this._lifePoint = value;
			}
		}
		public Team team {
			get {return _team;}
			set { _team = value;}
		}

		public Gladiator (string n_name){
			name = n_name;
			equipmentPoints = 10;
			lifePoint = 1;
		}
			
		public void addEquipment(Equipment n_equip){
			if (equipmentPoints - n_equip.cost >= 0) {
				equipmentPoints -= n_equip.cost;
				this._inventory.Add (n_equip);
			} else {
				Console.WriteLine ("Vous ne pouvez pas vous équiper de "+n_equip.name);
			}
		}
		public bool attack(Gladiator target, Weapon armae){
			Console.WriteLine (this.name + " attaque " + target.name + " avec "+ armae.name);
			int diceRoll = this.random.Next (0, 100); // Roll the dice !!!
			if (diceRoll < armae.touchChance) {
				return true;
			} else {
				return false;
			}
		}
		public bool defend() {
			bool result = false;
			foreach (Equipment b_equip in this.inventory) {
				if (b_equip.parryChance > 0) {
					int diceRoll = this.random.Next (0, 100); // Roll the dice !!!
					if (diceRoll < b_equip.parryChance) {
						Console.WriteLine ("L'armure de "+this.name+" bloque le coup !");
						result = true;
					}
				}
			}
			return result;
		}
		public List<Weapon> weaponWithInit(int n_init){
			List<Weapon> weaponToUse = new List<Weapon>();
			foreach(Equipment b_equip in this.inventory){
				if (b_equip.GetType ().Name == "Weapon") {
					if (((Weapon)b_equip).init == n_init) {
						weaponToUse.Add((Weapon)b_equip);
					}
				}
			}
			return weaponToUse;
		}
	}
}

