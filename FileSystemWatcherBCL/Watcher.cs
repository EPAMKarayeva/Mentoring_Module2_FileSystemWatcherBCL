using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using messages = FileSystemWatcherBCL.Recources.Messages;


namespace FileSystemWatcherBCL
{
  public class Watcher
  {
    static bool flag;
    static bool configFlag;
    public void RunWatcher()
    {

      var watcher = new FileSystemWatcher
      {
        Path = @"C:/Users/aziza",
        NotifyFilter = NotifyFilters.LastAccess
                                | NotifyFilters.LastWrite
                                | NotifyFilters.FileName
                                | NotifyFilters.DirectoryName,
      };
      
      // Add event handlers.
      watcher.Changed += OnChanged;
      watcher.Created += OnChanged;
      watcher.Deleted += OnChanged;
      watcher.Renamed += OnRenamed;

      // Begin watching.
      watcher.EnableRaisingEvents = true;

      Console.WriteLine("1- english, 2 - russian");
      var language = Console.ReadLine();

      flag = language == "1" ? true : false;
      
      if (flag)
      {
        Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
      }
      else
      {
        Thread.CurrentThread.CurrentUICulture = new CultureInfo("ru-RU");
      }

      Console.WriteLine($"{messages.PickConfig}, 1 - yes, 2 - no");
      var pickConfig = Console.ReadLine();
      configFlag = pickConfig == "1" ? true : false;

      Console.WriteLine(messages.ExitProgram);

    }

    private static void OnChanged(object source, FileSystemEventArgs e)
    {  
      Console.WriteLine($"{messages.OnChangeMessage}: {e.FullPath} {e.ChangeType}");

      WatcherChangeTypes wct = e.ChangeType;
      var type = wct.ToString();
      RulesManager rulesDetector = new RulesManager();
      ConfigReader configReader = new ConfigReader();
      if (type == "Created")
      {
        if (!configFlag)
        {
          rulesDetector.CheckRules(e.FullPath, flag);
        }
        else
        {
          configReader.ConfigCheck(e.FullPath);
        }
      }    
    }
              
    private static void OnRenamed(object source, RenamedEventArgs e) =>
        Console.WriteLine($"{messages.OnRenameMessage}: {e.OldFullPath} --> {e.FullPath}");
  }
}
