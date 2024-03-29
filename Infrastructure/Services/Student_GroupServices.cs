using Domain.Models;
using Dapper;
using Infrastructure.DapperContext;
namespace Infrastructure.Services;

public class Student_GroupServices :IStudent_GroupServices
{
    private readonly DapperConnection _context;
    public Student_GroupServices()
    {
        _context = new DapperConnection();
    }

    public string AddStudent_Group(Student_Group id)
    {
        var sql = $"Insert into student_groups(student_id,group_id) values({id.Student_Id},{id.Group_Id})";
        var inserted = _context.Connection().Execute(sql);
        if(inserted > 0) return "Added Uspeshno";
        return "Error";
    }

    public List<Student_Group> GetStudent_Group()
    {
        var sql = "Select * from student_group";
        var selected = _context.Connection().Query<Student_Group>(sql).ToList();
        return selected;
    }

    public Student_Group GetStudent_GroupById(int id)
    {
        var sql = $"Select * from student_group where id = {@id}";
        var selected = _context.Connection().QueryFirstOrDefault(sql);
        return selected;
    }

    public string UpdateStudent_Group(Student_Group id)
    {
        var sql = $"Update student_group set student_id = {id.Student_Id},group_id = {id.Group_Id}";
        var updated = _context.Connection().Execute(sql);
        if (updated > 0) return "Updated Uspehno";
        return "Error";
    }
    public bool DeleteStudent_Group(int id)
    {
        var sql = $"Delete from student_groups where id = {@id}";
        var deleted = _context.Connection().Execute(sql);
        if (deleted > 0) return true;
        return false;
    }

    
}
