using System;

namespace SweatFighter
{
	public class Filet:Weapon
	{
		private int _quantity;
		public int quantity {
			get { return this._quantity;}
			set { 
				this._quantity = value;
			}
		}

		public Filet (string n_name, int n_cost, int n_init, int n_touch, int n_damage):base(n_name, n_cost, n_init, n_touch, n_damage)
		{
			quantity = 1;
		}

		public object Clone()
		{
			return this.MemberwiseClone();
		}

		public void filetSpecial(Gladiator cible){
			quantity--;
			cible.touchByFilet = true;
		}
	}
}

