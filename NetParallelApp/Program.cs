//Action[] actions = new Action[3] { Counter, Counter, Counter };

//Parallel.Invoke(actions);

//var result = Parallel.For(1, 10, Square);
//if(!result.IsCompleted)
//    Console.WriteLine("Loop is break");

List<int> nums = new List<int>() { 5, 4, 6, 8, 9 };
var result = Parallel.ForEach<int>(nums, Square);
if (!result.IsCompleted)
    Console.WriteLine("Loop is break");

void Counter()
{
    for(int i = 0; i < 10; i++)
    {
        Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} {i}");
        Thread.Sleep(500);
    }
}

void CounterNum(int num)
{
    for (int i = 0; i < num; i++)
    {
        Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} {i}");
        Thread.Sleep(500);
    }
}

void Square(int num, ParallelLoopState state)
{
    if(num == 5)
        state.Break();
    Console.WriteLine($"{num} - {num * num}");
}