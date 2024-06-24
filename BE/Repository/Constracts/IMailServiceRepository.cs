using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Constracts
{
  public interface IMailService
  {
    bool SendMail(MailData mailData);
  }
}
