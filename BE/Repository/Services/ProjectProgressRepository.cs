using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAO;
using Service.Constracts;

namespace Service.Services
{
  public class ProjectProgressService : IProjectProgressService
  {
    public void DeleteProjectProgress(ProjectProgress projectProgress) => ProjectProgressDAO.DeleteProjectProgress(projectProgress);

    public List<ProjectProgress> GetProjectProgress() => ProjectProgressDAO.GetProjectProgress();

    public ProjectProgress GetProjectProgressByID(int id)
    {
      ProjectProgress projectProgress = new ProjectProgress();
      projectProgress = ProjectProgressDAO.GetProjectProgress().SingleOrDefault(p => p.ProjectId == id);
      return projectProgress;
    }

    public List<ProjectProgress> GetProjectProgressByProjectID(int id)
    {
      IEnumerable<ProjectProgress> projectProgress = ProjectProgressDAO.GetProjectProgress().Where(p => p.ProjectId == id);
      List<ProjectProgress> listprojectProgress = projectProgress.ToList();
      return listprojectProgress;
    }

    public void SaveProjectProgress(ProjectProgress projectProgress) => ProjectProgressDAO.SaveProjectProgress(projectProgress);

    public void UpdateProjectProgress(ProjectProgress projectProgress) => ProjectProgressDAO.UpdateProjectProgress(projectProgress);
  }
}
