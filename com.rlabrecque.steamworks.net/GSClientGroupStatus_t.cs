using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200004E RID: 78
	[Token(Token = "0x200004E")]
	[CallbackIdentity(208)]
	public struct GSClientGroupStatus_t
	{
		// Token: 0x0400007D RID: 125
		[Token(Token = "0x400007D")]
		public const int k_iCallback = 208;

		// Token: 0x0400007E RID: 126
		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0x0")]
		public CSteamID m_SteamIDUser;

		// Token: 0x0400007F RID: 127
		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x8")]
		public CSteamID m_SteamIDGroup;

		// Token: 0x04000080 RID: 128
		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0x10")]
		public bool m_bMember;

		// Token: 0x04000081 RID: 129
		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0x11")]
		public bool m_bOfficer;
	}
}
