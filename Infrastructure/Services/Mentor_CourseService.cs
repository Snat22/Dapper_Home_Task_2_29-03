using Dapper;
using Domain.Models;
using Infrastructure.DapperContext;

namespace Infrastructure.Services;

public class Mentor_CourseService : IMentor_CourseService
{
     private readonly DapperConnection _context;
    public Mentor_CourseService()
    {
        _context = new DapperConnection();
    }

    public string AddMentor_Course(Mentor_Course id)
    {
        var sql = $"Insert into mentor_course(mentor_id,course_id) values({id.Mentor_Id},{id.Course_Id})";
        var inserted = _context.Connection().Execute(sql);
        if(inserted > 0)return "Added Succsefully";
                return "Error";
    }

    public List<Mentor_Course> GetMentor_Course()
    {
        var sql = "Select * from mentor_course";
        var selected = _context.Connection().Query<Mentor_Course>(sql).ToList();
        return selected;
    }

    public Mentor_Course GetMentor_CourseById(int id)
    {
        var sql = $"Select * from mentor_course where id = {@id}";
        var selected = _context.Connection().QueryFirstOrDefault(sql);
        return selected;
    }

    public string UpdateMentor_Course(Mentor_Course id)
    {
         var sql = $"Update mentor_course set mentor_id = {id.Mentor_Id},course_id = {id.Course_Id}";
        var updated = _context.Connection().Execute(sql);
        if (updated > 0) return "Updated Uspehno";
        return "Error";
    }
    
    public bool DeleteMentor_Course(int id)
    {
    var sql = $"Delete from mentor_course where id = {@id}";
        var deleted = _context.Connection().Execute(sql);
        if (deleted > 0) return true;
        return false;    }
}
