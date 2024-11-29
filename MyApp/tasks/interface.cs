public interface ITask
{
    void Execute();
}

public class TaskManager
{
    private List<ITask> tasks;

    public TaskManager()
    {
        tasks = new List<ITask>
        {
            new Task1(),
            new Task2(),
            new Task3(),
            new Task4(),
        };
    }

    public void RunAllTasks()
    {
        foreach (var task in tasks)
        {
            task.Execute();
        }
    }
}