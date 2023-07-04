namespace LeanCSharp;

internal class FileC
{
    public string Host { get; set;  }
    public int Port { get; set;  }

    // 构造函数
    // 构造函数可用于强制我们在对象完全实例化之前将数据传递给对象。
    // 每个类都有一个隐含的“ 空构造函数”
    public FileC(string host, int port)
    {
        Host = host;
        Port = port;
    }

    // 方法
    public bool CheckPortRange()
    {
        if (Port < 0 | Port > 65535)
        {
            return false;
        }

        return true;
    }
}

// var fileC = new FileC("127.0.0.1", 80);
// fileC.CheckPortRange()
