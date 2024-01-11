namespace S10261024_PRG2Assignment.Classes
{
    abstract class IceCream
    {
        private string option;
        private int scoops;
        private List<Flavour> flavours;
        private List<Topping> toppings;

        public string Option { get; set; }
        public int Scoops { get; set; }
        public List<Flavour> Flavours { get; set; }
        public List<Topping> Toppings { get; set; }

        public IceCream() { }

        public IceCream(string opt, int scoops, List<Flavour> fList, List<Topping> tList)
        {
            Option = opt;
            Scoops = scoops;
            Flavours = fList;
            Toppings = tList;
        }

        public abstract double CalculatePrice();

        public override string ToString()
        {
            string f = String.Join(", ", Flavours);
            string t = String.Join(", ", Toppings);
            return $"Option: {Option}\nScoops: {Scoops}\nFlavours: {f}\nToppings: {t}";
        }
    }
}
