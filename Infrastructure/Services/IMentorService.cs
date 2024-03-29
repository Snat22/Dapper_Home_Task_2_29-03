using Domain.Models;

namespace Infrastructure.Services;

public interface IMentorService
{
    List<Mentor> GetMentors();
    Mentor GetMentorById(int id);
    string AddMentor(Mentor mentor);
    string UpdateMentor(Mentor mentor);
    bool DeleteMentor(int id);
}
