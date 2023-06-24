using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000061 RID: 97
	[Token(Token = "0x2000061")]
	[CallbackIdentity(4513)]
	public struct HTML_LinkAtPosition_t
	{
		// Token: 0x040000D8 RID: 216
		[Token(Token = "0x40000D8")]
		public const int k_iCallback = 4513;

		// Token: 0x040000D9 RID: 217
		[Token(Token = "0x40000D9")]
		[FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		// Token: 0x040000DA RID: 218
		[Token(Token = "0x40000DA")]
		[FieldOffset(Offset = "0x4")]
		public uint x;

		// Token: 0x040000DB RID: 219
		[Token(Token = "0x40000DB")]
		[FieldOffset(Offset = "0x8")]
		public uint y;

		// Token: 0x040000DC RID: 220
		[Token(Token = "0x40000DC")]
		[FieldOffset(Offset = "0x10")]
		public string pchURL;

		// Token: 0x040000DD RID: 221
		[Token(Token = "0x40000DD")]
		[FieldOffset(Offset = "0x18")]
		public bool bInput;

		// Token: 0x040000DE RID: 222
		[Token(Token = "0x40000DE")]
		[FieldOffset(Offset = "0x19")]
		public bool bLiveLink;
	}
}
