using Microsoft.EntityFrameworkCore;
using todo26.data;
using Task = todo26.data.Task;

public class EntityReadAudit
{

	public void Audit()
	{
		var dbContext = new Db();
		Console.WriteLine("Reading tasks:");
		var tasks = dbContext.Tasks.ToList();
		tasks.ForEach(Console.WriteLine);
		Console.WriteLine();
	}
}