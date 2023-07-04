namespace LeanCSharp
{
    static class InvokeMe
    {
        static void Main()
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
    }
}
