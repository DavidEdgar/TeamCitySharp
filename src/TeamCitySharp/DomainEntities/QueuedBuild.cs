using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeamCitySharp.DomainEntities
{
    public class QueuedBuild
    {
        public string Id { get; set; }

        public override string ToString()
        {
            return Id;
        }
    }
}
