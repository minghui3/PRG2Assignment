namespace S10261024_PRG2Assignment.Classes
{
    class Customer
    {
        private string name;
        private int memberId;
        private DateTime dob;
        private Order currentOrder;
        private List<Order> orderHistory;
        private PointCard rewards;
        public string Name { get; set; }
        public int MemberId { get; set; }
        public DateTime DOB { get; set; }
        public Order CurrentOrder { get; set; }
        public List<Order> OrderHistory { get; set; }
        public PointCard Rewards { get; set; }

        public Customer() { }

        public Customer(string name, int id, DateTime dob)
        {
            Name = name; 
            MemberId = id;
            DOB = dob;

            //need to double check these

            CurrentOrder = new();
            OrderHistory = new();
            Rewards = new();
        }

        public Order MakeOrder()
        {
            //code to get user input
            
            return;
        }

        public bool IsBirthday()
        {
            DateTime now = DateTime.Now;

            if (now.Month == DOB.Month && now.Day == DOB.Day)
            {
                return true;
            }

            return false; 
        }

        public override string ToString()
        {
            return $"Customer Variable:\nName: {Name}\nMemberId: {MemberId}\nDOB: {dob.Date}\nCurrent Order: {CurrentOrder}\nOrder History: {OrderHistory}\nRewards: {Rewards}\n\n";
        }
    }
}
