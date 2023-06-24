using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200015C RID: 348
	[Token(Token = "0x200015C")]
	public enum ESteamNetworkingAvailability
	{
		// Token: 0x040008D3 RID: 2259
		[Token(Token = "0x40008D3")]
		k_ESteamNetworkingAvailability_CannotTry = -102,
		// Token: 0x040008D4 RID: 2260
		[Token(Token = "0x40008D4")]
		k_ESteamNetworkingAvailability_Failed,
		// Token: 0x040008D5 RID: 2261
		[Token(Token = "0x40008D5")]
		k_ESteamNetworkingAvailability_Previously,
		// Token: 0x040008D6 RID: 2262
		[Token(Token = "0x40008D6")]
		k_ESteamNetworkingAvailability_Retrying = -10,
		// Token: 0x040008D7 RID: 2263
		[Token(Token = "0x40008D7")]
		k_ESteamNetworkingAvailability_NeverTried = 1,
		// Token: 0x040008D8 RID: 2264
		[Token(Token = "0x40008D8")]
		k_ESteamNetworkingAvailability_Waiting,
		// Token: 0x040008D9 RID: 2265
		[Token(Token = "0x40008D9")]
		k_ESteamNetworkingAvailability_Attempting,
		// Token: 0x040008DA RID: 2266
		[Token(Token = "0x40008DA")]
		k_ESteamNetworkingAvailability_Current = 100,
		// Token: 0x040008DB RID: 2267
		[Token(Token = "0x40008DB")]
		k_ESteamNetworkingAvailability_Unknown = 0,
		// Token: 0x040008DC RID: 2268
		[Token(Token = "0x40008DC")]
		k_ESteamNetworkingAvailability__Force32bit = 2147483647
	}
}
