using DAO;
using Entity;
using Service.Constracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{

  public class CurrentSubjectService : ICurrentSubjectService
  {
    public void DeleteCurrentSubject(CurrentSubject CurrentSubject) => CurrentSubjectDAO.DeleteCurrentSubject(CurrentSubject);

    public List<CurrentSubject> GetCurrentSubject() => CurrentSubjectDAO.GetCurrentSubject();

    public CurrentSubject GetCurrentSubjectByID(int id)
    {
      CurrentSubject CurrentSubject = new CurrentSubject();
      CurrentSubject = CurrentSubjectDAO.GetCurrentSubject().SingleOrDefault(p => p.StudentId == id);
      return CurrentSubject;
    }

    public void SaveCurrentSubject(CurrentSubject CurrentSubject) => CurrentSubjectDAO.SaveCurrentSubject(CurrentSubject);

    public void UpdateCurrentSubject(CurrentSubject CurrentSubject) => CurrentSubjectDAO.UpdateCurrentSubject(CurrentSubject);
  }
}
