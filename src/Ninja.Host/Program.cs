using System;
using Ninja.Domain;

namespace Ninja.Host
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var warrior1 = new Samurai(new Shuriken());
			var warrior2 = new Samurai(new Sword());
			warrior1.Attack("the evildoers");
			warrior2.Attack("the evildoers");
			Console.ReadLine();
		}
	}
}