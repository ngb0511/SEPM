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

  public class RegisterCalendarService : IRegisterCalendarService
  {
    public void DeleteRegisterCalendar(RegisterCalendar registerCalendar) => RegisterCalendarDAO.DeleteRegisterCalendar(registerCalendar);

    public List<RegisterCalendar> GetRegisterCalendar() => RegisterCalendarDAO.GetRegisterCalendar();

    public RegisterCalendar GetRegisterCalendarBySemesterAndYear(RegisterCalendar registerCalendar)
    {
      RegisterCalendar topic = new RegisterCalendar();
      topic = RegisterCalendarDAO.GetRegisterCalendar().SingleOrDefault(p => p.Semester == registerCalendar.Semester && p.Ryear == registerCalendar.Ryear);
      return topic;
    }

    public void SaveRegisterCalendar(RegisterCalendar registerCalendar) => RegisterCalendarDAO.SaveRegisterCalendar(registerCalendar);

    public void UpdateRegisterCalendar(RegisterCalendar registerCalendar) => RegisterCalendarDAO.UpdateRegisterCalendar(registerCalendar);
  }
}
