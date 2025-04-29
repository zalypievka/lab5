namespace Lab5
{
    class Computer
    {
        public string Case; public string GPU; public string Processor; public int RAM; public int Storage; public double Price; public bool HasSSD;
        public int GetTotalMemory()
        {
            return RAM + Storage;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть бренд корпусу комп'ютера: ");
            string Case = Console.ReadLine();

            Console.Write("Введіть відеокарту комп'ютера: ");
            string GPU = Console.ReadLine();

            Console.Write("Введіть процесор: ");
            string processor = Console.ReadLine();

            Console.Write("Введіть ОЗП (ГБ): ");
            int ram = int.Parse(Console.ReadLine());

            Console.Write("Введіть накопичувач (ГБ): ");
            int storage = int.Parse(Console.ReadLine());

            Console.Write("Введіть ціну ($): ");
            double price = double.Parse(Console.ReadLine());

            Console.Write("Чи є SSD? (y-так, n-нi): ");
            ConsoleKeyInfo hasSSDKey = Console.ReadKey();
            Console.WriteLine();

            Computer pc = new Computer();
            pc.Case = Case;
            pc.GPU = GPU;
            pc.Processor = processor;
            pc.RAM = ram;
            pc.Storage = storage;
            pc.Price = price;
            pc.HasSSD = hasSSDKey.Key == ConsoleKey.Y;

            Console.WriteLine("Інформація про комп'ютер:");
            Console.WriteLine("Бренд: " + pc.Case);
            Console.WriteLine("Модель: " + pc.GPU);
            Console.WriteLine("Процесор: " + pc.Processor);
            Console.WriteLine("ОЗП: " + pc.RAM + " ГБ");
            Console.WriteLine("Накопичувач: " + pc.Storage + " ГБ");
            Console.WriteLine("Ціна: $" + pc.Price.ToString("0.00"));
            Console.WriteLine(pc.HasSSD ? "Є SSD" : "Нема SSD");
            Console.WriteLine("Загальний обсяг пам'яті: " + pc.GetTotalMemory() + " ГБ");

            Console.ReadKey();
        }
    }

}
