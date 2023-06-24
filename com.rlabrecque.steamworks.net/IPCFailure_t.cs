using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000DD RID: 221
	[Token(Token = "0x20000DD")]
	[CallbackIdentity(117)]
	public struct IPCFailure_t
	{
		// Token: 0x040002A2 RID: 674
		[Token(Token = "0x40002A2")]
		public const int k_iCallback = 117;

		// Token: 0x040002A3 RID: 675
		[Token(Token = "0x40002A3")]
		[FieldOffset(Offset = "0x0")]
		public byte m_eFailureType;
	}
}
