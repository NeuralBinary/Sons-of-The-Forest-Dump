using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200006D RID: 109
	[Token(Token = "0x200006D")]
	[CallbackIdentity(2102)]
	public struct HTTPRequestHeadersReceived_t
	{
		// Token: 0x04000108 RID: 264
		[Token(Token = "0x4000108")]
		public const int k_iCallback = 2102;

		// Token: 0x04000109 RID: 265
		[Token(Token = "0x4000109")]
		[FieldOffset(Offset = "0x0")]
		public HTTPRequestHandle m_hRequest;

		// Token: 0x0400010A RID: 266
		[Token(Token = "0x400010A")]
		[FieldOffset(Offset = "0x8")]
		public ulong m_ulContextValue;
	}
}
