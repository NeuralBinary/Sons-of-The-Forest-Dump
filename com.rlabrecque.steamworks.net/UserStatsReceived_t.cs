using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000E7 RID: 231
	[Token(Token = "0x20000E7")]
	[CallbackIdentity(1101)]
	[StructLayout(2)]
	public struct UserStatsReceived_t
	{
		// Token: 0x040002C5 RID: 709
		[Token(Token = "0x40002C5")]
		public const int k_iCallback = 1101;

		// Token: 0x040002C6 RID: 710
		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_nGameID;

		// Token: 0x040002C7 RID: 711
		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public EResult m_eResult;

		// Token: 0x040002C8 RID: 712
		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public CSteamID m_steamIDUser;
	}
}
