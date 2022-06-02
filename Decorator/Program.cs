using System;

namespace Decorator
{
    
    class Cook
    {
        public void CutSomething()
        {
            Console.WriteLine("Cut something");
        }
        public void Mix()
        {
            Console.WriteLine("mixing something");
        }
        public void TakeProduct()
        {
            Console.WriteLine("Taking something product");
        }
        public void PutInPot()
        {
            Console.WriteLine("Put something in put");
        }
    }
    class Stove
    {
        public void TurnOn(int i)
        {
            Console.WriteLine("Heating stove number:" + i);
        }

        public void TurnOf(int i)
        {
            Console.WriteLine("cool dawn stove number:" + i);
        }
    }
    class Pot
    {
        public void Open()
        {
            Console.WriteLine("opening");
        }
        public void Close()
        {
            Console.WriteLine("Closing");
        }
    }

    class MakeLunchFacade
    {
        Pot pot = new Pot();
        Stove stove = new Stove();
        Cook cook = new Cook();
        public MakeLunchFacade(Pot pot, Stove stove, Cook cook)
        {
            this.pot = pot;
            this.stove = stove;
            this.cook = cook;
        }
        public void Start()
        {
            stove.TurnOn(1);
            cook.TakeProduct();
           
        }

        public void Coking()
        {
            cook.CutSomething();
            pot.Open();
            cook.PutInPot();
            pot.Close();

        }

        public void Stop()
        {
            stove.TurnOf(1);
        }
    }

    class SmartHome
    {
        public void CreateLunch(MakeLunchFacade facade)
        {
            facade.Start();
            facade.Coking();
            facade.Stop();
        }
    }

        class main
    {
        static void Main(string[] args)
        {
            SmartHome smartHome = new SmartHome();
            Pot pot = new Pot();
            Stove stove = new Stove();
            Cook cook = new Cook();
            MakeLunchFacade makeLunchFacade = new MakeLunchFacade(pot, stove, cook);
            smartHome.CreateLunch(makeLunchFacade);

        }
    }
}
