using System;
using System.Collections.Generic;

namespace DemoConsole
{
    public class User : AdObject
    {
        public DateTime LastLogon { get; set; }

        public DateTime LastLogOff { get; set; }

        public int Codepage { get; set; }

        public List<AdObject> MemberOf { get; set; }
    }
}