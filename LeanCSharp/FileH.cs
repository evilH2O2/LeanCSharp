namespace LeanCSharp;

internal class TaskTest
{
    void PrintNumber()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(i);
            Thread.Sleep(2000);
        }
    }
    
    int AddLoopNumber()
    {
        var count = 0;
        for (int i = 0; i < 5; i++)
        {
            count += i;
        }
        
        return count;
    }

    public async Task PrintNumberWithTask()
    {
        var t1 = Task.Run(PrintNumber);
        var t2 = Task.Run(PrintNumber);

        // await 必须在 async 内
        await Task.WhenAll(t1, t2);
        // 通过返回 Task 来使程序等待
    }
    
    public async void PrintNumberWithTaskReturn()
    {
        int t1 = await Task.Run(AddLoopNumber);
        int t2 = await Task.Run(AddLoopNumber);
        
        Console.WriteLine("T1: {0}", t1);
        Console.WriteLine("T2: {0}", t2);
    }
}
