using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200005D RID: 93
	[Token(Token = "0x200005D")]
	[CallbackIdentity(4509)]
	public struct HTML_SearchResults_t
	{
		// Token: 0x040000C2 RID: 194
		[Token(Token = "0x40000C2")]
		public const int k_iCallback = 4509;

		// Token: 0x040000C3 RID: 195
		[Token(Token = "0x40000C3")]
		[FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		// Token: 0x040000C4 RID: 196
		[Token(Token = "0x40000C4")]
		[FieldOffset(Offset = "0x4")]
		public uint unResults;

		// Token: 0x040000C5 RID: 197
		[Token(Token = "0x40000C5")]
		[FieldOffset(Offset = "0x8")]
		public uint unCurrentMatch;
	}
}
