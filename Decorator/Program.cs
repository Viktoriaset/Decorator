using System;

namespace Decorator
{

	public abstract class CaffeineBeverage
	{
		protected void prepare()
		{
			boilWater();
			brew();
			pourInCup();
			if (customerWantsCondiments())
			{
				addCondiments();
			}
		}

		void boilWater()
		{
			Console.WriteLine("Boil water");
		}
		public abstract void brew();
		void pourInCup()
		{
			Console.WriteLine("Pour in cup");
		}
		public abstract void addCondiments();

		public virtual bool customerWantsCondiments()
		{
			return true;
		}
	}


	public class Coffe : CaffeineBeverage
	{
		public Coffe()
		{
			this.prepare();
		}

		public override void brew()
		{
			Console.WriteLine("Brew coffe");
		}
		public override void addCondiments()
		{
			Console.WriteLine("Add cream");
		}
	}


	public class Tea : CaffeineBeverage
	{
		public Tea()
		{
			prepare();
		}
		public override void brew()
		{
			Console.WriteLine("Brew Tea");
		}
		public override void addCondiments()
		{
			Console.WriteLine("Add milk");
		}
	}


	public class DarkCoffe : Coffe
	{

		public override bool customerWantsCondiments()
		{
			return false;
		}
	}

	public class MyCoffe : Coffe
	{
		private bool isCondimentsRequired;


		public MyCoffe(bool isCondimentsRequired)
		{
			this.isCondimentsRequired = isCondimentsRequired;
			prepare();
		}


		public override bool customerWantsCondiments()
		{
			return isCondimentsRequired;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			//Coffe coffe = new Coffe();
			//MyCoffe mycoffe = new MyCoffe(true);
			//DarkCoffe darkCoffe = new DarkCoffe();
			Tea tea = new Tea();
		}
	}
}