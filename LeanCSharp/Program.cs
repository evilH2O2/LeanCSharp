namespace LeanCSharp
{
    static class InvokeMe
    {
        static void Run1()
        {
            Console.WriteLine("hello world");

            var ldapT = new LdapTarget
            {
                Host = "127.0.0.1",
                Protocol = "ldap"
            };
            Console.WriteLine(ldapT.FullHost);

            var ldapT2 = new LdapTarget2("127.0.0.1", "ldap");
            Console.WriteLine(ldapT2.FullHost);
            // ldapT.Protocol = "ssh"; // 此时的 Protocol 将无法被赋新值

            // 继承
            var win = new WidnowsOS()
            {
                Host = "127.0.0.1"
            };
            Console.WriteLine(win.Host);
            
            // 并发
            // Thread
            ThreadTest tt = new ThreadTest();
            // tt.PrintNumber();
            // tt.PrintNumberWithThread();
            tt.PrintNumberWithThreadWithArgs();
        }

        static void Run2()
        {
            // 这样会直接退出，并不等待
            var task = new TaskTest();
            var t = task.PrintNumberWithTask();
            t.GetAwaiter().GetResult(); // 程序等待
            task.PrintNumberWithTaskReturn();
        }

        static void Main()
        {
            // Run1();
            Run2();
        }
    }
}
