using Domain.Models;

namespace Infrastructure.Services;

public interface IStudent_GroupServices
{
    List<Student_Group> GetStudent_Group();
    Student_Group GetStudent_GroupById(int id);
    string AddStudent_Group(Student_Group id);
    string UpdateStudent_Group(Student_Group id);
    bool DeleteStudent_Group(int id);
}
