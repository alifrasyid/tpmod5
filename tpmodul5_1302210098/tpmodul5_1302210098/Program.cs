public class HaloGeneric
{
    public void SapaUser<X>(X user)
    {
        Console.WriteLine("Halo user " + user.ToString());
    }
}

class MainClass
{
    static void Main(string[] args)
    {
        HaloGeneric h = new HaloGeneric();
        string nama = "ALIF";
        h.SapaUser(nama);
    }

}