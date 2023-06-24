using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000073 RID: 115
	[Token(Token = "0x2000073")]
	[CallbackIdentity(4701)]
	public struct SteamInventoryFullUpdate_t
	{
		// Token: 0x0400011F RID: 287
		[Token(Token = "0x400011F")]
		public const int k_iCallback = 4701;

		// Token: 0x04000120 RID: 288
		[Token(Token = "0x4000120")]
		[FieldOffset(Offset = "0x0")]
		public SteamInventoryResult_t m_handle;
	}
}
