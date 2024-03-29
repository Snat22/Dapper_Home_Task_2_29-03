using Dapper;
using Domain.Models;
using Infrastructure.DapperContext;

namespace Infrastructure.Services;

public class GroupServices
{
         private readonly DapperConnection _context;
    public GroupServices()
    {
        _context = new DapperConnection();
    }

    public string AddGroup(Group group)
    {
        var sql = $"Insert into groups (name,members)"+
                $"values('{group.Name}',{group.Members})";
                var inserted = _context.Connection().Execute(sql);
                if(inserted > 0)return "Added Succsefully";
                return "Error";
    }

    public List<Group> GetGroups()
    {
        var sql = "Select * from groups";
            var selected = _context.Connection().Query<Group>(sql).ToList();
            return selected;
    }

    public Group GetGroupById(int id)
    {
        var sql = $"Select * from groups where id={@id}";
        var selected = _context.Connection().QueryFirstOrDefault(sql);
        return selected;
        
    }

    public string UpdateGroup(Group group)
    {
        var sql = $"Update groups set name = {group.Name},members = {group.Members}";
        var updated = _context.Connection().Execute(sql);
        if (updated > 0) return "Updated Uspehno";
        return "Error";
    }

    public bool DeleteGroup(int id)
    {
        var sql = $"Delete from groups where id = @id";
        var deleted = _context.Connection().Execute(sql);
         if (deleted > 0) return true;
         return false;
    }



}
