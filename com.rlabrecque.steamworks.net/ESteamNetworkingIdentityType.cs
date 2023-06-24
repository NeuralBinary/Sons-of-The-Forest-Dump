using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200015D RID: 349
	[Token(Token = "0x200015D")]
	public enum ESteamNetworkingIdentityType
	{
		// Token: 0x040008DE RID: 2270
		[Token(Token = "0x40008DE")]
		k_ESteamNetworkingIdentityType_Invalid,
		// Token: 0x040008DF RID: 2271
		[Token(Token = "0x40008DF")]
		k_ESteamNetworkingIdentityType_SteamID = 16,
		// Token: 0x040008E0 RID: 2272
		[Token(Token = "0x40008E0")]
		k_ESteamNetworkingIdentityType_IPAddress = 1,
		// Token: 0x040008E1 RID: 2273
		[Token(Token = "0x40008E1")]
		k_ESteamNetworkingIdentityType_GenericString,
		// Token: 0x040008E2 RID: 2274
		[Token(Token = "0x40008E2")]
		k_ESteamNetworkingIdentityType_GenericBytes,
		// Token: 0x040008E3 RID: 2275
		[Token(Token = "0x40008E3")]
		k_ESteamNetworkingIdentityType_UnknownType,
		// Token: 0x040008E4 RID: 2276
		[Token(Token = "0x40008E4")]
		k_ESteamNetworkingIdentityType__Force32bit = 2147483647
	}
}
