using System.Collections.Generic;

namespace DemoConsole
{
    public class Group : AdObject
    {
        public string Description { get; set; }

        public int GroupType { get; set; }

        public List<AdObject> Members { get; set; }
        
        public List<AdObject> MemberOf { get; set; }
    }
}