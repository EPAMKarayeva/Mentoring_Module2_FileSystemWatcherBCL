using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DirectoryElement = FileSystemWatcherBCL.Configuration.DirectoryElement;
using FileSystemMonitorConfigSection = FileSystemWatcherBCL.Configuration.FileSystemWatcherConfigSection;
using RuleElement = FileSystemWatcherBCL.Configuration.RuleElement;

namespace FileSystemWatcherBCL
{
  public class ConfigReader
  {
    public void ConfigCheck(string path)
    {
      if (ConfigurationManager.GetSection("fileSystemSection") is FileSystemMonitorConfigSection config)
      {
        ReadConfiguration(config, path);
      }
    }

    private static void ReadConfiguration(FileSystemMonitorConfigSection config, string path)
    {
      var _directories = new List<string>(config.Directories.Count);
      var _rules = new List<Rule>();

      foreach (DirectoryElement directory in config.Directories)
      {
        _directories.Add(directory.Path);
      }

      foreach (RuleElement rule in config.Rules)
      {
        _rules.Add(new Rule
        {
          FilePattern = rule.FilePattern,
          DestinationFolder = rule.DestinationFolder,
          IsDateAppended = rule.IsDateAppended,
          IsOrderAppended = rule.IsOrderAppended
        });
      }

      foreach (var item in _rules)
      {
        CheckConfigRules(item, path);
      }

      CultureInfo.DefaultThreadCurrentCulture = config.Culture; 
      CultureInfo.DefaultThreadCurrentUICulture = config.Culture;
      CultureInfo.CurrentUICulture = config.Culture;
      CultureInfo.CurrentCulture = config.Culture;
    }

    public static void CheckConfigRules(Rule rule, string path)
    {
      RulesManager rulesManager = new RulesManager();
      var fileName = Path.GetFileName(path);
      var match = Regex.Match(fileName, rule.FilePattern);

      if (match.Success)   
      {
        rule.MatchesCount++;
        //path = AppendFileName(rule, path);
        var newFileName = Path.GetFileName(path);
        rulesManager.MoveToFolder(newFileName, path,rule.DestinationFolder);
      }

    }

    public static string AppendFileName(Rule rule, string path)
    {

      if (rule.IsOrderAppended)
      {
        File.Move(path, path + $" {rule.MatchesCount}");
      }

      if (rule.IsDateAppended)
      {
        var date = File.GetCreationTime(path).ToString();
        var fileName = Path.GetFileNameWithoutExtension(path);
        var directory = Path.GetDirectoryName(path);
        var newFileName = Path.Combine(directory, fileName);
        string extension = Path.GetExtension(path);
        var totalName = newFileName + date + extension;

        File.Move(path, totalName);

        return totalName;
      }

      return path;
    }
  }
}
