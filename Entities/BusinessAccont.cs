namespace ContaBanco.Entities {
    sealed internal class BusinessAccount : Account {
        public float LoanLimit { get; set; }

        public BusinessAccount(int number, string holder, float balance, float loanLimit): base(number, holder, balance) {
            LoanLimit = loanLimit;
        }

        public void Loan(float amount) {
            if (amount <= LoanLimit) {
                Balance += amount;
            }
        }
    }
}

