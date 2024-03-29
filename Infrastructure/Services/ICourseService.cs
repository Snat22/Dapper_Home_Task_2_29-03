using Domain.Models;

namespace Infrastructure.Services;

public interface ICourseService
{
    List<Course> GetCourses();
    Course GetCourseById(int id);
    string AddCourse(Course course);
    string UpdateCourse(Course course);
    bool DeleteCourse(int id);
}
