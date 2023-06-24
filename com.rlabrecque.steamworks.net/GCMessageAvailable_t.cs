using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000046 RID: 70
	[Token(Token = "0x2000046")]
	[CallbackIdentity(1701)]
	public struct GCMessageAvailable_t
	{
		// Token: 0x04000065 RID: 101
		[Token(Token = "0x4000065")]
		public const int k_iCallback = 1701;

		// Token: 0x04000066 RID: 102
		[Token(Token = "0x4000066")]
		[FieldOffset(Offset = "0x0")]
		public uint m_nMessageSize;
	}
}
