using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UdpKit;

// Token: 0x020000B5 RID: 181
[Token(Token = "0x20000B5")]
public class CoopKick
{
	// Token: 0x170000E0 RID: 224
	// (get) Token: 0x060005FC RID: 1532 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000E0")]
	public static CoopKick Instance
	{
		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x3511150", Offset = "0x350F750", VA = "0x183511150")]
		get
		{
			return null;
		}
	}

	// Token: 0x060005FD RID: 1533 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005FD")]
	[Address(RVA = "0x35112D0", Offset = "0x350F8D0", VA = "0x1835112D0")]
	public CoopKick()
	{
	}

	// Token: 0x060005FE RID: 1534 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005FE")]
	[Address(RVA = "0x3511390", Offset = "0x350F990", VA = "0x183511390")]
	private void LoadList()
	{
	}

	// Token: 0x060005FF RID: 1535 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005FF")]
	[Address(RVA = "0x3511460", Offset = "0x350FA60", VA = "0x183511460")]
	private static void SaveList()
	{
	}

	// Token: 0x170000E1 RID: 225
	// (get) Token: 0x06000600 RID: 1536 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000E1")]
	public List<CoopKick.KickedPlayer> KickedPlayers
	{
		[Token(Token = "0x6000600")]
		[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000601 RID: 1537 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000601")]
	[Address(RVA = "0x35115C0", Offset = "0x350FBC0", VA = "0x1835115C0")]
	public static void KickPlayer(ulong steamid, int duration = -1, string message = "HOST_KICKED_YOU")
	{
	}

	// Token: 0x06000602 RID: 1538 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000602")]
	[Address(RVA = "0x3511660", Offset = "0x350FC60", VA = "0x183511660")]
	public static void KickPlayerByConnectionId(int connectionId, int duration = -1, string message = "HOST_KICKED_YOU")
	{
	}

	// Token: 0x06000603 RID: 1539 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000603")]
	[Address(RVA = "0x35116E0", Offset = "0x350FCE0", VA = "0x1835116E0")]
	public static void KickPlayer(BoltEntity playerEntity, int duration, string message = "HOST_KICKED_YOU")
	{
	}

	// Token: 0x06000604 RID: 1540 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000604")]
	[Address(RVA = "0x3511710", Offset = "0x350FD10", VA = "0x183511710")]
	public static void KickPlayer(BoltConnection connection, BoltEntity playerEntity, int duration, string message = "HOST_KICKED_YOU")
	{
	}

	// Token: 0x06000605 RID: 1541 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000605")]
	[Address(RVA = "0x3511C60", Offset = "0x3510260", VA = "0x183511C60")]
	public static void BanPlayer(BoltEntity playerEntity)
	{
	}

	// Token: 0x06000606 RID: 1542 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000606")]
	[Address(RVA = "0x3511CB0", Offset = "0x35102B0", VA = "0x183511CB0")]
	public static void BanPlayer(BoltConnection connection, BoltEntity playerEntity)
	{
	}

	// Token: 0x06000607 RID: 1543 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000607")]
	[Address(RVA = "0x3511D10", Offset = "0x3510310", VA = "0x183511D10")]
	public static void UnBanPlayer(ulong steamId)
	{
	}

	// Token: 0x06000608 RID: 1544 RVA: 0x00003D38 File Offset: 0x00001F38
	[Token(Token = "0x6000608")]
	[Address(RVA = "0x3511E20", Offset = "0x3510420", VA = "0x183511E20")]
	public static bool UnBanPlayer(string name)
	{
		return default(bool);
	}

	// Token: 0x06000609 RID: 1545 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000609")]
	[Address(RVA = "0x3511F90", Offset = "0x3510590", VA = "0x183511F90")]
	public static void ClearKickList()
	{
	}

	// Token: 0x0600060A RID: 1546 RVA: 0x00003D50 File Offset: 0x00001F50
	[Token(Token = "0x600060A")]
	[Address(RVA = "0x3512000", Offset = "0x3510600", VA = "0x183512000")]
	[Obsolete("UseMultiplayerPlayerRoles instead.")]
	public static bool IsBanned_DEPRECATED(UdpSteamID steamid)
	{
		return default(bool);
	}

	// Token: 0x0600060B RID: 1547 RVA: 0x00003D68 File Offset: 0x00001F68
	[Token(Token = "0x600060B")]
	[Address(RVA = "0x35120D0", Offset = "0x35106D0", VA = "0x1835120D0")]
	[Obsolete("UseMultiplayerPlayerRoles instead.")]
	public static bool IsBanned_DEPRECATED(ulong steamid)
	{
		return default(bool);
	}

	// Token: 0x0600060C RID: 1548 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600060C")]
	[Address(RVA = "0x35121A0", Offset = "0x35107A0", VA = "0x1835121A0")]
	public static void CheckBanEndTimes()
	{
	}

	// Token: 0x0400053B RID: 1339
	[Token(Token = "0x400053B")]
	private const string BanlistKey = "BanList";

	// Token: 0x0400053C RID: 1340
	[Token(Token = "0x400053C")]
	[FieldOffset(Offset = "0x10")]
	private List<CoopKick.KickedPlayer> kickedSteamIds;

	// Token: 0x0400053D RID: 1341
	[Token(Token = "0x400053D")]
	[FieldOffset(Offset = "0x0")]
	private static CoopKick instance;

	// Token: 0x020000B6 RID: 182
	[Token(Token = "0x20000B6")]
	[Serializable]
	public class KickedPlayer
	{
		// Token: 0x0600060D RID: 1549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600060D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public KickedPlayer()
		{
		}

		// Token: 0x0400053E RID: 1342
		[Token(Token = "0x400053E")]
		[FieldOffset(Offset = "0x10")]
		public string Name;

		// Token: 0x0400053F RID: 1343
		[Token(Token = "0x400053F")]
		[FieldOffset(Offset = "0x18")]
		public ulong SteamId;

		// Token: 0x04000540 RID: 1344
		[Token(Token = "0x4000540")]
		[FieldOffset(Offset = "0x20")]
		public long BanEndTime;
	}
}
