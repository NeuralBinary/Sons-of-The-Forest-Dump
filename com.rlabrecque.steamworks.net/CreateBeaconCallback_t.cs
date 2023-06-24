using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200008B RID: 139
	[Token(Token = "0x200008B")]
	[CallbackIdentity(5302)]
	public struct CreateBeaconCallback_t
	{
		// Token: 0x04000189 RID: 393
		[Token(Token = "0x4000189")]
		public const int k_iCallback = 5302;

		// Token: 0x0400018A RID: 394
		[Token(Token = "0x400018A")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x0400018B RID: 395
		[Token(Token = "0x400018B")]
		[FieldOffset(Offset = "0x8")]
		public PartyBeaconID_t m_ulBeaconID;
	}
}
