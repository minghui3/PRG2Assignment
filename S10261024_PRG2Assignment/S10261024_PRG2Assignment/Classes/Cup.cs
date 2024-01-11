namespace S10261024_PRG2Assignment.Classes
{
    class Cup : IceCream
    {
        public Cup() { }

        public Cup(string opt, int scoops, List<Flavour> fList, List<Topping> tList) : base(opt, scoops, fList, tList) { }

        public override double CalculatePrice()
        {
            //Scoops
            double price = (Scoops == 1) ? 4 : (Scoops == 2) ? 5.5 : 6;

            //Premium flavour
            price += Flavours.Where(f => f.Premium).Sum(f => f.Quantity * 2);

            //Toppings
            price += Toppings.Count();

            return price;
        }

        public override string ToString()
        {
            return "Cup Variable:\n" + base.ToString() + "\n\n";
        }

    }
}
