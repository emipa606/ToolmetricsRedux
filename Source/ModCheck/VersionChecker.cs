using System;

namespace ModCheck
{
    // Token: 0x02000017 RID: 23
    internal class VersionChecker
	{
		// Token: 0x02000028 RID: 40
		private class DLLinfo
		{
			// Token: 0x0600008A RID: 138 RVA: 0x000044AC File Offset: 0x000026AC
			public DLLinfo(string newMod, Version newVersion)
			{
				this.mod = newMod;
				this.version = newVersion;
			}

			// Token: 0x0400005D RID: 93
			public string mod;

			// Token: 0x0400005E RID: 94
			public Version version;
		}
	}
}
