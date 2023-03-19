public class DataGeneric<T>
{
    private T data;

    public DataGeneric(T data)
    {
        this.data = data;
    }

    public void PrintData()
    {
        Console.WriteLine("Data yang tersimpan adalah " +  data.ToString());
    }
}

class MainClass
{
    static void Main(string[] args)
    {
        DataGeneric<string> Y = new DataGeneric<string>("1302210098");
        Y.PrintData();
    }
}