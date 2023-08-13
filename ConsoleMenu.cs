
namespace _0xDocWorker
{
    class ConsoleMenu
    {
        public ConsoleMenu() 
        {
        
        }

        public static void StartFrame()
        {
            Console.WriteLine("Я создал папку docs в папке с этой программой, " +
                              "пожалуйста, поместите туда нужные вам .doc файлы, " +
                              "затем введите 1 в консоль:");
            Console.Write(">>");
        }

        public static void MainMenuFrame()
        {
            Console.Clear();
            Utils.PrintLogo();
            Console.WriteLine("\n\n\nВыберите что вы хотите сделать:");
            Console.WriteLine("1 - Найти и заменить текст во всех документах");
            Console.WriteLine("2 - ");
            Console.WriteLine("3 - Выход из программы");
            Console.Write(">>");
        }

        public static void IncorrectEnterFrame()
        {
            Console.WriteLine("Что-то пошло не так... Попробуем еще раз.");
            Console.WriteLine("Для продолжения нажмите любую клавишу.");
            Console.ReadKey();
        }

        public static void IncorrectEnterFrame(Exception exception)
        {
            Console.WriteLine("Что-то пошло не так... Попробуем еще раз.");
            Console.WriteLine("Для продолжения нажмите любую клавишу.");
            Console.ReadKey();
        }

        public static void FindAndReplaceFrame(ref string textFind, ref string textReplace) 
        {
            Console.Clear();
            Utils.PrintLogo();
            Console.WriteLine("\n\n\nВведите текст, который требуется найти:");
            Console.Write(">>");
            textFind = Convert.ToString(Console.ReadLine());
            Console.WriteLine("\n\n\nВведите текст, которым вы замените найденный текст:");
            Console.Write(">>");
            textReplace = Convert.ToString(Console.ReadLine());
        }
    }
}
