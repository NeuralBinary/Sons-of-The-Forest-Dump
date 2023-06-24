using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000160 RID: 352
	[Token(Token = "0x2000160")]
	public enum ESteamNetConnectionEnd
	{
		// Token: 0x040008F7 RID: 2295
		[Token(Token = "0x40008F7")]
		k_ESteamNetConnectionEnd_Invalid,
		// Token: 0x040008F8 RID: 2296
		[Token(Token = "0x40008F8")]
		k_ESteamNetConnectionEnd_App_Min = 1000,
		// Token: 0x040008F9 RID: 2297
		[Token(Token = "0x40008F9")]
		k_ESteamNetConnectionEnd_App_Generic = 1000,
		// Token: 0x040008FA RID: 2298
		[Token(Token = "0x40008FA")]
		k_ESteamNetConnectionEnd_App_Max = 1999,
		// Token: 0x040008FB RID: 2299
		[Token(Token = "0x40008FB")]
		k_ESteamNetConnectionEnd_AppException_Min,
		// Token: 0x040008FC RID: 2300
		[Token(Token = "0x40008FC")]
		k_ESteamNetConnectionEnd_AppException_Generic = 2000,
		// Token: 0x040008FD RID: 2301
		[Token(Token = "0x40008FD")]
		k_ESteamNetConnectionEnd_AppException_Max = 2999,
		// Token: 0x040008FE RID: 2302
		[Token(Token = "0x40008FE")]
		k_ESteamNetConnectionEnd_Local_Min,
		// Token: 0x040008FF RID: 2303
		[Token(Token = "0x40008FF")]
		k_ESteamNetConnectionEnd_Local_OfflineMode,
		// Token: 0x04000900 RID: 2304
		[Token(Token = "0x4000900")]
		k_ESteamNetConnectionEnd_Local_ManyRelayConnectivity,
		// Token: 0x04000901 RID: 2305
		[Token(Token = "0x4000901")]
		k_ESteamNetConnectionEnd_Local_HostedServerPrimaryRelay,
		// Token: 0x04000902 RID: 2306
		[Token(Token = "0x4000902")]
		k_ESteamNetConnectionEnd_Local_NetworkConfig,
		// Token: 0x04000903 RID: 2307
		[Token(Token = "0x4000903")]
		k_ESteamNetConnectionEnd_Local_Rights,
		// Token: 0x04000904 RID: 2308
		[Token(Token = "0x4000904")]
		k_ESteamNetConnectionEnd_Local_P2P_ICE_NoPublicAddresses,
		// Token: 0x04000905 RID: 2309
		[Token(Token = "0x4000905")]
		k_ESteamNetConnectionEnd_Local_Max = 3999,
		// Token: 0x04000906 RID: 2310
		[Token(Token = "0x4000906")]
		k_ESteamNetConnectionEnd_Remote_Min,
		// Token: 0x04000907 RID: 2311
		[Token(Token = "0x4000907")]
		k_ESteamNetConnectionEnd_Remote_Timeout,
		// Token: 0x04000908 RID: 2312
		[Token(Token = "0x4000908")]
		k_ESteamNetConnectionEnd_Remote_BadCrypt,
		// Token: 0x04000909 RID: 2313
		[Token(Token = "0x4000909")]
		k_ESteamNetConnectionEnd_Remote_BadCert,
		// Token: 0x0400090A RID: 2314
		[Token(Token = "0x400090A")]
		k_ESteamNetConnectionEnd_Remote_BadProtocolVersion = 4006,
		// Token: 0x0400090B RID: 2315
		[Token(Token = "0x400090B")]
		k_ESteamNetConnectionEnd_Remote_P2P_ICE_NoPublicAddresses,
		// Token: 0x0400090C RID: 2316
		[Token(Token = "0x400090C")]
		k_ESteamNetConnectionEnd_Remote_Max = 4999,
		// Token: 0x0400090D RID: 2317
		[Token(Token = "0x400090D")]
		k_ESteamNetConnectionEnd_Misc_Min,
		// Token: 0x0400090E RID: 2318
		[Token(Token = "0x400090E")]
		k_ESteamNetConnectionEnd_Misc_Generic,
		// Token: 0x0400090F RID: 2319
		[Token(Token = "0x400090F")]
		k_ESteamNetConnectionEnd_Misc_InternalError,
		// Token: 0x04000910 RID: 2320
		[Token(Token = "0x4000910")]
		k_ESteamNetConnectionEnd_Misc_Timeout,
		// Token: 0x04000911 RID: 2321
		[Token(Token = "0x4000911")]
		k_ESteamNetConnectionEnd_Misc_SteamConnectivity = 5005,
		// Token: 0x04000912 RID: 2322
		[Token(Token = "0x4000912")]
		k_ESteamNetConnectionEnd_Misc_NoRelaySessionsToClient,
		// Token: 0x04000913 RID: 2323
		[Token(Token = "0x4000913")]
		k_ESteamNetConnectionEnd_Misc_P2P_Rendezvous = 5008,
		// Token: 0x04000914 RID: 2324
		[Token(Token = "0x4000914")]
		k_ESteamNetConnectionEnd_Misc_P2P_NAT_Firewall,
		// Token: 0x04000915 RID: 2325
		[Token(Token = "0x4000915")]
		k_ESteamNetConnectionEnd_Misc_PeerSentNoConnection,
		// Token: 0x04000916 RID: 2326
		[Token(Token = "0x4000916")]
		k_ESteamNetConnectionEnd_Misc_Max = 5999,
		// Token: 0x04000917 RID: 2327
		[Token(Token = "0x4000917")]
		k_ESteamNetConnectionEnd__Force32Bit = 2147483647
	}
}
