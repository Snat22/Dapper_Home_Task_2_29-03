using Domain.Models;

namespace Infrastructure.Services;

public interface ICourse_GroupServices
{
    List<Course_Groups> GetCourse_Groups();
    Course_Groups GetCourse_GroupsById(int id);
    string AddCourse_Group(Course_Groups id);
    string UpdateCourse_Group(Course_Groups id);
    bool DeleteCourse_Group(int id);
}
