using System;
using System.Collections.Generic;
using System.Text;

namespace BasicAlgorithmAndDataStructures.BasicOOP.Bank
{
    public interface ITransfer : IBankAccount
    {
        bool MakeTransfer(IBankAccount RecipientAccount, decimal Amaount);
    }
}
