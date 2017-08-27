using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Sample101{
	class Program{
		static void Main(string[] args){
			Player p1 = new Player("太郎");
			Player p2 = new Player("次郎");
			Console.WriteLine(hantei(p1,p2));
		}

		static string hantei(Player PersonA, Player PersonB){
			
			string[] hands = new string[]{"ぐー","ちょき","ぱー"};
			string result="---";
			int PersonAhand = PersonA.pon();
			int PersonBhand = PersonB.pon();
			Console.WriteLine(PersonA.getName()+":"+hands[PersonAhand]);
			Console.WriteLine(PersonB.getName()+":"+hands[PersonBhand]);
					
			if(PersonAhand==PersonBhand){
				result = "あいこ";
			}else if(PersonAhand==2){
				if(PersonBhand==0){
	 				result = PersonA.getName()+"の勝ち";
				}else{
	 				result = PersonB.getName()+"の勝ち";
				}
			}else if(PersonAhand+1==PersonBhand){
				result = PersonA.getName()+"の勝ち";
			}else{
				result = PersonB.getName()+"の勝ち";
			}
			return "結果："+result;
		}
	}

	class Player{
		private string name;
		private static System.Random r = new System.Random();
		
		public Player(string playerName){
			this.name = playerName;
		}
		public int pon(){
			return r.Next(3);
		}
		public string getName(){
			return this.name;
		}
	}
}
