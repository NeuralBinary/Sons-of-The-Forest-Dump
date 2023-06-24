using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200004A RID: 74
	[Token(Token = "0x200004A")]
	[CallbackIdentity(203)]
	public struct GSClientKick_t
	{
		// Token: 0x0400006F RID: 111
		[Token(Token = "0x400006F")]
		public const int k_iCallback = 203;

		// Token: 0x04000070 RID: 112
		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x0")]
		public CSteamID m_SteamID;

		// Token: 0x04000071 RID: 113
		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x8")]
		public EDenyReason m_eDenyReason;
	}
}
