using Domain.Models;

namespace Infrastructure.Services;

public interface IMentor_CourseService
{
    List<Mentor_Course> GetMentor_Course();
    Mentor_Course GetMentor_CourseById(int id);
    string AddMentor_Course(Mentor_Course id);
    string UpdateMentor_Course(Mentor_Course id);
    bool DeleteMentor_Course(int id);
}
