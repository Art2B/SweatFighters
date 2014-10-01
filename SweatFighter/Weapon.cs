using System;

namespace SweatFighter
{
	public class Weapon:Equipment
	{
		private int _init;
		private int _touchChance;
		private int _damage;

		public int init {
			get { return this._init;}
			set {
				if (value > 0) {
					this._init = value;
				} else {
					this._init = 0;
				}
			} 
		}
		public int touchChance {
			get { return this._touchChance;}
			set { 
				if (value > 0) {
					this._touchChance = value;
				} else {
					this._touchChance = 0;
				}			
			}
		}
		public int damage {
			get { return this._damage;}
			set { 
				if (value > 0) {
					this._damage = value;
				} else {
					this._damage = 0;
				}			
			}
		}

		public Weapon (string n_name, int n_cost, int n_init, int n_touch, int n_damage):base(n_name, n_cost){
			init = n_init;
			touchChance = n_touch;
			damage = n_damage;
		}
	}
}

