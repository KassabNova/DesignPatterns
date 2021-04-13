namespace ProjectTerm3
{
    public class State
    {
        public string stringVal { get; set; }
        public string accountName { get; set; }
        public double money { get; set; }
        public State(string accountName, double money)
        {
            this.accountName = accountName;
            this.money = money;
        }
        public State(State state)
        {
            this.accountName = state.accountName;
            this.money = state.money;
        }
    }
}