using ATM_Sim.Extensions;
using ATM_Sim.Helpers;

namespace ATM_Sim.Model
{
    public class Atm
    {
        private Account? _account { get; set; }

        public Atm(Account account)
        {
            _account = account;
        }

        public void ShowScreen()
        {
            Console.Write($"--------ATM--------\n" +
            $"|  1 - View Money |\n" +
            $"-------------------\n");
        }

        public void ShowMoney()
        {
            if (_account is null)
            {
                Console.WriteLine("Current account details not found... Try again later");
                return;
            }

            var moneyInCents = _account.GetMoney();
            var moneyInEuros = moneyInCents.ConvertCentsToEuros();
            var currentMoney = moneyInEuros.EurosToString();

            Console.WriteLine($"Current money: €{currentMoney}");
        }
    }
}
