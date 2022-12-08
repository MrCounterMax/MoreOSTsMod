using R2API.Utils;
using System;

namespace OriginalSoundTrack
{
    internal class NetworkCompatibilityAttribute : Attribute
    {
        private CompatibilityLevel noNeedForSync;
        private VersionStrictness differentModVersionsAreOk;

        public NetworkCompatibilityAttribute(CompatibilityLevel noNeedForSync, VersionStrictness differentModVersionsAreOk)
        {
            this.noNeedForSync = noNeedForSync;
            this.differentModVersionsAreOk = differentModVersionsAreOk;
        }
    }
}