using Domain.Models;
using Dapper;
using Infrastructure.DapperContext;
namespace Infrastructure.Services;

public class StudentService : IStudentService
{
    private readonly DapperConnection _context;
    public StudentService()
    {
        _context = new DapperConnection();
    }

    public string AddStudent(Student student)
    {
        var sql = $"Insert into student (firstname,lastnamr,age,address,email)"+
                $"values('{student.FirstName}','{student.LastName}',{student.Age},'{student.Address}','{student.Email}')";
                var inserted = _context.Connection().Execute(sql);
                if(inserted > 0)return "Added Succsefully";
                return "Error";
    }

    public List<Student> GetStudents()
    {
        var sql = "Select * from student";
            var selected = _context.Connection().Query<Student>(sql).ToList();
            return selected;
    }

    public Student GetStudentById(int id)
    {
        var sql = $"Select * from student where id={@id}";
        var selected = _context.Connection().QueryFirstOrDefault(sql);
        return selected;
        
    }

    public string UpdateStudent(Student student)
    {
        var sql = $"Update student set fristname = {student.FirstName},lastnamr = {student.LastName}, age = {student.Age},address = {student.Address},email = {student.Email}";
        var updated = _context.Connection().Execute(sql);
        if (updated > 0) return "Updated Uspehno";
        return "Error";
    }

    public bool DeleteStudent(int id)
    {
        var sql = $"Delete from student where id = {@id}";
        var deleted = _context.Connection().Execute(sql);
         if (deleted > 0) return true;
         return false;
    }


}
