using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Service.Constracts
{
  public interface IAccountTypeService
  {
    public List<AccountType> GetAccountType();

    public AccountType GetAccountTypeByID(int id);

    public void SaveAccountType(AccountType accountType);

    public void UpdateAccountType(AccountType accountType);

    public void DeleteAccountType(AccountType accountType);
  }
}
