using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemWatcherBCL.Configuration
{
  public class DirectoryElement : ConfigurationElement
  {
    [ConfigurationProperty("path", IsRequired = true, IsKey = true)]
    public string Path => (string)this["path"];
  }
}
