using System;

namespace SweatFighter
{
	public class Equipment
	{
		protected int _cost;
		protected int _parryChance;
		protected string _name;

		public int cost {
			get { return this._cost;}
			set{
				if (value > 0) {
					this._cost = value;
				} else {
					this._cost = 1;
				}
			}
		}
		public int parryChance {
			get { return this._parryChance;}
			set { 
				if (value >= 0) {
					this._parryChance = value;
				} else {
					this._parryChance = 0;
				}
			}
		}
		public string name {
			get { 
				return this._name;
			}
			set { 
				if (value != String.Empty) {
					this._name = value;
				}			
			}
		}

		public Equipment (string n_name, int n_cost)
		{
			cost = n_cost;
			name = n_name;
			parryChance = 0;
		}

		public Equipment (string n_name, int n_cost, int n_parry):this(n_name, n_cost) {
			parryChance = n_parry;
		}
	}
}