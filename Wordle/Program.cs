using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordle
{
	internal class Wordle
	{
		static void Main(string[] args)
		{
			string[] words = new string[] { "apple", "smile", "lucky", "light", "house", "chair" };
			Random random = new Random();
			int index = random.Next(words.Length);
			string randmword=words[index];
			Console.WriteLine("欢迎来玩Wordle游戏");
			Console.WriteLine("游戏中会随机生成一个五个字母组成的常见单词，玩家通过不断猜测来猜出所给单词");
			Console.WriteLine("游戏难度有easy和hard两种选择，请直接输入你的选择...");
			Console.WriteLine("(hard难度过难，这边还是建议输入easy喵...)");

			string s=Console.ReadLine();

			if (s == "easy") {
				Console.Clear();
				Console.WriteLine("果然还是来玩这个难度了吗，缺乏挑战心的家伙");
				Console.WriteLine("那好吧，在这难度中，当你随机输入一个单词时候");
				Console.WriteLine("我会告诉你，哪些字母本身正确且位置正确");
				Console.WriteLine("那我们开始吧！");
				while (true)
				{
					int q = 0;
					Console.Clear();
					Console.WriteLine("请输入：");
					string a=Console.ReadLine();
					//Console.WriteLine(a.Length);
					Console.WriteLine(" ");
					if (a.Length != 5)
					{
						Console.WriteLine("oi!你真是不听话，重来！");
						Console.WriteLine("请按Enter键继续...");
						Console.ReadKey();
						continue;
					}
					else
					{
						bool o = false;
						for(int i = 0; i <= 4; i++)
						{
							if (a[i] == randmword[i])
							{
								o = true;
								q++;
								Console.Write(a[i]);
								Console.Write("位于第");
								Console.Write(i+1);
								Console.Write("位是正确的  ");
								
							}
						}
						if (o && q != 5) { Console.WriteLine("请按Enter键继续..."); Console.ReadKey(); }
						
					}
					if (q == 0)
					{
						Console.WriteLine("可惜了，没有一个字母是本身正确且位置正确的,请按Enter键继续游戏...");
						Console.ReadKey();
						Console.Clear();
					}
					if (q == 5)
					{
						Console.Clear();
						Console.WriteLine("恭喜你啊！你猜对了，但没有奖励...");
						break;
					}
				}

			}
			else if (s == "hard") {
				Console.Clear();
				
				Console.WriteLine("桀桀桀，果然还是来玩这个难度了吗，勇敢的家伙");
				Console.WriteLine("在这个难度中，我不会给你任何提示，只要你输入的完全一致则游戏结束");
				
				Console.WriteLine("当然你要是害怕了就输入exit，重选难度吧");
				Console.WriteLine("那我们开始吧！");
				while (true)
				{
					Console.Clear();
					Console.WriteLine("请输入：");
					string ss=Console.ReadLine();
					if (ss == "exit")
					{
						Console.WriteLine("再见~");
						Console.ReadKey ();
						break;
					}
					if (ss.Length != 5)
					{
						Console.WriteLine("oi!你真是不听话，重来！");
					}
					else
					{
						int q = 0;
						for(int i = 0; i <= 4; i++)
						{
							if (ss[i] == randmword[i]) q++;
						}
						if (q == 5)
						{
							Console.Clear();
							Console.WriteLine("恭喜你啊！你猜对了，但没有奖励...");
							break;
						}
					}
				}
			}
			else
			{
				Console.Clear();
				Console.WriteLine("oi！，你没按照规则输入，不遵守规则的人还是先离开,再重新开始游戏吧");
			}
			Console.ReadKey();
		}
	}
}
