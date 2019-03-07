using System;
using System.Collections.Generic;

namespace Faction.Modules.Dotnet.Common
{
  public partial class IOC
  {
    readonly private List<string> _types = new List<string>(new string[] {"url", "file", "registry", "process"});
    readonly private List<string> _actions = new List<string>(new string[] { "get", "post", "put", "patch", "access", "create", "modify", "delete" });
    public IOC(string Type, string Identifier, string Action, string Description, string Hash = null)
    {
      Timestamp = DateTime.UtcNow;
      if (_types.Contains(Type.ToLower())) 
      {
        this.Type = Type.ToLower();
      }
      else 
      {
        throw new SystemException($"Type {Type} is not in {this._types}");
      }

      if (_actions.Contains(Action.ToLower()))
      {
        this.Action = Action.ToLower();
      }
      else 
      {
        throw new SystemException($"Action {Action.ToLower()} is not in {this._actions}");
      }
      if (!String.IsNullOrEmpty(Hash))
      {
        this.Hash = Hash;
      }
      this.Identifier = Identifier;
      this.Description = Description;
    }

    public string Description { get; }
    public string Type { get; }
    public string Identifier { get; }
    public string Hash { get; }
    public string Action { get; }
    public DateTime Timestamp { get; }
  }
}
