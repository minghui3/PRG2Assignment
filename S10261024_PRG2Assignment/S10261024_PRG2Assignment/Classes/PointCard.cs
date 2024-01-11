namespace S10261024_PRG2Assignment.Classes
{
    class PointCard
    {
        private int points;
        private int punchCard;
        private string tier;

        public int Points { get; set; }
        public int PunchCard { get; set; }
        public string Tier { get; set; }

        public PointCard() { }

        public PointCard(int p, int pCard)
        {
            Points = p;
            PunchCard = pCard;

            //Default is "Ordinary". "Silver" once points hit 50. "Gold" once points hit 100.
            //Cannot drop down to a lower tier even if their points are used up.

            if (p >= 100)
            {
                Tier = "Gold";
            }
            else if (p >= 50)
            {
                Tier = "Silver";
            }
            else
            {
                Tier = "Ordinary";
            }
        }

        public void AddPoints(int points)
        {
            //Point conversion is 72% of the total amount paid rounded down to the nearest integer.

            Points += points;
        }

        public void RedeemPoints(int points)
        {
            //1 point = $0.02

            Points -= points;
        }

        public void Punch()
        {
            //Punch() for each ice cream

            PunchCard++;
        }

        public override string ToString()
        {
            return $"PointCard Variable:\nPoints: {Points}\nPunchCard: {PunchCard}\nTier: {Tier}\n\n";
        }
    }
}
