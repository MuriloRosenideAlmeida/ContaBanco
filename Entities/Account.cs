namespace ContaBanco.Entities {
    internal class Account {
        public int Number { get; protected set; }
        public string Holder { get; protected set; }
        public float Balance { get; protected set; }

        public Account(int number, string holder, float balance) {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void Withdraw(float amont) {
            Balance = Balance - amont + 5.00f;
        }

        public void Deposit(float amont) {
            Balance = Balance + amont;
        }

    }
}
