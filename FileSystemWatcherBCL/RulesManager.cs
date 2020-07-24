using FileSystemWatcherBCL.Recources;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using messages = FileSystemWatcherBCL.Recources.Messages;


namespace FileSystemWatcherBCL
{
  public class RulesManager
  {
    readonly string textDirectory = @"C:/Users/aziza/TextFolder";
    readonly string pictureDirectory = @"C:/Users/aziza/PictureFolder";
    readonly string documentDirectory = @"C:/Users/aziza/DocumentFolder";
    readonly string defaultDirectory = @"C:/Users/aziza/Default";
    public void CheckRules(string path, bool flag)
    {

      if (flag)
      {
        Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
      }
      else
      {
        Thread.CurrentThread.CurrentUICulture = new CultureInfo("ru-RU");
      }

      Dictionary<string, string> namingRules = new Dictionary<string, string>
      {
        { "txt", "TextFolder" },
        { "jpg", "PictureFolder" },
        { "docx", "DocumentFolder" }
      };

      var file = Path.GetFileName(path);
      var date = File.GetCreationTime(path);
      ICollection<string> keyValue = namingRules.Keys;

      Logger.Log($"{messages.FileFounded}:{file}. {messages.DateOfCreation}:{date}.");

      if (file.Contains(keyValue.First()))
      {
        MoveToFolder(file, path, textDirectory);
        Logger.Log(messages.MoveInTextFolder);
      }
      else if (file.Contains(keyValue.ElementAt(1)))
      {
        MoveToFolder(file, path, pictureDirectory);
        Logger.Log(messages.MoveInPictureFolder);
      }
      else if (file.Contains(keyValue.Last()))
      {
        MoveToFolder(file, path, documentDirectory);
        Logger.Log(messages.MoveInDocumentFolder);
      }
      else
      {
        MoveToFolder(file, path, defaultDirectory);
        Logger.Log(messages.NotMatchWithRule);
      }
    }

    public void MoveToFolder(string file, string path, string directory)
    {
        if (directory != defaultDirectory)
        {
          Logger.Log($"{messages.MatchWithRule}");
        }

        string filePath = Path.Combine(directory, file);

        if (File.Exists(filePath))
        {
          File.Delete(filePath);
        }
        File.Move(path, filePath);
    
    }
  }
}

