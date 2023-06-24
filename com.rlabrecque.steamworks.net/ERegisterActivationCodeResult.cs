using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000FF RID: 255
	[Token(Token = "0x20000FF")]
	public enum ERegisterActivationCodeResult
	{
		// Token: 0x040003AA RID: 938
		[Token(Token = "0x40003AA")]
		k_ERegisterActivationCodeResultOK,
		// Token: 0x040003AB RID: 939
		[Token(Token = "0x40003AB")]
		k_ERegisterActivationCodeResultFail,
		// Token: 0x040003AC RID: 940
		[Token(Token = "0x40003AC")]
		k_ERegisterActivationCodeResultAlreadyRegistered,
		// Token: 0x040003AD RID: 941
		[Token(Token = "0x40003AD")]
		k_ERegisterActivationCodeResultTimeout,
		// Token: 0x040003AE RID: 942
		[Token(Token = "0x40003AE")]
		k_ERegisterActivationCodeAlreadyOwned
	}
}
