using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000075 RID: 117
	[Token(Token = "0x2000075")]
	[CallbackIdentity(4703)]
	public struct SteamInventoryEligiblePromoItemDefIDs_t
	{
		// Token: 0x04000122 RID: 290
		[Token(Token = "0x4000122")]
		public const int k_iCallback = 4703;

		// Token: 0x04000123 RID: 291
		[Token(Token = "0x4000123")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_result;

		// Token: 0x04000124 RID: 292
		[Token(Token = "0x4000124")]
		[FieldOffset(Offset = "0x4")]
		public CSteamID m_steamID;

		// Token: 0x04000125 RID: 293
		[Token(Token = "0x4000125")]
		[FieldOffset(Offset = "0xC")]
		public int m_numEligiblePromoItemDefs;

		// Token: 0x04000126 RID: 294
		[Token(Token = "0x4000126")]
		[FieldOffset(Offset = "0x10")]
		public bool m_bCachedData;
	}
}
