using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000072 RID: 114
	[Token(Token = "0x2000072")]
	[CallbackIdentity(4700)]
	public struct SteamInventoryResultReady_t
	{
		// Token: 0x0400011C RID: 284
		[Token(Token = "0x400011C")]
		public const int k_iCallback = 4700;

		// Token: 0x0400011D RID: 285
		[Token(Token = "0x400011D")]
		[FieldOffset(Offset = "0x0")]
		public SteamInventoryResult_t m_handle;

		// Token: 0x0400011E RID: 286
		[Token(Token = "0x400011E")]
		[FieldOffset(Offset = "0x4")]
		public EResult m_result;
	}
}
