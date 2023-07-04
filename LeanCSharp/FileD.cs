namespace LeanCSharp;

internal class HostInfo
{
    public string Host { get; set; }
    public string Port { get; set; }
}

// 继承
internal class WidnowsOS : HostInfo
{
    public string OSVersion { get; set; }
}

// 继承
// abstract 抽象类
internal abstract class LinuxOS : HostInfo
{
    public string KernelVer { get; set; }

    // 抽象方法，抽象方法只能在抽象类中
    // 抽象方法不能声明主体
    // 将迫使继承它的人提供自己的实现
    public abstract void PrintBanner();
}


internal class OverrideTest : LinuxOS
{
    // 重写
    public override void PrintBanner()
    {
        Console.WriteLine("Override Test");
    }
}
