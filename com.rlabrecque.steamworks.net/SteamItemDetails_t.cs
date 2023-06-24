using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200016C RID: 364
	[Token(Token = "0x200016C")]
	public struct SteamItemDetails_t
	{
		// Token: 0x04000991 RID: 2449
		[Token(Token = "0x4000991")]
		[FieldOffset(Offset = "0x0")]
		public SteamItemInstanceID_t m_itemId;

		// Token: 0x04000992 RID: 2450
		[Token(Token = "0x4000992")]
		[FieldOffset(Offset = "0x8")]
		public SteamItemDef_t m_iDefinition;

		// Token: 0x04000993 RID: 2451
		[Token(Token = "0x4000993")]
		[FieldOffset(Offset = "0xC")]
		public ushort m_unQuantity;

		// Token: 0x04000994 RID: 2452
		[Token(Token = "0x4000994")]
		[FieldOffset(Offset = "0xE")]
		public ushort m_unFlags;
	}
}
