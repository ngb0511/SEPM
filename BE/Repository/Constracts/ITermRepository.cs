using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Service.Constracts
{
  public interface ITermService
  {
    public List<Term> GetTerm();

    public Term GetTermByID(int id);

    public void SaveTerm(Term term);

    public void UpdateTerm(Term term);

    public void DeleteTerm(Term term);
  }
}
