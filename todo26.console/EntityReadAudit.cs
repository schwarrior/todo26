using todo26.data;

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