using Microsoft.Data.SqlClient;
Console.WriteLine($"Versioni i runtime: {Environment.Version} ");
string connectionString = @"Server=.\SQLEXPRESS;Database=StudentDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
try{
await using SqlConnection connection = new SqlConnection(connectionString);
await connection.OpenAsync();
string sql = "SELECT COUNT(*) FROM Studentet;";
await using SqlCommand command = new SqlCommand(sql, connection);
object? result = await command.ExecuteScalarAsync();
int numriStudenteve = Convert.ToInt32(result);
Console.WriteLine($"Nr. i studenteve: {numriStudenteve}");
}
catch(Exception e){
Console.WriteLine("Error");
Console.WriteLine(e.Message);
}