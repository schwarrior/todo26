using todo26.data;
using Task = todo26.data.Task;

public class EntityAddAudit
{
	public string NewTaskName { 
		get {
			return $"New task audit {DateTime.Now}"; 
		} 
	}

	public void Audit()
	{
		var dbContext = new Db();
		var newTask = new Task {TaskName = NewTaskName};
		Console.WriteLine("Creating new task");
		Console.WriteLine(newTask);
		dbContext.Tasks.Add(newTask);
		Console.WriteLine("Saving Changes");
		dbContext.SaveChanges();
		Console.WriteLine();
	}
}