using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000078 RID: 120
	[Token(Token = "0x2000078")]
	[CallbackIdentity(502)]
	public struct FavoritesListChanged_t
	{
		// Token: 0x0400012E RID: 302
		[Token(Token = "0x400012E")]
		public const int k_iCallback = 502;

		// Token: 0x0400012F RID: 303
		[Token(Token = "0x400012F")]
		[FieldOffset(Offset = "0x0")]
		public uint m_nIP;

		// Token: 0x04000130 RID: 304
		[Token(Token = "0x4000130")]
		[FieldOffset(Offset = "0x4")]
		public uint m_nQueryPort;

		// Token: 0x04000131 RID: 305
		[Token(Token = "0x4000131")]
		[FieldOffset(Offset = "0x8")]
		public uint m_nConnPort;

		// Token: 0x04000132 RID: 306
		[Token(Token = "0x4000132")]
		[FieldOffset(Offset = "0xC")]
		public uint m_nAppID;

		// Token: 0x04000133 RID: 307
		[Token(Token = "0x4000133")]
		[FieldOffset(Offset = "0x10")]
		public uint m_nFlags;

		// Token: 0x04000134 RID: 308
		[Token(Token = "0x4000134")]
		[FieldOffset(Offset = "0x14")]
		public bool m_bAdd;

		// Token: 0x04000135 RID: 309
		[Token(Token = "0x4000135")]
		[FieldOffset(Offset = "0x18")]
		public AccountID_t m_unAccountId;
	}
}
