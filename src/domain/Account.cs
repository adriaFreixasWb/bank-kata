namespace BankKata.Domain;
public class Account
{
    private readonly IAccountRepository _accountRepository;

    public Account(IAccountRepository accountRepository)
    {
        _accountRepository = accountRepository;
    }

    public void Deposit(int amount)
    {
        throw new NotImplementedException();
    }

    public void Withdraw(int amount)
    {
        throw new NotImplementedException();
    }

    public void PrintStatement()
    {
        throw new NotImplementedException();
    }
}
