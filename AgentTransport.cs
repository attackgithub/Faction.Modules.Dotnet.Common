using System;
using System.Collections.Generic;

namespace Faction.Modules.Dotnet.Common
{

    public abstract class AgentTransport
    {
        public string Name { get; set; }
        public abstract string Beacon(string AgentName, string Message);
        public abstract string Stage(string StageName, string StagingId, string Message);
    }
}


