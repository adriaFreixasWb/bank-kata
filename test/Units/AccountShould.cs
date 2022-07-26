using BankKata.Domain;
using Moq;
using Xunit;

namespace BankKata.Test.Units
{
    public class AccountShould
    {
        private readonly Account _account;
        private readonly Mock<IAccountRepository> _accountRepository;
        public AccountShould()
        {

            _accountRepository = new Mock<IAccountRepository>();
            _account = new Account(_accountRepository.Object);
            _accountRepository = new Mock<IAccountRepository>();
        }

         
        [Fact]
        public void Store_A_Deposit_Transaction()
        {
            _account.Deposit(100);
            _accountRepository.Verify(x => x.CreateDeposit(100));

        }
    }
}
