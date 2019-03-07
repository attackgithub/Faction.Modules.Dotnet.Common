using System.Collections.Generic;

namespace Faction.Modules.Dotnet.Common
{
  
  public class CommandOutput
  {
    public CommandOutput() {
      IOCs = new List<IOC>();
    }
    public bool Success;
    public bool Complete;
    // Message is what is displayed on console.
    public string Message;
    // Type tells Faction how to handle the 'ContentBytes' parameter.
    // Right now the only type faction will recognize is 'File', in 
    // which case ContentBytes should contain the file bytes and ContentId
    // would be the name of the file.
    public string Type = null;
    public string ContentId = null;
    public string Content = null;
    public List<IOC> IOCs;
  }

  
  public abstract class Command
  {
    public abstract string Name { get; }
    public abstract CommandOutput Execute(Dictionary<string, string> Parameters);
  }


}
