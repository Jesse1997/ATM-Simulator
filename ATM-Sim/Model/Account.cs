namespace ATM_Sim.Model
{
    public class Account
    {
        private int _moneyInCents { get; set; }

        public Account()
        {
            _moneyInCents = 0;
        }

        public int GetMoney() => _moneyInCents;
        public void AddMoney(int money) => _moneyInCents += money;
    }
}
