using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000103 RID: 259
	[Token(Token = "0x2000103")]
	public enum EUserRestriction
	{
		// Token: 0x040003D1 RID: 977
		[Token(Token = "0x40003D1")]
		k_nUserRestrictionNone,
		// Token: 0x040003D2 RID: 978
		[Token(Token = "0x40003D2")]
		k_nUserRestrictionUnknown,
		// Token: 0x040003D3 RID: 979
		[Token(Token = "0x40003D3")]
		k_nUserRestrictionAnyChat,
		// Token: 0x040003D4 RID: 980
		[Token(Token = "0x40003D4")]
		k_nUserRestrictionVoiceChat = 4,
		// Token: 0x040003D5 RID: 981
		[Token(Token = "0x40003D5")]
		k_nUserRestrictionGroupChat = 8,
		// Token: 0x040003D6 RID: 982
		[Token(Token = "0x40003D6")]
		k_nUserRestrictionRating = 16,
		// Token: 0x040003D7 RID: 983
		[Token(Token = "0x40003D7")]
		k_nUserRestrictionGameInvites = 32,
		// Token: 0x040003D8 RID: 984
		[Token(Token = "0x40003D8")]
		k_nUserRestrictionTrading = 64
	}
}
