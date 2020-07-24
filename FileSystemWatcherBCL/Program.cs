using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemWatcherBCL
{
  class Program
  {
    static void Main(string[] args)
    {
      ConsoleKeyInfo keypress;
      Watcher watcher = new Watcher();

      watcher.RunWatcher();

      do
      {
        keypress = Console.ReadKey();

        if ((ConsoleModifiers.Control & keypress.Modifiers) != 0)
        {
          if (keypress.Key == ConsoleKey.X)
          {
            Environment.Exit(-1);
          }
        }

      } while (true);
    }
  }
}
