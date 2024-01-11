namespace S10261024_PRG2Assignment.Classes
{
    class Cone : IceCream
    {
        private bool dipped;

        public bool Dipped;

        public Cone() { }

        public Cone(string opt, int scoops, List<Flavour> fList, List<Topping> tList, bool dipped) : base(opt, scoops, fList, tList)
        {
            Dipped = dipped;
        }

        public override double CalculatePrice()
        { 
            //Scoops
            double price = (Scoops == 1) ? 4 : (Scoops == 2) ? 5.5 : 6;

            //Chocolate-dipped
            if (dipped) price += 2;

            //Premium flavour
            price += Flavours.Where(f => f.Premium).Sum(f => f.Quantity * 2);

            //Toppings
            price += Toppings.Count();

            return price;
        }

        public override string ToString()
        {
            return "Cone Variable:\n" + base.ToString() + $"\nDipped: {Dipped}\n\n";
        }
    }
}
