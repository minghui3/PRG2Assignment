using System.Reflection.Metadata.Ecma335;

namespace S10261024_PRG2Assignment.Classes
{
    class Flavour
    {
        private string type;
        private bool premium;
        private int quantity;

        public string Type { get; set; }
        public bool Premium { get; set; }
        public int Quantity { get; set; }

        public Flavour() { }

        public Flavour(string type, bool premium, int quantity)
        {
            Type = type;
            Premium = premium;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return $"Flavour Variable:\nType: {Type}\nPremium: {Premium}\nQuantity: {Quantity}\n\n";
        }
    }
}
