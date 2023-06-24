using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000ED RID: 237
	[Token(Token = "0x20000ED")]
	[CallbackIdentity(1107)]
	public struct NumberOfCurrentPlayers_t
	{
		// Token: 0x040002E0 RID: 736
		[Token(Token = "0x40002E0")]
		public const int k_iCallback = 1107;

		// Token: 0x040002E1 RID: 737
		[Token(Token = "0x40002E1")]
		[FieldOffset(Offset = "0x0")]
		public byte m_bSuccess;

		// Token: 0x040002E2 RID: 738
		[Token(Token = "0x40002E2")]
		[FieldOffset(Offset = "0x4")]
		public int m_cPlayers;
	}
}
