using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000032 RID: 50
	[Token(Token = "0x2000032")]
	[CallbackIdentity(304)]
	public struct PersonaStateChange_t
	{
		// Token: 0x04000023 RID: 35
		[Token(Token = "0x4000023")]
		public const int k_iCallback = 304;

		// Token: 0x04000024 RID: 36
		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x0")]
		public ulong m_ulSteamID;

		// Token: 0x04000025 RID: 37
		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x8")]
		public EPersonaChange m_nChangeFlags;
	}
}
