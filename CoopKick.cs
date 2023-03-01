using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UdpKit;

// Token: 0x020000B7 RID: 183
[Token(Token = "0x20000B7")]
public class CoopKick
{
	// Token: 0x170000D9 RID: 217
	// (get) Token: 0x060005C6 RID: 1478 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000D9")]
	public static CoopKick Instance
	{
		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x2E77CF0", Offset = "0x2E76CF0", VA = "0x182E77CF0")]
		get
		{
			return null;
		}
	}

	// Token: 0x060005C7 RID: 1479 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005C7")]
	[Address(RVA = "0x2E77C70", Offset = "0x2E76C70", VA = "0x182E77C70")]
	public CoopKick()
	{
	}

	// Token: 0x060005C8 RID: 1480 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005C8")]
	[Address(RVA = "0x2E775F0", Offset = "0x2E765F0", VA = "0x182E775F0")]
	private void LoadList()
	{
	}

	// Token: 0x060005C9 RID: 1481 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005C9")]
	[Address(RVA = "0x2E77890", Offset = "0x2E76890", VA = "0x182E77890")]
	private static void SaveList()
	{
	}

	// Token: 0x170000DA RID: 218
	// (get) Token: 0x060005CA RID: 1482 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000DA")]
	public List<CoopKick.KickedPlayer> KickedPlayers
	{
		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x5430A0", Offset = "0x5420A0", VA = "0x1805430A0")]
		get
		{
			return null;
		}
	}

	// Token: 0x060005CB RID: 1483 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005CB")]
	[Address(RVA = "0x2E77550", Offset = "0x2E76550", VA = "0x182E77550")]
	public static void KickPlayer(ulong steamid, int duration = -1, string message = "HOST_KICKED_YOU")
	{
	}

	// Token: 0x060005CC RID: 1484 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005CC")]
	[Address(RVA = "0x2E77030", Offset = "0x2E76030", VA = "0x182E77030")]
	public static void KickPlayerByConnectionId(int connectionId, int duration = -1, string message = "HOST_KICKED_YOU")
	{
	}

	// Token: 0x060005CD RID: 1485 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005CD")]
	[Address(RVA = "0x2E77520", Offset = "0x2E76520", VA = "0x182E77520")]
	public static void KickPlayer(BoltEntity playerEntity, int duration, string message = "HOST_KICKED_YOU")
	{
	}

	// Token: 0x060005CE RID: 1486 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005CE")]
	[Address(RVA = "0x2E770B0", Offset = "0x2E760B0", VA = "0x182E770B0")]
	public static void KickPlayer(BoltConnection connection, BoltEntity playerEntity, int duration, string message = "HOST_KICKED_YOU")
	{
	}

	// Token: 0x060005CF RID: 1487 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005CF")]
	[Address(RVA = "0x2E76C80", Offset = "0x2E75C80", VA = "0x182E76C80")]
	public static void BanPlayer(BoltEntity playerEntity)
	{
	}

	// Token: 0x060005D0 RID: 1488 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005D0")]
	[Address(RVA = "0x2E76C20", Offset = "0x2E75C20", VA = "0x182E76C20")]
	public static void BanPlayer(BoltConnection connection, BoltEntity playerEntity)
	{
	}

	// Token: 0x060005D1 RID: 1489 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005D1")]
	[Address(RVA = "0x2E77B50", Offset = "0x2E76B50", VA = "0x182E77B50")]
	public static void UnBanPlayer(ulong steamId)
	{
	}

	// Token: 0x060005D2 RID: 1490 RVA: 0x00003B70 File Offset: 0x00001D70
	[Token(Token = "0x60005D2")]
	[Address(RVA = "0x2E77A20", Offset = "0x2E76A20", VA = "0x182E77A20")]
	public static bool UnBanPlayer(string name)
	{
		return default(bool);
	}

	// Token: 0x060005D3 RID: 1491 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005D3")]
	[Address(RVA = "0x2E76E00", Offset = "0x2E75E00", VA = "0x182E76E00")]
	public static void ClearKickList()
	{
	}

	// Token: 0x060005D4 RID: 1492 RVA: 0x00003B88 File Offset: 0x00001D88
	[Token(Token = "0x60005D4")]
	[Address(RVA = "0x2E76F50", Offset = "0x2E75F50", VA = "0x182E76F50")]
	[Obsolete("UseMultiplayerPlayerRoles instead.")]
	public static bool IsBanned_DEPRECATED(UdpSteamID steamid)
	{
		return default(bool);
	}

	// Token: 0x060005D5 RID: 1493 RVA: 0x00003BA0 File Offset: 0x00001DA0
	[Token(Token = "0x60005D5")]
	[Address(RVA = "0x2E76E70", Offset = "0x2E75E70", VA = "0x182E76E70")]
	[Obsolete("UseMultiplayerPlayerRoles instead.")]
	public static bool IsBanned_DEPRECATED(ulong steamid)
	{
		return default(bool);
	}

	// Token: 0x060005D6 RID: 1494 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005D6")]
	[Address(RVA = "0x2E76CD0", Offset = "0x2E75CD0", VA = "0x182E76CD0")]
	public static void CheckBanEndTimes()
	{
	}

	// Token: 0x04000521 RID: 1313
	[Token(Token = "0x4000521")]
	private const string BanlistKey = "BanList";

	// Token: 0x04000522 RID: 1314
	[Token(Token = "0x4000522")]
	[FieldOffset(Offset = "0x10")]
	private List<CoopKick.KickedPlayer> kickedSteamIds;

	// Token: 0x04000523 RID: 1315
	[Token(Token = "0x4000523")]
	[FieldOffset(Offset = "0x0")]
	private static CoopKick instance;

	// Token: 0x020000B8 RID: 184
	[Token(Token = "0x20000B8")]
	[Serializable]
	public class KickedPlayer
	{
		// Token: 0x060005D7 RID: 1495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
		public KickedPlayer()
		{
		}

		// Token: 0x04000524 RID: 1316
		[Token(Token = "0x4000524")]
		[FieldOffset(Offset = "0x10")]
		public string Name;

		// Token: 0x04000525 RID: 1317
		[Token(Token = "0x4000525")]
		[FieldOffset(Offset = "0x18")]
		public ulong SteamId;

		// Token: 0x04000526 RID: 1318
		[Token(Token = "0x4000526")]
		[FieldOffset(Offset = "0x20")]
		public long BanEndTime;
	}
}
