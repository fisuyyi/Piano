namespace Piano
{
    internal class Programm
    {
        static int[] F1 = { 35, 39, 44, 49, 54, 59, 61, 66, 71, 76, 81, 86 };
        static int[] F2 = { 70, 75, 78, 83, 88, 93, 98, 103, 108, 113, 118, 123 };
        static int[] F3 = { 135, 140, 145, 150, 155, 170, 185, 196, 207, 220, 233, 246 };
        static int[] F4 = { 261, 277, 293, 311, 329, 349, 370, 392, 415, 440, 466, 493 };
        static int[] F5 = { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987 };

        static void Main(string[] args)
        {
            Console.WriteLine("Выберите октаву, используя клавиши: F1 F2 F3 F4 F5. ");
            while (true)
            {
                int[] knop = octava();
                if (knop == F1)
                {
                    beeep(knop);
                }
                else if (knop == F2)
                {   
                    beeep(knop);
                }
                else if (knop == F3)
                { 
                    beeep(knop);
                }
                else if (knop == F4)
                {
                    beeep(knop);
                }
                else if (knop == F5)
                { 
                    beeep(knop);
                }
            }
        }

            static int[] beeep(int[] knop)
            {
                Console.WriteLine("Клавиши пианино: Z S X D C F V G B H N J \n" +
                    "Если желаете выйти, нажмите клавишу Esc!");
                int[] keysofkeyboard = new int[11];
                while (true)
                {
                    ConsoleKey zvuk = Console.ReadKey().Key;
                    switch (zvuk)
                    {
                        case ConsoleKey.Z:
                            Console.Beep(knop[0] + 1000, 400);
                            Console.Clear();
                            continue;
                            break;

                        case ConsoleKey.S:
                            Console.Beep(knop[1] + 1050, 400);
                            Console.Clear();
                            continue;
                            break;

                        case ConsoleKey.X:
                            Console.Beep(knop[2] + 1050, 400);
                            Console.Clear();
                            continue;
                            break;

                        case ConsoleKey.D:
                            Console.Beep(knop[3] + 1050, 400);
                            Console.Clear();
                            continue;
                            break;

                        case ConsoleKey.C:
                            Console.Beep(knop[4] + 1050, 400);
                            Console.Clear();
                            continue;
                            break;

                        case ConsoleKey.F:
                            Console.Beep(knop[5] + 1050, 400);
                            Console.Clear();
                            continue;
                            break;

                        case ConsoleKey.V:
                            Console.Beep(knop[6] + 1050, 400);
                            Console.Clear();
                            continue;
                            break;

                        case ConsoleKey.G:
                            Console.Beep(knop[7] + 1050, 400);
                            Console.Clear();
                            continue;
                            break;

                        case ConsoleKey.B:
                            Console.Beep(knop[8] + 1050, 400);
                            Console.Clear();
                            continue;
                            break;

                        case ConsoleKey.H:
                            Console.Beep(knop[9] + 1050, 400);
                            Console.Clear();
                            continue;
                            break;

                        case ConsoleKey.N:
                            Console.Beep(knop[10] + 1050, 400);
                            Console.Clear();
                            continue;
                            break;

                        case ConsoleKey.J:
                            Console.Beep(knop[11] + 1050, 400);
                            Console.Clear();
                            continue;
                            break;

                        case ConsoleKey.F1:
                            knop = F1;
                            return knop;
                            break;

                        case ConsoleKey.F2:
                            knop = F2;
                            return knop;
                            break;

                        case ConsoleKey.F3:
                            knop = F3;
                            return knop;
                            break;

                        case ConsoleKey.F4:
                            knop = F4;
                            return knop;
                            break;

                        case ConsoleKey.F5:
                            knop = F5;
                            return knop;
                        Console.Clear();
                            break;

                        case ConsoleKey.Escape:
                            Environment.Exit(0);
                            break;

                        default:
                            Console.Clear();
                            continue;
                            break;




                    }
                }
            }
            static int[] octava()
            {
                int[]  knopklav = new int[13];
                {
                    ConsoleKeyInfo Key = Console.ReadKey();
                    Console.WriteLine(Key.Key);
                    if (Key.Key == ConsoleKey.F1)
                    {
                        Console.WriteLine("Выбрана первая октава");
                        knopklav = F1;
                        return knopklav;
                    }
                    else if (Key.Key == ConsoleKey.F2)
                    {
                        Console.WriteLine("Выбрана вторая октава");
                        knopklav = F2;
                        return knopklav;
                    }
                    else if (Key.Key == ConsoleKey.F3)
                    {
                        Console.WriteLine("Выбрана третья  октава");
                        knopklav = F3;
                        return knopklav;
                    }
                    else if (Key.Key == ConsoleKey.F4)
                    {
                        Console.WriteLine("Выбрана четвертая  октава");
                        knopklav = F4;
                        return knopklav;
                    }
                    else if (Key.Key == ConsoleKey.F5)
                    {
                        Console.WriteLine("Выбрана пятая  октава");
                        knopklav = F5;
                        return knopklav;
                    }
                    else
                    {
                        Console.Clear();

                        return knopklav;
                    }
                }
            }

        }
    }

