using Domain.Models;
using Dapper;
using Infrastructure.DapperContext;
namespace Infrastructure.Services;

public class Course_GroupServices : ICourse_GroupServices
{
     private readonly DapperConnection _context;
    public Course_GroupServices()
    {
        _context = new DapperConnection();
    }

    public string AddCourse_Group(Course_Groups id)
    {
         var sql = $"Insert into course_group(course_id,group_id) values({id.Course_Id},{id.Group_Id})";
        var inserted = _context.Connection().Execute(sql);
        if(inserted > 0) return "Added Uspeshno";
        return "Error";
    }

    public List<Course_Groups> GetCourse_Groups()
    {
        var sql = "Select * from course_group";
        var selected = _context.Connection().Query<Course_Groups>(sql).ToList();
        return selected;
    }

    public Course_Groups GetCourse_GroupsById(int id)
    {
 
        var sql = $"Select * from course_group where id = {@id}";
        var selected = _context.Connection().QueryFirstOrDefault(sql);
        return selected; 
     }

    public string UpdateCourse_Group(Course_Groups id)
    {
        throw new NotImplementedException();
    }

        public bool DeleteCourse_Group(int id)
    {
        throw new NotImplementedException();
    }

}
