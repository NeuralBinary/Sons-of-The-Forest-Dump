using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200016D RID: 365
	[Token(Token = "0x200016D")]
	public struct SteamPartyBeaconLocation_t
	{
		// Token: 0x04000995 RID: 2453
		[Token(Token = "0x4000995")]
		[FieldOffset(Offset = "0x0")]
		public ESteamPartyBeaconLocationType m_eType;

		// Token: 0x04000996 RID: 2454
		[Token(Token = "0x4000996")]
		[FieldOffset(Offset = "0x8")]
		public ulong m_ulLocationID;
	}
}
