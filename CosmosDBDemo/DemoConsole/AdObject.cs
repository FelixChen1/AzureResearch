using System;

namespace DemoConsole
{
    public class AdObject
    {
        public string SAMAccountName { get; set; }
        public SAMAccountType SAMAccountTypeValue { get; set; }

        public string DistinguishedName { get; set; }

        public Guid ObjectGuid { get; set; }

        public string Description { get; set; }

    }
}