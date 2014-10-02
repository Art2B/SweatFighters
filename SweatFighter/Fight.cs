
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

		public void beginFight() {
			Console.WriteLine ("Le combat commence entre "+firstOponent.name+" et "+secondOponent.name);
			bool cLheureDuDuDuDuDuDuDuel = true;
			Gladiator firstFighter = firstOponent.roster [this.firstFighterIndex];
			Gladiator secondFighter = secondOponent.roster[this.secondFighterIndex];
			// Ceci représente les passes d'armes
			while (cLheureDuDuDuDuDuDuDuel) {
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
						firstOponent.nbFights++;
						secondOponent.nbFights++;
						secondOponent.nbVictory++;
					} else {
						Console.WriteLine (firstOponent.name+" a gagné le combat !");
						firstOponent.nbFights++;
						firstOponent.nbVictory++;
						secondOponent.nbFights++;
					}
					cLheureDuDuDuDuDuDuDuel = false;
				}
			}
			foreach (Gladiator glad in firstOponent.roster) {
				glad.lifePoint = 1;
			}
			foreach (Gladiator glad in secondOponent.roster) {
				glad.lifePoint = 1;
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
					Console.WriteLine ("On stop le duel");
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
	}
}