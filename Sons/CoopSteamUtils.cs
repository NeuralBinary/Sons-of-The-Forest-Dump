using System;
using Il2CppDummyDll;
using Steamworks;
using UdpKit;

// Token: 0x020000E7 RID: 231
[Token(Token = "0x20000E7")]
public static class CoopSteamUtils
{
	// Token: 0x060006FD RID: 1789 RVA: 0x00004008 File Offset: 0x00002208
	[Token(Token = "0x60006FD")]
	[Address(RVA = "0x709210", Offset = "0x707810", VA = "0x180709210")]
	public static UdpEndPoint ToEndPoint(this CSteamID id)
	{
		return default(UdpEndPoint);
	}

	// Token: 0x060006FE RID: 1790 RVA: 0x00004020 File Offset: 0x00002220
	[Token(Token = "0x60006FE")]
	[Address(RVA = "0x709210", Offset = "0x707810", VA = "0x180709210")]
	public static UdpEndPoint ToEndPoint(this ulong steamId)
	{
		return default(UdpEndPoint);
	}
}
