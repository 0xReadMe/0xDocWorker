using _0xDocWorker;

string exeDirectory = Environment.CurrentDirectory;
Directory.CreateDirectory(exeDirectory + "\\docs");
string pathWithFiles = exeDirectory + "\\docs";

int choiceStart = 0;

Utils.PrintLogo();
Console.WriteLine("\n\n\nЗдравствуйте!");
while (true) 
{
    // ============ START FRAME ============
    ConsoleMenu.StartFrame();
    try 
    {
        choiceStart = Convert.ToInt32(Console.ReadLine());
    }
    catch (Exception exception)
    {
        // ====== EXCEPTION FRAME ======
        ConsoleMenu.IncorrectEnterFrame(exception);
        // ====== \EXCEPTION FRAME ======
        continue;
    }
    // ============ \START FRAME ============

    // ================== MAIN MENU FRAME ==================
    if (choiceStart == 1)
    {
        
        ConsoleMenu.MainMenuFrame();
        var choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                // ================== FIND & REPLACE FRAME ==================
                string textFind = ""; string textReplace = "";
                ConsoleMenu.FindAndReplaceFrame(ref textFind, ref textReplace);

                try
                {
                    if (textFind != null && textReplace != null) 
                    {
                        var a = Utils.FindAllFiles(pathWithFiles);
                        a.ToList().ForEach(file => 
                        { 
                            _0xDocWorker._0xDocWorker.ReplaceText(file, textFind, textReplace);
                            
                            Console.WriteLine($"Успешно заменили текст в файле {file}");
                        });
                    }
                }
                catch 
                {
                
                }

                break;
                // ================== \FIND & REPLACE FRAME ==================

            case 2:
                break;

            case 3:
                // ======== EXIT FRAME ========
                Utils.Exit(); 
                break;
                // ======== \EXIT FRAME ========

        }

    }
    // ================== \MAIN MENU FRAME ==================
    else
    {
        // ====== EXCEPTION FRAME ======
        ConsoleMenu.IncorrectEnterFrame();
        // ====== \EXCEPTION FRAME ======
    }
}
