using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000043 RID: 67
	[Token(Token = "0x2000043")]
	[CallbackIdentity(347)]
	public struct SetPersonaNameResponse_t
	{
		// Token: 0x0400005E RID: 94
		[Token(Token = "0x400005E")]
		public const int k_iCallback = 347;

		// Token: 0x0400005F RID: 95
		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0x0")]
		public bool m_bSuccess;

		// Token: 0x04000060 RID: 96
		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0x1")]
		public bool m_bLocalSuccess;

		// Token: 0x04000061 RID: 97
		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x4")]
		public EResult m_result;
	}
}
