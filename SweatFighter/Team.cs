using System;
using System.Collections.Generic;

namespace SweatFighter
{
	public class Team:Fighters
	{
		private string _name;
		private string _description;
		private List<Gladiator> _roster = new List <Gladiator>();

		public string name {
			get { return this._name;}
			set { 
				if (value != String.Empty) {
					this._name = value;
				} else {
					Random random = new Random();
					this._name = "Equipe #"+random.Next(0, 1000).ToString();
				}
			}
		}
		public string description {
			get { return this._description;}
			set { 
				if (value != String.Empty) {
					this._description = value;
				} else {
					this._description = "Une des meilleures équipes du pays !";
				}
			}
		}
		public List<Gladiator> roster {
			get {
				return this._roster;
			}
		}

		public Team (string n_name, string n_description)
		{
			name = n_name;
			description = n_description;
		}
		public void addGladiator(Gladiator n_gladiator){
			if (n_gladiator.team==null) {
				n_gladiator.team = this;
				this._roster.Add (n_gladiator);
			} else {
				Console.WriteLine (n_gladiator.name+" est déjà dans une équipe !");
			}
		}
	}
}

