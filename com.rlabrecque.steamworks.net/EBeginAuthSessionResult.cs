using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000149 RID: 329
	[Token(Token = "0x2000149")]
	public enum EBeginAuthSessionResult
	{
		// Token: 0x040007FD RID: 2045
		[Token(Token = "0x40007FD")]
		k_EBeginAuthSessionResultOK,
		// Token: 0x040007FE RID: 2046
		[Token(Token = "0x40007FE")]
		k_EBeginAuthSessionResultInvalidTicket,
		// Token: 0x040007FF RID: 2047
		[Token(Token = "0x40007FF")]
		k_EBeginAuthSessionResultDuplicateRequest,
		// Token: 0x04000800 RID: 2048
		[Token(Token = "0x4000800")]
		k_EBeginAuthSessionResultInvalidVersion,
		// Token: 0x04000801 RID: 2049
		[Token(Token = "0x4000801")]
		k_EBeginAuthSessionResultGameMismatch,
		// Token: 0x04000802 RID: 2050
		[Token(Token = "0x4000802")]
		k_EBeginAuthSessionResultExpiredTicket
	}
}
