using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000031 RID: 49
	[Token(Token = "0x2000031")]
	[CallbackIdentity(1030)]
	public struct TimedTrialStatus_t
	{
		// Token: 0x0400001E RID: 30
		[Token(Token = "0x400001E")]
		public const int k_iCallback = 1030;

		// Token: 0x0400001F RID: 31
		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x0")]
		public AppId_t m_unAppID;

		// Token: 0x04000020 RID: 32
		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x4")]
		public bool m_bIsOffline;

		// Token: 0x04000021 RID: 33
		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x8")]
		public uint m_unSecondsAllowed;

		// Token: 0x04000022 RID: 34
		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0xC")]
		public uint m_unSecondsPlayed;
	}
}
