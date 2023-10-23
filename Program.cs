using AccessModifiersTask.Models;

namespace AccessModifiersTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NoteBook p = new NoteBook();
            p.SetStorage(512);
            p.SetRam(16);
            p.SetBrand("Lenovo");
            p.SetModel("ThinkPad");
            p.SetCount(3);
            p.SetPrice(2200);
            Console.WriteLine(p.GetFullInfo());
        }
    }
}