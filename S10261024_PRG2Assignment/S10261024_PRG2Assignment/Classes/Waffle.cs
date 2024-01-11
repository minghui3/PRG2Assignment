namespace S10261024_PRG2Assignment.Classes
{
    class Waffle : IceCream
    {
        private string waffleFlavour;

        public string WaffleFlavour { get; set; }

        public Waffle() { }

        public Waffle(string opt, int scoops, List<Flavour> fList, List<Topping> tList, string wFlavour) : base(opt, scoops, fList, tList)
        {
            WaffleFlavour = wFlavour;
        }

        public override double CalculatePrice()
        {
            //Scoops
            double price = (Scoops == 1) ? 7 : (Scoops == 2) ? 8.5 : 9.5;

            //Waffle Flavour
            if (WaffleFlavour != "Original") price += 3;

            //Premium Flavours
            price += Flavours.Where(f => f.Premium).Sum(f => f.Quantity * 2);

            //Toppings
            price += Toppings.Count();

            return price;
        }
    }
}
