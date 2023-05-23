namespace Koleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"Doğukan","Berivan","Esra","Gülüzar" };

            //Console.WriteLine(isimler[0]);

            List<string> isimler2 = new List<string> { "Doğukan", "Berivan", "Esra", "Gülüzar" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Şeyma");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
        }

    }
}