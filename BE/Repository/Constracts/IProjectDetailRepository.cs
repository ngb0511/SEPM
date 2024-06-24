using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Service.Constracts
{
  public interface IProjectDetailService
  {
    public List<ProjectDetail> GetProjectDetail();

    public List<ProjectDetail> GetProjectDetailByID(int id);

    public void SaveProjectDetail(ProjectDetail projectDetail);

    public void UpdateProjectDetail(ProjectDetail projectDetail);

    public void DeleteProjectDetail(ProjectDetail projectDetail);
  }
}
