﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Service.Constracts
{
  public interface ITopicRegisterService
  {
    public List<TopicRegister> GetTopicRegister();

    public TopicRegister GetTopicRegisterByID(int id);

    public void SaveTopicRegister(TopicRegister TopicRegister);

    public void UpdateTopicRegister(TopicRegister TopicRegister);

    public void DeleteTopicRegister(TopicRegister TopicRegister);
  }
}
