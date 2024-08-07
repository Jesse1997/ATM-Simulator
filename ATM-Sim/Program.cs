using ATM_Sim.Model;

Console.OutputEncoding = System.Text.Encoding.UTF8;

// User creates account at bank
var account = new Account();

// User inserts card
var atm = new Atm(account);

// User gives input
int option;
do
{
    atm.ShowScreen();
    var input = Convert.ToInt32(Console.ReadLine());
    option = atm.ReceiveInput(input);
}
while (option != 0);
