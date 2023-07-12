using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public class AccountFactory
    {
        public Account CreateAccount(string requestedAccount)
        {
            Account account;
            if (requestedAccount == "Savings") {
                
                account = new SavingsAccount();
            }
            else if (requestedAccount == "Loan")
            {
                account = new LoanAccount();
            }
            else
            {
                throw new ArgumentException();
            }

            return account;
        }


    }

    //interface IAccount
    //{
    //    void CreateAccount();
    //}

    public abstract class Account//: IAccount
    {
        public string AccountId { get; set; }
        public float Balance { get; set; }

        public abstract void CreateAccount();
    }

    public class SavingsAccount: Account {
        public override void CreateAccount()
        {
            throw new NotImplementedException();
        }
    }

    public class LoanAccount: Account
    {
        public override void CreateAccount()
        {
            throw new NotImplementedException();
        }
    }
}
