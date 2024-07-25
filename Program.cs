using ContaBanco.Entities;

namespace ContaBanco {
    internal class Program {
        static void Main(string[] args) {
            BusinessAccount businesaccount = new BusinessAccount(1002, "Maria", 0.0f, 500.0f);
        
            //Upcasting
            Account account1 = businesaccount;
            Account account2 = new BusinessAccount(1003, "Pedro", 0.0f, 200.0f);
            Account account3 = new SavingsAccont(1004, "Ana", 0.0f, 15.0f);

            //Downcasting
            BusinessAccount account4 = (BusinessAccount)account2;
            account4.Loan(100.0f);

            //Test whether casting is really possible
            if (account3 is BusinessAccount) {
                BusinessAccount account5 = (BusinessAccount)account3;
                account5.Loan(200.00f);
                Console.WriteLine("Loan complete");

            }
            if(account3 is SavingsAccont) {
                SavingsAccont account5 = (SavingsAccont)account3;
                account5.UpdateBalance();
                Console.WriteLine("Update Complete");
            }
            //Override
            Account account6 = new Account(1006, "Kleber", 100.0f);
            Account account7 = new SavingsAccont(1007, "Claudia", 100.0f, 0.01f);

            //Test Override
            account6.Withdraw(10.00f);
            account7.Withdraw(10.00f);
            Console.WriteLine(account6.Balance);
            Console.WriteLine(account7.Balance);
        }
    }
}