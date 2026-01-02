using Microsoft.Data.SqlClient;
using todo26.data;

public class ConnectionAudit
{
	public void Audit()
	{
		var dbContext = new Db();
		var connString = dbContext.ConnectionString;
		var testSql = dbContext.TestSql; 
		Console.WriteLine("Opening SQL Connection");
		Console.WriteLine(connString);
		using var conn = new SqlConnection(connString);
		conn.Open();
		Console.WriteLine("Executing Test SQL");
		Console.WriteLine(testSql);
		using var cmd = new SqlCommand(testSql, conn);
		var result = cmd.ExecuteScalar();
		Console.WriteLine(result);
		Console.WriteLine();
	}
}