using System.Runtime.InteropServices;
namespace LeanCSharp;


internal class InvokeWinApi
{
    [DllImport("kernel32.dll", SetLastError = true)]
    public static extern IntPtr OpenProcess(
        uint processAccess,
        bool bInheritHandle,
        uint processId
    );
}


// try
// {
//     var pid = OpenProcess(0x1F0FFF, true, (uint)3888);
//     Console.WriteLine(pid);
// }
// catch(Exception e)
// {
//     Console.WriteLine(e.Message);
//     return;
// }
