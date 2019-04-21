using System;
using System.Collections.Generic;

namespace Faction.Modules.Dotnet.Common
{

    public abstract class AgentTransport
    {
        public abstract string Name { get; }
        public abstract string Beacon(string AgentName, string Message);
        public abstract string Stage(string StageName, string StagingId, string Message);
    }
}


