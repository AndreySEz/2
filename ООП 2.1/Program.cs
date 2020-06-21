using System;

namespace ООП_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Televisor tele1 = new Televisor();
            int channel = 0;
            bool keyPressed = true;
            Console.WriteLine("Программа \"Телевизор\": используйте стрелочки для перелистывания каналов. Чтобы перейти к конкретному каналу, начните с буквы К");
            while (true)
            {
                switch(Console.ReadKey().Key)
                {
                    case ConsoleKey.LeftArrow:
                    {
                        tele1.Previous();
                        break;
                    }
                    case ConsoleKey.RightArrow:
                    {
                        tele1.Next();
                        break;
                    }
                    case ConsoleKey.R:
                        {
                            keyPressed = false;
                            break;
                        }
                }
                if (!keyPressed)
                {
                    try
                    {
                        tele1.Choice(Convert.ToInt32(Console.ReadLine()));
                    }
                    catch
                    {
                        Console.WriteLine("Неверный номер канала");
                    }
                }
                keyPressed = true;
            }
        }
        class Televisor
        {
            int currentChannel = 0; // про нулевой канал не указано
            public void Next()
            {
                    currentChannel++;
                    Console.WriteLine("Текущий канал: " + currentChannel);
            }
            public void Previous()
            {
                if (currentChannel-1 > -1)
                {
                    currentChannel--;
                    Console.WriteLine("Текущий канал: " + currentChannel);
                }
                else Console.WriteLine("Неверный номер канала");
            }
            public void Choice(int channel)
            {
                if (channel > -1)
                {
                    currentChannel = channel;
                    Console.WriteLine("Текущий канал: " + currentChannel);
                }
                else Console.WriteLine("Неверный номер канала");
            }
        }
    }
}
