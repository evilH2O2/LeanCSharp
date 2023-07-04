namespace LeanCSharp;

// 并发
internal class ThreadTest
{
    void PrintNumber()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
            Thread.Sleep(2000);
        }
    }
    
    // 单个参数可以通过其 Start 方法传递给线程。
    // 方法上的参数必须声明为 object ，这意味着在使用前应对其执行类型检查
    void PrintNumber2(object? obj)
    {
        if (obj is not int count)
        {
            return;
        }

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(i);
            Thread.Sleep(2000);
        }
    }

    public void PrintNumberWithThread()
    {
        // 同时执行
        Thread t1 = new Thread(PrintNumber)
        {
            // 放入后台
            IsBackground = true
        };
        Thread t2 = new Thread(PrintNumber);
        
        t1.Start();
        t2.Start();
    }

    public void PrintNumberWithThreadWithArgs()
    {
        // var t1 = new Thread(new ParameterizedThreadStart(PrintNumber2)); // 沉余的写法
        var t1 = new Thread(PrintNumber2)
        {
            // 如果所有前台线程都完成，后台线程将不会使程序保持活动状态
            IsBackground = true // 在后台
        };
        var t2 = new Thread(PrintNumber2);
        
        t1.Start(5);
        t2.Start(4);
    }
}
