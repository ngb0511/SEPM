using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Service.Constracts
{
  public interface ICurrentSubjectService
  {
    public List<CurrentSubject> GetCurrentSubject();

    public CurrentSubject GetCurrentSubjectByID(int id);

    public void SaveCurrentSubject(CurrentSubject CurrentSubject);

    public void UpdateCurrentSubject(CurrentSubject CurrentSubject);

    public void DeleteCurrentSubject(CurrentSubject CurrentSubject);
  }
}
