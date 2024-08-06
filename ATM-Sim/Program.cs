using ATM_Sim.Model;

Console.OutputEncoding = System.Text.Encoding.UTF8;

// User creates account at bank
var account = new Account();

// User inserts card
var atm = new Atm(account);
atm.ShowScreen();

// User chooses to view money
atm.ShowMoney();
