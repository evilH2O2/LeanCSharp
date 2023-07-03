namespace LeanCSharp;

public class FileA
{
    private int[] _numArray = new[] { 1, 2, 3, 4 };
    private int[] _numArray2 = { 1, 2, 3, 4 };
    private int[] _numArray3 = new int[4];
    
    // tuple
    private (int, string, bool) _t1 = (1, "str", true);
    
    // list
    private List<int> _listA = new List<int>();
    private List<int> _listB = new List<int> { 1, 2, 3, 4 };

    // 字典
    private Dictionary<string, int> _dict1 = new Dictionary<string, int>();
    
    // 队列
    private Queue<int> _queue1 = new Queue<int>();
    
    // 堆栈
    private Stack<int> _stack1 = new Stack<int>();


    public void InvokeFileA()
    {
        Console.WriteLine(_numArray);
        Console.WriteLine(_numArray2);
        Console.WriteLine(_numArray3);

        // 解构
        (int _, string _, bool _) = _t1;
        
        _listA.Add(5);
        _listB.Add(5);
        Console.WriteLine(_listA);
        Console.WriteLine(_listB);
        
        _dict1.Add("id", 1);
        Console.WriteLine(_dict1);
        
        _queue1.Enqueue(1);
        _queue1.Enqueue(2);
        _queue1.Dequeue();
        
        _stack1.Push(1);
        _stack1.Push(2);
        _stack1.Pop();
    }


    public void SwitchEx()
    {
        var name = "daming";

        var say = name switch
        {
            "xiaohong" => "boooom!!!",
            "daming" => "bingo!!",
            _ => "null"
        };
        
        Console.WriteLine(say);

        switch (name)
        {
            case "xiaohong":
                Console.WriteLine("boooom!!");
                break;
            case "daming":
                Console.WriteLine("bingo!!");
                break;
            default:
                Console.WriteLine("default");
                break;
        }
    }


    
    static void EnumEx(AlarmColor alarmColor)
    {
        switch (alarmColor)
        {
            case AlarmColor.Green:
                Console.WriteLine("normal");
                break;
            case AlarmColor.Red:
                Console.WriteLine("high");
                break;
            default:
                Console.WriteLine("error");
                break;
        }
    }

    // 用户输入
    static void InputGet()
    {
        while (true)
        {
            // 不换行
            Console.Write("> ");

            // ? => 变量可为 null
            string? input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                continue;
            }

            // 不区分大小写
            if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }
        }
    }
}

internal enum AlarmColor
{
    Red,
    Green
}
