using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000E0 RID: 224
	[Token(Token = "0x20000E0")]
	[CallbackIdentity(152)]
	public struct MicroTxnAuthorizationResponse_t
	{
		// Token: 0x040002A9 RID: 681
		[Token(Token = "0x40002A9")]
		public const int k_iCallback = 152;

		// Token: 0x040002AA RID: 682
		[Token(Token = "0x40002AA")]
		[FieldOffset(Offset = "0x0")]
		public uint m_unAppID;

		// Token: 0x040002AB RID: 683
		[Token(Token = "0x40002AB")]
		[FieldOffset(Offset = "0x8")]
		public ulong m_ulOrderID;

		// Token: 0x040002AC RID: 684
		[Token(Token = "0x40002AC")]
		[FieldOffset(Offset = "0x10")]
		public byte m_bAuthorized;
	}
}
