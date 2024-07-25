namespace ContaBanco.Entities {
    sealed internal class SavingsAccont : Account {
        public float InterestRate { get; set; }
        public SavingsAccont(int number, string holder, float balance, float interestRate) : base (number, holder, balance) { 
            InterestRate = interestRate;
        }
        public void UpdateBalance() {
            Balance = Balance * InterestRate;
        }
        public override void Withdraw(float amont) {
            base.Withdraw(amont);
            Balance = Balance - 2.0f;
        }

    }

}

