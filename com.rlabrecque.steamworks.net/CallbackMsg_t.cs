using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000173 RID: 371
	[Token(Token = "0x2000173")]
	public struct CallbackMsg_t
	{
		// Token: 0x040009C2 RID: 2498
		[Token(Token = "0x40009C2")]
		[FieldOffset(Offset = "0x0")]
		public int m_hSteamUser;

		// Token: 0x040009C3 RID: 2499
		[Token(Token = "0x40009C3")]
		[FieldOffset(Offset = "0x4")]
		public int m_iCallback;

		// Token: 0x040009C4 RID: 2500
		[Token(Token = "0x40009C4")]
		[FieldOffset(Offset = "0x8")]
		public IntPtr m_pubParam;

		// Token: 0x040009C5 RID: 2501
		[Token(Token = "0x40009C5")]
		[FieldOffset(Offset = "0x10")]
		public int m_cubParam;
	}
}
