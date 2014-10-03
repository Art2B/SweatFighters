using System;
using System.Collections.Generic;
using System.Linq;

namespace SweatFighter
{
	public class Tournament
	{
		// List Joueurs
		// List Equipe
		// Array Score

		private List<Player> _playerEngaged = new List<Player>();
		private List<Team> _teamEngaged  = new List<Team>(); 

		public List<Player> playerEngaged {
			get { return this._playerEngaged; }
		}
		public List<Team> teamEngaged {
			get { return this._teamEngaged; }
		}

		public Tournament ()
		{
		}
		 
		public void begin(){
			// Message to display team and Players
			Console.WriteLine ("\n\nDébut du tournoi !");

			this._teamEngaged = teamEngaged.OrderByDescending(o=>o.nbVictory).ToList();
			Console.WriteLine ("Voici les participants: ");
			foreach(Team b_team in teamEngaged){
				Console.WriteLine (b_team.name+" avec "+b_team.nbVictory+" victoires.");
			}
			this.round (teamEngaged);
		}

		public void round(List<Team> qualified){
			List <Team> qualifiedNextRound = new List<Team> ();

			for (int i = 1; i < qualified.Count; i+=2) {
				if (qualified [i] != null) {
					Console.WriteLine ("\n\n\n**********************");
					Fight combat = new Fight (qualified[i-1], qualified[i]);
					qualifiedNextRound.Add (combat.beginFight ());
				}
			}
			if (qualifiedNextRound.Count == 1) {
				Console.WriteLine ("\n\nVoici les gagnants du tournoi: "+qualifiedNextRound[0].name);
			} else {
				// Check if the number is pair and play on it if nope
				if (qualifiedNextRound.Count % 2 == 1) {
					List <Team> potentialSave = new List<Team> ();
					bool insertIntoPotential = true;
					foreach(Team b_team in qualified){
						foreach(Team b_quali in qualifiedNextRound){
							if (b_quali == b_team) {
								insertIntoPotential = false;
								break;						
							}
						}
						if (insertIntoPotential)
							potentialSave.Add (b_team);
					}
					Random random = new Random();
					int happyTeam = random.Next (0, potentialSave.Count);
					qualifiedNextRound.Add(potentialSave[happyTeam]);			
				}

				Console.WriteLine ("\n\nQualifiés pour le prochain tour");
				foreach (Team b_team in qualifiedNextRound) {
					Console.WriteLine (b_team.name);
				}
				this.round (qualifiedNextRound);
			}
		}

		public void addteam(Team n_team){
			this._teamEngaged.Add (n_team);
			bool playerToAdd = true;
			foreach(Player b_player in playerEngaged){
				playerToAdd = false;
				if (n_team.player == b_player) {
					break;
				}
				playerToAdd = true;
			}
			if (playerToAdd) {
				this._playerEngaged.Add (n_team.player);
			}
		}
	}
}

