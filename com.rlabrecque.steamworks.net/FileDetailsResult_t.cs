using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000030 RID: 48
	[Token(Token = "0x2000030")]
	[CallbackIdentity(1023)]
	public struct FileDetailsResult_t
	{
		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		public const int k_iCallback = 1023;

		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x8")]
		public ulong m_ulFileSize;

		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x10")]
		public byte[] m_FileSHA;

		// Token: 0x0400001D RID: 29
		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x18")]
		public uint m_unFlags;
	}
}
