using System;
using Il2CppDummyDll;

namespace FMOD.Studio
{
	// Token: 0x020000C9 RID: 201
	[Token(Token = "0x20000C9")]
	public struct CPU_USAGE
	{
		// Token: 0x04000434 RID: 1076
		[Token(Token = "0x4000434")]
		[FieldOffset(Offset = "0x0")]
		public float dspusage;

		// Token: 0x04000435 RID: 1077
		[Token(Token = "0x4000435")]
		[FieldOffset(Offset = "0x4")]
		public float streamusage;

		// Token: 0x04000436 RID: 1078
		[Token(Token = "0x4000436")]
		[FieldOffset(Offset = "0x8")]
		public float geometryusage;

		// Token: 0x04000437 RID: 1079
		[Token(Token = "0x4000437")]
		[FieldOffset(Offset = "0xC")]
		public float updateusage;

		// Token: 0x04000438 RID: 1080
		[Token(Token = "0x4000438")]
		[FieldOffset(Offset = "0x10")]
		public float studiousage;
	}
}
