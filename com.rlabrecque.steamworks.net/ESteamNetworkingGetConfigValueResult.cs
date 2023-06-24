using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000164 RID: 356
	[Token(Token = "0x2000164")]
	public enum ESteamNetworkingGetConfigValueResult
	{
		// Token: 0x04000961 RID: 2401
		[Token(Token = "0x4000961")]
		k_ESteamNetworkingGetConfigValue_BadValue = -1,
		// Token: 0x04000962 RID: 2402
		[Token(Token = "0x4000962")]
		k_ESteamNetworkingGetConfigValue_BadScopeObj = -2,
		// Token: 0x04000963 RID: 2403
		[Token(Token = "0x4000963")]
		k_ESteamNetworkingGetConfigValue_BufferTooSmall = -3,
		// Token: 0x04000964 RID: 2404
		[Token(Token = "0x4000964")]
		k_ESteamNetworkingGetConfigValue_OK = 1,
		// Token: 0x04000965 RID: 2405
		[Token(Token = "0x4000965")]
		k_ESteamNetworkingGetConfigValue_OKInherited,
		// Token: 0x04000966 RID: 2406
		[Token(Token = "0x4000966")]
		k_ESteamNetworkingGetConfigValueResult__Force32Bit = 2147483647
	}
}
