using System;
using Ninja.Abstractions;

namespace Ninja.Domain
{
	public class Sword : IWeapon
	{
		public void Hit(string target)
		{
			Console.WriteLine("Chopped {0} clean in half", target);
		}
	}
}