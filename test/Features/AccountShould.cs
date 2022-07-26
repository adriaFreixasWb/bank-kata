using BankKata.Domain;
using Moq;
using Xunit;

namespace BankKata.Test.Features
{
    public class AccountShould
    {
        private readonly Account _account;
        private readonly Mock<IConsole> _console;

        public AccountShould()
        {
            _account = new Account();
            _console = new Mock<IConsole>();
        }
        [Fact]
        public void Print_Statement_Containing_All_Transactions()
        {
            _account.Deposit(1000);
            _account.Withdraw(100);
            _account.Deposit(500);

            _account.PrintStatement();
            _console.Verify(x => x.PrintLine("DATE | AMOUNT | BALANCE"));
            _console.Verify(x => x.PrintLine("10/04/2022 | 500 | 1400"));
            _console.Verify(x => x.PrintLine("02/04/2022 | -100 | 900"));
            _console.Verify(x => x.PrintLine("01/04/2022 | 1000 | 1000"));
        }
    }
}
