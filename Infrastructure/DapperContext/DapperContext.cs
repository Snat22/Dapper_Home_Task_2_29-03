using Npgsql;
namespace Infrastructure.DapperContext;

public class DapperConnection
{
    private readonly string _connectionString = "Host=localhost;Port=5432;Database=Dapper_Class_Task_1.1;User Id=postgres;Password=11223344";

    public NpgsqlConnection Connection()
    {
        return new NpgsqlConnection(_connectionString);
    }
}
