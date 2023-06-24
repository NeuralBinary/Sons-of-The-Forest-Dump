using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200006E RID: 110
	[Token(Token = "0x200006E")]
	[CallbackIdentity(2103)]
	public struct HTTPRequestDataReceived_t
	{
		// Token: 0x0400010B RID: 267
		[Token(Token = "0x400010B")]
		public const int k_iCallback = 2103;

		// Token: 0x0400010C RID: 268
		[Token(Token = "0x400010C")]
		[FieldOffset(Offset = "0x0")]
		public HTTPRequestHandle m_hRequest;

		// Token: 0x0400010D RID: 269
		[Token(Token = "0x400010D")]
		[FieldOffset(Offset = "0x8")]
		public ulong m_ulContextValue;

		// Token: 0x0400010E RID: 270
		[Token(Token = "0x400010E")]
		[FieldOffset(Offset = "0x10")]
		public uint m_cOffset;

		// Token: 0x0400010F RID: 271
		[Token(Token = "0x400010F")]
		[FieldOffset(Offset = "0x14")]
		public uint m_cBytesReceived;
	}
}
