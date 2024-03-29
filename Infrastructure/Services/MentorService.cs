using Dapper;
using Domain.Models;
using Infrastructure.DapperContext;
namespace Infrastructure.Services;

public class MentorService
{

 private readonly DapperConnection _context;
    public MentorService()
    {
        _context = new DapperConnection();
    }

    public string AddMentor(Mentor mentor)
    {
        var sql = $"Insert into mentor (firstname,lastname,experience)"+
                $"values('{mentor.FirstName}','{mentor.LastName}',{mentor.Experience})";
                var inserted = _context.Connection().Execute(sql);
                if(inserted > 0)return "Added Succsefully";
                return "Error";
    }

    public List<Mentor> GetMentors()
    {
        var sql = "Select * from mentor";
            var selected = _context.Connection().Query<Mentor>(sql).ToList();
            return selected;
    }

    public Mentor GetMentorById(int id)
    {
        var sql = $"Select * from mentor where id={@id}";
        var selected = _context.Connection().QueryFirstOrDefault(sql);
        return selected;
        
    }

    public string UpdateMentor(Mentor mentor)
    {
        var sql = $"Update mentor set fristname = {mentor.FirstName},lastnamr = {mentor.LastName}, age = {mentor.Experience}";
        var updated = _context.Connection().Execute(sql);
        if (updated > 0) return "Updated Uspehno";
        return "Error";
    }

    public bool DeleteMentor(int id)
    {
        var sql = $"Delete from mentor where id = {@id}";
        var deleted = _context.Connection().Execute(sql);
         if (deleted > 0) return true;
         return false;
    }


}
