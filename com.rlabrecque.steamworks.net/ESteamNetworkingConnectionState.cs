using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200015F RID: 351
	[Token(Token = "0x200015F")]
	public enum ESteamNetworkingConnectionState
	{
		// Token: 0x040008EC RID: 2284
		[Token(Token = "0x40008EC")]
		k_ESteamNetworkingConnectionState_None,
		// Token: 0x040008ED RID: 2285
		[Token(Token = "0x40008ED")]
		k_ESteamNetworkingConnectionState_Connecting,
		// Token: 0x040008EE RID: 2286
		[Token(Token = "0x40008EE")]
		k_ESteamNetworkingConnectionState_FindingRoute,
		// Token: 0x040008EF RID: 2287
		[Token(Token = "0x40008EF")]
		k_ESteamNetworkingConnectionState_Connected,
		// Token: 0x040008F0 RID: 2288
		[Token(Token = "0x40008F0")]
		k_ESteamNetworkingConnectionState_ClosedByPeer,
		// Token: 0x040008F1 RID: 2289
		[Token(Token = "0x40008F1")]
		k_ESteamNetworkingConnectionState_ProblemDetectedLocally,
		// Token: 0x040008F2 RID: 2290
		[Token(Token = "0x40008F2")]
		k_ESteamNetworkingConnectionState_FinWait = -1,
		// Token: 0x040008F3 RID: 2291
		[Token(Token = "0x40008F3")]
		k_ESteamNetworkingConnectionState_Linger = -2,
		// Token: 0x040008F4 RID: 2292
		[Token(Token = "0x40008F4")]
		k_ESteamNetworkingConnectionState_Dead = -3,
		// Token: 0x040008F5 RID: 2293
		[Token(Token = "0x40008F5")]
		k_ESteamNetworkingConnectionState__Force32Bit = 2147483647
	}
}
