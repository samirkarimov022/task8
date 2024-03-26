namespace ConsoleApp3
{
    internal class Program
    {
       
        static void Main(string[] args)
        {

            bool exit = false;

            while (exit)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Siyahıya bax");
                Console.WriteLine("2. Siyahıya ad əlavə et");
                Console.WriteLine("3. Siyahıda adı yoxla");
                Console.WriteLine("4. Daxil edilmiş indexdəki adı göstər");
                Console.WriteLine("0. Menudan çıx");
                Console.Write("Seçiminizi daxil edin: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        ViewList();
                        break;              
                    case 0:
                        exit = true;
                        Console.WriteLine("Proqram sonlandırılır...");
                        break;
                    default:
                        Console.WriteLine("Yanlış seçim! Zəhmət olmasa düzgün bir seçim edin.");
                        break;
                }
            }
        }

        static void ViewList()
        {
            Console.WriteLine("Siyahıdakı bütün adlar:");
            foreach (var item i)
            {
                Console.WriteLine(item);
            }
        }
        
    }
}