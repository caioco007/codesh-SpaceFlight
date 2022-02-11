using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaceFlight.Entities
{
    public class Events
    {
        public string Id { get; set; }
        public string Provider { get; set; }
        public Articles Article { get; set; }
    }
}
