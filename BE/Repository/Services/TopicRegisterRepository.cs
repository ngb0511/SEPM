using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using Service.Constracts;

namespace Service.Services
{
  public class TopicRegisterService : ITopicRegisterService
  {
    public void DeleteTopicRegister(TopicRegister TopicRegister) => TopicRegisterDAO.DeleteTopicRegister(TopicRegister);

    public List<TopicRegister> GetTopicRegister() => TopicRegisterDAO.GetTopicRegister();

    public TopicRegister GetTopicRegisterByID(int id)
    {
      TopicRegister topic = new TopicRegister();
      topic = TopicRegisterDAO.GetTopicRegister().SingleOrDefault(p => p.TopicId == id);
      return topic;
    }

    public void SaveTopicRegister(TopicRegister TopicRegister) => TopicRegisterDAO.SaveTopicRegister(TopicRegister);

    public void UpdateTopicRegister(TopicRegister TopicRegister) => TopicRegisterDAO.UpdateTopicRegister(TopicRegister);
  }
}
