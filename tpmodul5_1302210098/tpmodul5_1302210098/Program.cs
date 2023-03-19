public class HaloGeneric
{
    public void SapaUser<X>(X user)
    {
        Console.WriteLine("Halo user " + user.ToString());
    }
}
﻿public class DataGeneric<T>
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

        HaloGeneric h = new HaloGeneric();
        string nama = "ALIF";
        h.SapaUser(nama);
   
        DataGeneric<string> Y = new DataGeneric<string>("1302210098");
        Y.PrintData();
    }

}