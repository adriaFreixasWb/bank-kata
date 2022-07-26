using BankKata.Domain;
using Moq;
using Xunit;

namespace BankKata.Test.Units
{
    public class AccountShould
    {
        private readonly Account _account;
        private readonly Mock<IAccountRepository> _repository;
        public AccountShould()
        {
            _account = new Account();
            _repository = new Mock<IAccountRepository>();
        }

         
        [Fact]
        public void Store_A_Deposit_Transaction()
        {
            _account.Deposit(100);
            _repository.Verify(x => x.CreateDeposit(100));

        }
    }
}
