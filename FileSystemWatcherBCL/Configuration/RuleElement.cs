﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemWatcherBCL.Configuration
{
  public class RuleElement : ConfigurationElement
  {
    [ConfigurationProperty("filePattern", IsRequired = true, IsKey = true)]
    public string FilePattern => (string)this["filePattern"];

    [ConfigurationProperty("destFolder", IsRequired = true)]
    public string DestinationFolder => (string)this["destFolder"];

    [ConfigurationProperty("isOrderAppended", IsRequired = false, DefaultValue = false)]
    public bool IsOrderAppended => (bool)this["isOrderAppended"];

    [ConfigurationProperty("isDateAppended", IsRequired = false, DefaultValue = false)]
    public bool IsDateAppended => (bool)this["isDateAppended"];
  }
}
