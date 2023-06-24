using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000106 RID: 262
	[Token(Token = "0x2000106")]
	[Flags]
	public enum EPersonaChange
	{
		// Token: 0x040003E1 RID: 993
		[Token(Token = "0x40003E1")]
		k_EPersonaChangeName = 1,
		// Token: 0x040003E2 RID: 994
		[Token(Token = "0x40003E2")]
		k_EPersonaChangeStatus = 2,
		// Token: 0x040003E3 RID: 995
		[Token(Token = "0x40003E3")]
		k_EPersonaChangeComeOnline = 4,
		// Token: 0x040003E4 RID: 996
		[Token(Token = "0x40003E4")]
		k_EPersonaChangeGoneOffline = 8,
		// Token: 0x040003E5 RID: 997
		[Token(Token = "0x40003E5")]
		k_EPersonaChangeGamePlayed = 16,
		// Token: 0x040003E6 RID: 998
		[Token(Token = "0x40003E6")]
		k_EPersonaChangeGameServer = 32,
		// Token: 0x040003E7 RID: 999
		[Token(Token = "0x40003E7")]
		k_EPersonaChangeAvatar = 64,
		// Token: 0x040003E8 RID: 1000
		[Token(Token = "0x40003E8")]
		k_EPersonaChangeJoinedSource = 128,
		// Token: 0x040003E9 RID: 1001
		[Token(Token = "0x40003E9")]
		k_EPersonaChangeLeftSource = 256,
		// Token: 0x040003EA RID: 1002
		[Token(Token = "0x40003EA")]
		k_EPersonaChangeRelationshipChanged = 512,
		// Token: 0x040003EB RID: 1003
		[Token(Token = "0x40003EB")]
		k_EPersonaChangeNameFirstSet = 1024,
		// Token: 0x040003EC RID: 1004
		[Token(Token = "0x40003EC")]
		k_EPersonaChangeBroadcast = 2048,
		// Token: 0x040003ED RID: 1005
		[Token(Token = "0x40003ED")]
		k_EPersonaChangeNickname = 4096,
		// Token: 0x040003EE RID: 1006
		[Token(Token = "0x40003EE")]
		k_EPersonaChangeSteamLevel = 8192,
		// Token: 0x040003EF RID: 1007
		[Token(Token = "0x40003EF")]
		k_EPersonaChangeRichPresence = 16384
	}
}
