using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Sons.Settings
{
	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	public static class AudioDynamicRangeProfiles
	{
		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		public const string Default = "Default";

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		public const string SmallSpeakers = "Small Speakers";

		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		public const string NightTime = "Night Time";

		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		public const string SmallSpeakersSnapshotPath = "snapshot:/Settings Small Speakers";

		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		public const string NightTimeSnapshotPath = "snapshot:/Settings Night Time";

		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x0")]
		public static readonly List<string> All;
	}
}
