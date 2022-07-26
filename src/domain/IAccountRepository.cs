namespace BankKata.Domain
{
    public interface IAccountRepository
    {
        void CreateDeposit(int amount);
    }
}
