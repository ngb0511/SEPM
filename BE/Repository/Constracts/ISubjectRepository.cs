using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Constracts
{
  public interface ISubjectService
  {
    public List<Subject> GetSubject();

    public Subject GetSubjectByID(int id);

    public void SaveSubject(Subject subject);

    public void UpdateSubject(Subject subject);

    public void DeleteSubject(Subject subject);

    public Subject GetSubjectByName(string subjectName);
  }
}
