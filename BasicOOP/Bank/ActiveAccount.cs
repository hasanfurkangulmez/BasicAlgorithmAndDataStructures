using System;
using System.Collections.Generic;
using System.Text;

namespace BasicAlgorithmAndDataStructures.BasicOOP.Bank
{
    public class ActiveAccount : ITransfer
    {
        private decimal _Balance;

        public decimal Balance => _Balance;

        public void Deposit(decimal Amaount) => _Balance += Amaount;

        public bool MakeTransfer(IBankAccount RecipientAccount, decimal Amaount)
        {
            bool result = Withdraw(Amaount);
            if (result)
            {
                RecipientAccount.Deposit(Amaount);
            }
            return result;
        }

        public bool Withdraw(decimal Amaount)
        {
            if (_Balance >= Amaount)
            {
                _Balance -= Amaount;
                return true;
            }
            Console.WriteLine("\aInsufficient balance!");
            return false;
        }

        public override string ToString() => $"Active Account Balance Information {_Balance,6:C}";

    }
}
