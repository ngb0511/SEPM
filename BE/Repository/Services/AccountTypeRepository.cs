using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAO;
using Service.Constracts;

namespace Service.Services
{
  public class AccountTypeService : IAccountTypeService
  {
    public void DeleteAccountType(AccountType accountType) => AccountTypeDAO.DeleteAccountType(accountType);

    public List<AccountType> GetAccountType() => AccountTypeDAO.GetAccountType();

    public AccountType GetAccountTypeByID(int id)
    {
      AccountType accountType = new AccountType();
      accountType = AccountTypeDAO.GetAccountType().SingleOrDefault(p => p.AccountTypeId == id);
      return accountType;
    }

    public void SaveAccountType(AccountType accountType) => AccountTypeDAO.SaveAccountType(accountType);

    public void UpdateAccountType(AccountType accountType) => AccountTypeDAO.UpdateAccountType(accountType);
  }
}
