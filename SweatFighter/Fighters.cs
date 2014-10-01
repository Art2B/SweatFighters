using System;

namespace SweatFighter
{
	public class Fighters
	{
		protected int _nbFights;
		protected int _nbVictory;

		public int nbFights {
			get { return this._nbFights;}
			set { 
				if (value == nbFights+1) {
					this._nbFights = value;
				}
			}
		}
		public int nbVictory {
			get { return this._nbVictory;}
			set { 
				if (value == nbVictory+1 && value <= nbFights) {
					this._nbVictory = value;
				}			
			}
		}

		public Fighters (){
			nbFights = 0;
			nbVictory = 0;
		}
		public int getNbLoose(){
			return nbFights - nbVictory;
		}
		public double getVictoryPercent(){
			return ((double)nbVictory/(double)nbFights) * 100;
		}
	}
}

