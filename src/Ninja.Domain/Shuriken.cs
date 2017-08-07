using System;
using Ninja.Abstractions;

namespace Ninja.Domain
{
	public class Shuriken : IWeapon
	{
		public void Hit(string target)
		{
			Console.WriteLine("Pierced {0}'s armor", target);
		}
	}
}