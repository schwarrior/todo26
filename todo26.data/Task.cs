using System.ComponentModel.DataAnnotations;

namespace todo26.data;

public class Task
{
	public Task()
	{
		TaskName = string.Empty;
		ChecklistId = 1;
	}

	[Key]
	public int TaskId { get; set; }

	public int ChecklistId { get; set; }

	[MaxLength(100)]
	public string TaskName { get; set; }

	public DateTime? CompleteDate {get; set;}

	public override string ToString()
	{
		return $"Task {TaskId}: {TaskName}";
	}
}
