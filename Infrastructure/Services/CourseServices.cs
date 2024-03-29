using Dapper;
using Domain.Models;
using Infrastructure.DapperContext;
namespace Infrastructure.Services;

public class CourseServices
{
     private readonly DapperConnection _context;
    public CourseServices()
    {
        _context = new DapperConnection();
    }

    public string AddCourse(Course course)
    {
        var sql = $"Insert into course (name,description)"+
                $"values('{course.Name}','{course.Description}')";
                var inserted = _context.Connection().Execute(sql);
                if(inserted > 0)return "Added Succsefully";
                return "Error";
    }

    public List<Course> GetCourses()
    {
        var sql = "Select * from course";
            var selected = _context.Connection().Query<Course>(sql).ToList();
            return selected;
    }

    public Course GetCourseById(int id)
    {
        var sql = $"Select * from course where id={@id}";
        var selected = _context.Connection().QueryFirstOrDefault(sql);
        return selected;
        
    }

    public string UpdateCourse(Course course)
    {
        var sql = $"Update course set name = {course.Name},descrition = {course.Description}";
        var updated = _context.Connection().Execute(sql);
        if (updated > 0) return "Updated Uspehno";
        return "Error";
    }

    public bool DeleteCourse(int id)
    {
        var sql = $"Delete from course where id = {@id}";
        var deleted = _context.Connection().Execute(sql);
         if (deleted > 0) return true;
         return false;
    }



}
