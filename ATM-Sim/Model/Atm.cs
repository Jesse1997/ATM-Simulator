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
            Console.Write(
            $"---------ATM----------\n" +
            $"|  0 - Exit          |\n" +
            $"|  1 - View Money    |\n" +
            $"|  2 - Deposit Money |\n" +
            $"-------------------\n");
        }

        public int ReceiveInput(int input)
        {
            switch (input)
            {
                case 0:
                    Console.Write("Have a nice day!\n");
                    break;
                case 1:
                    ShowMoney();
                    break;
                case 2:
                    ShowDepositScreen();
                    break;
            }
            return input;
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

            Console.Write($"Current money: €{currentMoney}\n");
        }

        public void ShowDepositScreen()
        {
            Console.Write("Enter the amount you want to deposit (0.01 - 1000): €");
            var input = Console.ReadLine();

            try
            {
                var moneyToDeposit = Convert.ToDouble(input);

                if (moneyToDeposit < 0.01 || moneyToDeposit > 1000)
                {
                    Console.WriteLine("Enter a valid amount between 0,01 and 1000");
                    return;
                }
                DepositMoney(moneyToDeposit);
            }
            catch
            {
                Console.WriteLine("Enter a valid amount between 0,01 and 1000");
            }
        }

        public void DepositMoney(double moneyToDepositInEuros)
        {
            if (_account is null)
            {
                Console.WriteLine("Current account details not found... Try again later");
                return;
            }

            var moneyToDepositInCents = moneyToDepositInEuros.EurosToCents();
            _account.AddMoney(moneyToDepositInCents);
            Console.Write($"You've added €{moneyToDepositInEuros.EurosToString()} to your account!\n");
            ShowMoney();
        }
    }
}
