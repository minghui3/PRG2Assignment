namespace S10261024_PRG2Assignment.Classes
{
    class Order
    {
        private int id;
        private DateTime timeReceived;
        private DateTime? timeFulfilled;
        private List<IceCream> iceCreamList;

        public int ID { get; set; }
        public DateTime TimeReceived { get; set; }
        public DateTime? TimeFulfilled { get; set; }
        public List<IceCream> IceCreamList { get; set; }

        public Order() { }

        public Order(int id, DateTime time)
        {
            ID = id;
            TimeReceived = time;
            TimeFulfilled = null;
            IceCreamList = new List<IceCream>();
        }

        public void ModifyIceCream(int index)
        { 
            IceCream target = IceCreamList[index];

            //Code to modify ice cream object
        }

        public void AddIceCream(IceCream ic)
        {
            IceCreamList.Add(ic);
        }

        public void DeleteIceCream (int index)
        {
            IceCreamList.RemoveAt(index);
        }

        public double CalculateTotal()
        {
            double amount = 0;

            foreach (IceCream ic in IceCreamList)
            {
                amount += ic.CalculatePrice();
            }

            return amount;
        }

        public override string ToString()
        {
            return $"Order Variable:\nID: {ID}\nTime Received: {TimeReceived}\nTime Fulfilled: {TimeFulfilled}\nIce Cream List: {String.Join(", ", IceCreamList)}\n\n";
        }

    }
}
