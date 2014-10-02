using System;
using System.Collections.Generic;

namespace SweatFighter
{
	public class Player
	{
		private string _lastName;
		private string _firstName;
		private string _pseudo;
		private DateTime _inscription;
		private List<Team> _teamList = new List <Team>();

		public string lastName {
			get { return this._lastName; }
			set { 
				if(value != String.Empty){
					this._lastName = value;
				}
			}
		}
		public string firstName {
			get { return this._firstName; }
			set { 
				if(value != String.Empty){
					this._firstName = value;
				}
			}
		}
		public string pseudo {
			get { return this._pseudo; }
			set { 
				if(value != String.Empty){
					this._pseudo = value;
				}
			}
		}
		public DateTime inscription {
			get { return this._inscription;}
			set { this._inscription = value;} 
		}
		public List<Team> teamList {
			get { return this._teamList;}
		}

		public Player (string n_firstName, string n_lastName, string n_pseudo)
		{
			firstName = n_firstName;
			lastName = n_lastName;
			pseudo = n_pseudo;
			inscription = DateTime.Now;
		}

		public void addTeam(Team n_team){
			if (teamList.Count >= 5) {
				Console.WriteLine (this.pseudo+" a atteint son nombre maximum d'équipes.");
			} else if (n_team.player!=null) {
				Console.WriteLine (n_team.name+" appartient déjà au joueur "+n_team.player.pseudo);
			} else {
				n_team.player = this;
				teamList.Add (n_team);
			}
		}
	}
}

