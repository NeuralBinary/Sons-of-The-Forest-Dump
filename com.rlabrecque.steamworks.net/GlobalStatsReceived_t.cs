using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000F2 RID: 242
	[Token(Token = "0x20000F2")]
	[CallbackIdentity(1112)]
	public struct GlobalStatsReceived_t
	{
		// Token: 0x040002F0 RID: 752
		[Token(Token = "0x40002F0")]
		public const int k_iCallback = 1112;

		// Token: 0x040002F1 RID: 753
		[Token(Token = "0x40002F1")]
		[FieldOffset(Offset = "0x0")]
		public ulong m_nGameID;

		// Token: 0x040002F2 RID: 754
		[Token(Token = "0x40002F2")]
		[FieldOffset(Offset = "0x8")]
		public EResult m_eResult;
	}
}
