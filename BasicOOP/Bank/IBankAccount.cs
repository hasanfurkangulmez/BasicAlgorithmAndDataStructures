using System;
using System.Collections.Generic;
using System.Text;

namespace BasicAlgorithmAndDataStructures.BasicOOP.Bank
{
    public interface IBankAccount
    {
        void Deposit(decimal Amaount);
        bool Withdraw(decimal Amaount);
        decimal Balance { get; }
    }
}
