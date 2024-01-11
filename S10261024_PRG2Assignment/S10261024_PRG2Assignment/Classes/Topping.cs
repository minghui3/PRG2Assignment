namespace S10261024_PRG2Assignment.Classes
{
    class Topping
    {
        private string type;

        public string Type { get; set; }

        public Topping() { }

        public Topping(string type)
        {
            Type = type;
        }

        public override string ToString()
        {
            return $"Topping Class:\nType: {Type}\n\n";
        }
    }
}
