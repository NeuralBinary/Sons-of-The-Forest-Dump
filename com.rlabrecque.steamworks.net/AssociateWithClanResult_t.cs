using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000050 RID: 80
	[Token(Token = "0x2000050")]
	[CallbackIdentity(210)]
	public struct AssociateWithClanResult_t
	{
		// Token: 0x0400008A RID: 138
		[Token(Token = "0x400008A")]
		public const int k_iCallback = 210;

		// Token: 0x0400008B RID: 139
		[Token(Token = "0x400008B")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;
	}
}
