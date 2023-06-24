using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000DC RID: 220
	[Token(Token = "0x20000DC")]
	[CallbackIdentity(113)]
	public struct ClientGameServerDeny_t
	{
		// Token: 0x0400029C RID: 668
		[Token(Token = "0x400029C")]
		public const int k_iCallback = 113;

		// Token: 0x0400029D RID: 669
		[Token(Token = "0x400029D")]
		[FieldOffset(Offset = "0x0")]
		public uint m_uAppID;

		// Token: 0x0400029E RID: 670
		[Token(Token = "0x400029E")]
		[FieldOffset(Offset = "0x4")]
		public uint m_unGameServerIP;

		// Token: 0x0400029F RID: 671
		[Token(Token = "0x400029F")]
		[FieldOffset(Offset = "0x8")]
		public ushort m_usGameServerPort;

		// Token: 0x040002A0 RID: 672
		[Token(Token = "0x40002A0")]
		[FieldOffset(Offset = "0xA")]
		public ushort m_bSecure;

		// Token: 0x040002A1 RID: 673
		[Token(Token = "0x40002A1")]
		[FieldOffset(Offset = "0xC")]
		public uint m_uReason;
	}
}
