using System;

namespace SweatFighter
{
	public class Equipment
	{
		protected int cost;
		protected int parryChance;

		public int costPublic {
			get { 
				return this.cost;
			}
			set{}
		}
		public int parryPublic {
			get { 
				return this.parryChance;
			}
			set { }
		}

		public Equipment (int n_cost)
		{
			this.cost = n_cost;
			this.parryChance = 0;
		}

		public Equipment (int n_cost, int n_parry):this(n_cost) {
			this.parryChance = n_parry;
		}
	}
}

