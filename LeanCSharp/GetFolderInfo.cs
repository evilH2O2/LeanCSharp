namespace LeanCSharp;

internal class FolderProcess
{
    private readonly string _source;

    public FolderProcess(string src)
    {
        _source = src;
    }

    // 获取文件列表
    public string[]? GetFiles()
    {
        if (!Directory.Exists(_source))
        {
            Console.WriteLine("请输入目录！");
            return null;
        }

        try
        {
            var fileList = Directory.GetFiles(_source);
            return fileList;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return null;
        }
    }
    
    // 复制文件
    public void CopyFile(string src, string dst)
    {
        try
        {
            File.Copy(src, dst);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return;
        }
    }
    
    // 获取父目录
    private DirectoryInfo? GetParentPath(string path)
    {
        try
        {
            return Directory.GetParent(path);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return null;
        }
    }

    // 获取指定层级的父目录
    public string GetParentPathWithCount(string path, int count)
    {
        for (int i = 0; i < count; i++)
        {
            var tmpPath = GetParentPath(path)!.ToString();
            path = tmpPath;
        }

        return path;
    }
}
