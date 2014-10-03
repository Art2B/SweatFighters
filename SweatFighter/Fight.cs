
using System;
using System.Collections.Generic;
using System.Linq;

namespace SweatFighter
{
	public class Fight
	{
		private Team _firstOponent;
		private Team _secondOponent;

		private int firstFighterIndex = 0;
		private int secondFighterIndex = 0;

		public Team firstOponent {
			get {return _firstOponent;}
			set { _firstOponent = value;}
		}
		public Team secondOponent {
			get {return _secondOponent;}
			set { _secondOponent = value;}
		}

		public Fight (Team n_first, Team n_second){
			firstOponent = n_first;
			secondOponent = n_second;
		}

		public Team beginFight() {
			Console.WriteLine ("Le combat commence entre "+firstOponent.name+" et "+secondOponent.name);
			bool duelTime = true;
			Gladiator firstFighter = firstOponent.roster [this.firstFighterIndex];
			Gladiator secondFighter = secondOponent.roster[this.secondFighterIndex];
			bool result = false;

			while (duelTime) {
				firstFighter.nbFights++;
				secondFighter.nbFights++;
				while (firstFighter.lifePoint > 0 && secondFighter.lifePoint > 0) 
				{
					this.round (firstFighter, secondFighter);
				}
				if ((firstOponent.roster.Count>this.firstFighterIndex) && (secondOponent.roster.Count > this.secondFighterIndex)) {
					firstFighter = firstOponent.roster [this.firstFighterIndex];
					secondFighter = secondOponent.roster [this.secondFighterIndex];
				} else {
					if (this.firstFighterIndex > this.secondFighterIndex) {
						Console.WriteLine (secondOponent.name+" a gagné le combat !");
						result = true;
						firstOponent.nbFights++;
						secondOponent.nbFights++;
						secondOponent.nbVictory++;
					} else {
						Console.WriteLine (firstOponent.name+" a gagné le combat !");
						result = false;
						firstOponent.nbFights++;
						firstOponent.nbVictory++;
						secondOponent.nbFights++;
					}
					duelTime = false;
				}
			}
			// Heal Glad
			healteam (firstOponent);
			healteam (secondOponent);
			if (result == false) {
				return firstOponent;
			} else {
				return secondOponent;
			}
		}
		public void round(Gladiator firstFighter, Gladiator secondFighter){
			for (int i = 5; i >= 1; i--){
				bool needBreak = false;
				List<Weapon> firstList = firstFighter.weaponWithInit (i);
				List<Weapon> secondList = secondFighter.weaponWithInit (i);

				// Add some random in case of equality
				if (firstList.Any ()) {
					foreach(Weapon b_armae in firstList){
						if ((firstFighter.lifePoint > 0) && this.gladAttack (firstFighter, b_armae, secondFighter) && firstFighter.lifePoint>0) {
							needBreak = true;
							this.secondFighterIndex++;
							break;
						}
					}
				}
				if (secondList.Any ()) {
					foreach(Weapon b_armae in secondList){
						if ((secondFighter.lifePoint > 0) && this.gladAttack (secondFighter, b_armae, firstFighter)) {
							needBreak = true;
							this.firstFighterIndex++;
							break;
						}
					}
				}
				if (needBreak) {
					break;
				}
			}		
		}

		// Return true if defender is killed
		public bool gladAttack(Gladiator attack, Weapon attackWeapon, Gladiator defense){
			bool result = false;
			if (attack.attack (defense, attackWeapon)) {
				Console.WriteLine ("Le coup porte");
				if (!defense.defend ()) {
					Console.WriteLine (defense.name + " est hors combat.");
					defense.lifePoint = 0;
					attack.nbVictory++;
					result = true;
				}
			} else {
				Console.WriteLine ("Le coup rate.");
			}
			return result;
		}
		// Heal gladiators
		public void healteam(Team n_team){
			foreach (Gladiator glad in n_team.roster) {
				glad.lifePoint = 1;
			}
		}
	}
}