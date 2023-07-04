namespace LeanCSharp;

// 错误处理
internal class AboutError
{
    // 捕获错误
    public void ArrayErrorBubble()
    {
        var array = new[] { 1, 2, 3, 4 };

        try
        {
            Console.WriteLine(array[4]);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            Console.WriteLine("无论是否发生错误，我都会执行");
        }
    }
}
