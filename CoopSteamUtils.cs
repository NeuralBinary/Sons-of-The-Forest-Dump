using System;
using Il2CppDummyDll;
using Steamworks;
using UdpKit;

// Token: 0x020000E9 RID: 233
[Token(Token = "0x20000E9")]
public static class CoopSteamUtils
{
	// Token: 0x060006B2 RID: 1714 RVA: 0x00003E28 File Offset: 0x00002028
	[Token(Token = "0x60006B2")]
	[Address(RVA = "0x2E80070", Offset = "0x2E7F070", VA = "0x182E80070")]
	public static UdpEndPoint ToEndPoint(this CSteamID id)
	{
		return default(UdpEndPoint);
	}

	// Token: 0x060006B3 RID: 1715 RVA: 0x00003E40 File Offset: 0x00002040
	[Token(Token = "0x60006B3")]
	[Address(RVA = "0x2E80070", Offset = "0x2E7F070", VA = "0x182E80070")]
	public static UdpEndPoint ToEndPoint(this ulong steamId)
	{
		return default(UdpEndPoint);
	}
}
