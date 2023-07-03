namespace LeanCSharp;

internal class LdapTarget
{
    public string Host { get; set; }
    // 将 set 替换为 init .这可以防止在设置初始值后更改数据
    public string Protocol { get; init; }
    public string FullHost => $"{Protocol}://{Host}";
}


internal class LdapTarget2
{
    string Host { get; set; }
    string Protocol { get; init; }
    public string FullHost => $"{Protocol}://{Host}";
    
    // 构造函数(出入口)
    public LdapTarget2(string host, string protocol)
    {
        Host = host;
        Protocol = protocol;
    }
}
