namespace LeanCSharp;

// 似于抽象类，但只能包含方法和属性。
// 不能定义同时具有实现的方法
// 接口的命名约定是使其以 "I" 开头
internal interface IExpInfo
{ 
    string Title { get; set; }
    
    void PrintTitle();
}


// 类可以采用与抽象类相同的方式从接口继承
internal class Bug : IExpInfo
{
    public string Title { get; set; }

    public void PrintTitle()
    {
        Console.WriteLine(Title);
    }

    public Bug(string title)
    {
        Title = title;
    }
}
