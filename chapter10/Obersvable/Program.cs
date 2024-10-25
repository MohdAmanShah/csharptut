using System.Collections.ObjectModel;

ObservableCollection<TodoItem> todoItems = new ObservableCollection<TodoItem>()
{
    new TodoItem("make cake", false),
    new TodoItem("jump from bridge", false),
    new TodoItem("diving", true)
};
todoItems.CollectionChanged += Changed;

todoItems.RemoveAt(2);
todoItems.Add(new TodoItem("make curry", true));


static void Changed(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
{
    Console.WriteLine("Action for this event: {0}", e.Action);
    if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
    {
        Console.WriteLine("Old items");
        foreach (TodoItem item in e.OldItems)
        {
            Console.WriteLine(item);
        }
    }
    if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
    {
        Console.WriteLine("New items");
        foreach (TodoItem item in e.NewItems)
        {
            Console.WriteLine(item);
        }
    }
}


public class TodoItem
{
    public string Title { get; set; }
    public bool Completed { get; set; }
    public TodoItem(string title, bool completed)
    {
        Title = title;
        Completed = completed;
    }
    public override string ToString()
    {
        return $"[Title={Title}; Completed={Completed}]";
    }
}