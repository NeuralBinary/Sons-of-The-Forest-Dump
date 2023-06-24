using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000143 RID: 323
	[Token(Token = "0x2000143")]
	public enum ECheckFileSignature
	{
		// Token: 0x04000756 RID: 1878
		[Token(Token = "0x4000756")]
		k_ECheckFileSignatureInvalidSignature,
		// Token: 0x04000757 RID: 1879
		[Token(Token = "0x4000757")]
		k_ECheckFileSignatureValidSignature,
		// Token: 0x04000758 RID: 1880
		[Token(Token = "0x4000758")]
		k_ECheckFileSignatureFileNotFound,
		// Token: 0x04000759 RID: 1881
		[Token(Token = "0x4000759")]
		k_ECheckFileSignatureNoSignaturesFoundForThisApp,
		// Token: 0x0400075A RID: 1882
		[Token(Token = "0x400075A")]
		k_ECheckFileSignatureNoSignaturesFoundForThisFile
	}
}
