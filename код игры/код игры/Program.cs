namespace код_игры
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в игру");
            Console.WriteLine("Введите имя вашего персонажа: ");
            string playerName = Console.ReadLine();

            Console.WriteLine("Вы просыпаетесь в комнате и видите перед собой следующие возможности:");
            Console.WriteLine("a. Открыть дверь");
            Console.WriteLine("b. Заглянуть под кровать");
            Console.WriteLine("c. Открыть ящик в углу комнаты");
            Console.WriteLine("d. Открыть вентиляцию");
            Console.WriteLine("e. Взглянуть на тумбочку");
            Console.WriteLine("f. Взглянуть на статую рядом с дверью");

            Console.WriteLine("Выберите действие: ");
            char choice = Console.ReadLine()[0];

            if (choice == 'c')
            {
                Console.WriteLine("Вы нашли ключ от ящика!");
                Console.WriteLine("Откройте ящик и найдите отмычку от двери.");
                Console.WriteLine("Выберите действие: ");
                choice = Console.ReadLine()[0];

                if (choice == 'a')
                {
                    Console.WriteLine("Вы успешно сбежали из комнаты! Поздравляем, " + playerName + "!");
                }
                else
                {
                    Console.WriteLine("Для открытия двери необходимо найти и использовать отмычку.");
                }
            }
            else
            {
                Console.WriteLine("Для открытия ящика необходимо активировать статую тремя артефактами.");

            }
        }
    }

}
    
