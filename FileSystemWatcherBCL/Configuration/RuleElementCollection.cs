using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemWatcherBCL.Configuration
{
  public class RuleElementCollection : ConfigurationElementCollection
  {
    [ConfigurationProperty("defaultDir", IsRequired = true)]
    public string DefaultDirectory => (string)this["defaultDir"];

    protected override ConfigurationElement CreateNewElement()
    {
      return new RuleElement();
    }

    protected override object GetElementKey(ConfigurationElement element)
    {
      return ((RuleElement)element).FilePattern;
    }
  }
}
