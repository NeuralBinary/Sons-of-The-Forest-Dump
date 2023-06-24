using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200002D RID: 45
	[Token(Token = "0x200002D")]
	[CallbackIdentity(1008)]
	public struct RegisterActivationCodeResponse_t
	{
		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000010")]
		public const int k_iCallback = 1008;

		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x0")]
		public ERegisterActivationCodeResult m_eResult;

		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x4")]
		public uint m_unPackageRegistered;
	}
}
