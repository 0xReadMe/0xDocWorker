using _0xDocWorker;

string exeDirectory = Environment.CurrentDirectory;
Directory.CreateDirectory(exeDirectory + "\\docs");
string pathWithFiles = exeDirectory + "\\docs";

int choiceStart = 0;

Utils.PrintLogo();
Console.WriteLine("\n\n\nЗдравствуйте!");
while (true) 
{
    StartFrame();
    try 
    {
        choiceStart = Convert.ToInt32(Console.ReadLine());
    }
    catch
    {
        IncorrectEnterFrame();
        continue;
    }

    if (choiceStart == 1)
    {
        MainMenuFrame();
        var choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.Clear();
                Utils.PrintLogo();
                Console.WriteLine("\n\n\nВведите текст, который требуется найти:");
                Console.Write(">>");
                string textFind = Convert.ToString(Console.ReadLine());
                Console.WriteLine("\n\n\nВведите текст, которым вы замените найденный текст:");
                Console.Write(">>");
                string textReplace = Convert.ToString(Console.ReadLine());
                try
                {
                    _0xDocWorker._0xDocWorker.ReplaceText(pathWithFiles, textFind, textReplace);
                }
                catch 
                {
                
                }

                break;

            case 2:
                break;

            case 3:
                Utils.Exit(); 
                break;
                
        }
    }
    else 
    {
        IncorrectEnterFrame();
    }
}

void StartFrame() 
{
    Console.WriteLine("Я создал папку docs в папке с этой программой, " +
                      "пожалуйста, поместите туда нужные вам .doc файлы, " +
                      "затем введите 1 в консоль:");

    Console.Write(">>");
};

void MainMenuFrame() 
{
    Console.Clear();
    Utils.PrintLogo();
    Console.WriteLine("\n\n\nВыберите что вы хотите сделать:");
    Console.WriteLine("1 - Найти и заменить текст во всех документах");
    Console.WriteLine("2 - ");
    Console.WriteLine("3 - Выход из программы");

    Console.Write(">>");
}

void IncorrectEnterFrame() 
{
    Console.WriteLine("Вы ввели что-то другое... Попробуем еще раз.");
    Console.WriteLine("Для продолжения нажмите любую клавишу.");
    Console.ReadKey();
}