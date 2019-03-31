using System;

namespace StateRealExample
{
    public class RedState : State
    {
        private double _serviceFee;

        public RedState(State state)
        {
            this._balance = state.Balance;
            this._account = state.Account;
            Initialize();
        }

        private void Initialize()
        {
            _interest = 0.0;
            _lowerLimit = -100.0;
            _upperLimit = 0.0;
            _serviceFee = 15.00;
        }

        public override void Deposit(double amount)
        {
            _balance = amount;
            StateChangeCheck();
        }

        public override void Withdraw(double amount)
        {
            amount = amount - _serviceFee;
            Console.WriteLine("No funds available for withdrawal!");
        }

        public override void PayInterest()
        {

        }

        private void StateChangeCheck()
        {
            if (_balance > _upperLimit)
            {
                _account.State = new SilverState(this);
            }
        }
    }
}