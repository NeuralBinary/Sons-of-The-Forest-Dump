using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200014A RID: 330
	[Token(Token = "0x200014A")]
	public enum EAuthSessionResponse
	{
		// Token: 0x04000804 RID: 2052
		[Token(Token = "0x4000804")]
		k_EAuthSessionResponseOK,
		// Token: 0x04000805 RID: 2053
		[Token(Token = "0x4000805")]
		k_EAuthSessionResponseUserNotConnectedToSteam,
		// Token: 0x04000806 RID: 2054
		[Token(Token = "0x4000806")]
		k_EAuthSessionResponseNoLicenseOrExpired,
		// Token: 0x04000807 RID: 2055
		[Token(Token = "0x4000807")]
		k_EAuthSessionResponseVACBanned,
		// Token: 0x04000808 RID: 2056
		[Token(Token = "0x4000808")]
		k_EAuthSessionResponseLoggedInElseWhere,
		// Token: 0x04000809 RID: 2057
		[Token(Token = "0x4000809")]
		k_EAuthSessionResponseVACCheckTimedOut,
		// Token: 0x0400080A RID: 2058
		[Token(Token = "0x400080A")]
		k_EAuthSessionResponseAuthTicketCanceled,
		// Token: 0x0400080B RID: 2059
		[Token(Token = "0x400080B")]
		k_EAuthSessionResponseAuthTicketInvalidAlreadyUsed,
		// Token: 0x0400080C RID: 2060
		[Token(Token = "0x400080C")]
		k_EAuthSessionResponseAuthTicketInvalid,
		// Token: 0x0400080D RID: 2061
		[Token(Token = "0x400080D")]
		k_EAuthSessionResponsePublisherIssuedBan
	}
}
