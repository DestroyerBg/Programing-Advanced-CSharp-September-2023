var timesToCompleteSingleTask = new Queue<int>
(Console.ReadLine()
   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
   .Select(int.Parse));
var tasksToComplete = new Stack<int>
(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));
var rubberDuckDictionary = new Dictionary<string, int>();
rubberDuckDictionary.Add($"Darth Vader Ducky", 0);
rubberDuckDictionary.Add($"Thor Ducky", 0);
rubberDuckDictionary.Add($"Big Blue Rubber Ducky", 0);
rubberDuckDictionary.Add($"Small Yellow Rubber Ducky", 0);
while (timesToCompleteSingleTask.Any() && tasksToComplete.Any())
{
    int timeForTask = timesToCompleteSingleTask.Dequeue();
    int task = tasksToComplete.Pop();
    int time = timeForTask * task;
    if (time >= 0 && time <= 60)
    {
        rubberDuckDictionary["Darth Vader Ducky"]++;
    }
    else if (time >= 61 && time <= 120)
    {
        rubberDuckDictionary["Thor Ducky"]++;
    }
    else if (time >= 121 && time <= 180)
    {
        rubberDuckDictionary["Big Blue Rubber Ducky"]++;
    }
    else if (time >= 181 && time <= 240)
    {
        rubberDuckDictionary["Small Yellow Rubber Ducky"]++;
        
    }
    else if (time > 240)
    {
        task -= 2;
        tasksToComplete.Push(task);
        timesToCompleteSingleTask.Enqueue(timeForTask);
    }

}

Console.WriteLine($"Congratulations, all tasks have been completed! Rubber ducks rewarded:");
foreach (var duck in rubberDuckDictionary)
{
    Console.WriteLine($"{duck.Key}: {duck.Value}");
}