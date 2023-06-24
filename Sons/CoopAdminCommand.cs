using System;
using System.Collections;
using Il2CppDummyDll;
using Steamworks;
using UnityEngine;

// Token: 0x020000A4 RID: 164
[Token(Token = "0x20000A4")]
public static class CoopAdminCommand
{
	// Token: 0x060005A8 RID: 1448 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005A8")]
	[Address(RVA = "0x350C420", Offset = "0x350AA20", VA = "0x18350C420")]
	public static void Send(string command, string data)
	{
	}

	// Token: 0x060005A9 RID: 1449 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005A9")]
	[Address(RVA = "0x350CA80", Offset = "0x350B080", VA = "0x18350CA80")]
	public static void Send(string command, CSteamID steamId)
	{
	}

	// Token: 0x060005AA RID: 1450 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005AA")]
	[Address(RVA = "0x350CA80", Offset = "0x350B080", VA = "0x18350CA80")]
	public static void Send(string command, ulong steamId)
	{
	}

	// Token: 0x060005AB RID: 1451 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005AB")]
	[Address(RVA = "0x350CAB0", Offset = "0x350B0B0", VA = "0x18350CAB0")]
	public static void Receive(string command, string data, BoltConnection source)
	{
	}

	// Token: 0x060005AC RID: 1452 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005AC")]
	[Address(RVA = "0x350CB00", Offset = "0x350B100", VA = "0x18350CB00")]
	private static void Receive_Internal(string command, string data, BoltConnection source)
	{
	}

	// Token: 0x060005AD RID: 1453 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005AD")]
	[Address(RVA = "0x350D110", Offset = "0x350B710", VA = "0x18350D110")]
	private static void GetRoles(BoltConnection connection, out bool isHost, out bool isOwner, out bool isAdmin)
	{
	}

	// Token: 0x060005AE RID: 1454 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005AE")]
	[Address(RVA = "0x350D280", Offset = "0x350B880", VA = "0x18350D280")]
	private static void GetRoles(ulong steamId, out bool isHost, out bool isOwner, out bool isAdmin)
	{
	}

	// Token: 0x060005AF RID: 1455 RVA: 0x00003BD0 File Offset: 0x00001DD0
	[Token(Token = "0x60005AF")]
	[Address(RVA = "0x350D440", Offset = "0x350BA40", VA = "0x18350D440")]
	private static bool ValidateCanSourceAffectTarget(BoltConnection source, ulong targetSteamId)
	{
		return default(bool);
	}

	// Token: 0x060005B0 RID: 1456 RVA: 0x00003BE8 File Offset: 0x00001DE8
	[Token(Token = "0x60005B0")]
	[Address(RVA = "0x350D6C0", Offset = "0x350BCC0", VA = "0x18350D6C0")]
	public static bool CheckClientIsAdminOrAbove(BoltConnection connection)
	{
		return default(bool);
	}

	// Token: 0x060005B1 RID: 1457 RVA: 0x00003C00 File Offset: 0x00001E00
	[Token(Token = "0x60005B1")]
	[Address(RVA = "0x350D810", Offset = "0x350BE10", VA = "0x18350D810")]
	public static bool CheckLocalPlayerIsAdminOrAbove()
	{
		return default(bool);
	}

	// Token: 0x060005B2 RID: 1458 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005B2")]
	[Address(RVA = "0x350D970", Offset = "0x350BF70", VA = "0x18350D970")]
	private static void PlayerKick(BoltConnection source, string data)
	{
	}

	// Token: 0x060005B3 RID: 1459 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005B3")]
	[Address(RVA = "0x350DAE0", Offset = "0x350C0E0", VA = "0x18350DAE0")]
	private static void PlayerBan(BoltConnection source, string data)
	{
	}

	// Token: 0x060005B4 RID: 1460 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005B4")]
	[Address(RVA = "0x350DC40", Offset = "0x350C240", VA = "0x18350DC40")]
	private static void SetPlayerAdmin(BoltConnection source, string data)
	{
	}

	// Token: 0x060005B5 RID: 1461 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005B5")]
	[Address(RVA = "0x350DEF0", Offset = "0x350C4F0", VA = "0x18350DEF0")]
	private static void SetPlayerGuest(BoltConnection source, string data)
	{
	}

	// Token: 0x060005B6 RID: 1462 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005B6")]
	[Address(RVA = "0x350E1A0", Offset = "0x350C7A0", VA = "0x18350E1A0")]
	private static void SetPlayerTrusted(BoltConnection source, string data)
	{
	}

	// Token: 0x060005B7 RID: 1463 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005B7")]
	[Address(RVA = "0x350E450", Offset = "0x350CA50", VA = "0x18350E450")]
	private static void SendNetworkMessageAll(string message)
	{
	}

	// Token: 0x060005B8 RID: 1464 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005B8")]
	[Address(RVA = "0x350E5A0", Offset = "0x350CBA0", VA = "0x18350E5A0")]
	private static void SendNetworkMessage(string message, BoltConnection source)
	{
	}

	// Token: 0x060005B9 RID: 1465 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005B9")]
	[Address(RVA = "0x350E5F0", Offset = "0x350CBF0", VA = "0x18350E5F0")]
	private static void SendLocalMessage(string message)
	{
	}

	// Token: 0x060005BA RID: 1466 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005BA")]
	[Address(RVA = "0x350E670", Offset = "0x350CC70", VA = "0x18350E670")]
	private static IEnumerator ShutDownRoutine(bool restart)
	{
		return null;
	}

	// Token: 0x060005BB RID: 1467 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005BB")]
	[Address(RVA = "0x350E6C0", Offset = "0x350CCC0", VA = "0x18350E6C0")]
	public static void Application_logMessageReceived(string condition, string stackTrace, LogType type)
	{
	}

	// Token: 0x04000513 RID: 1299
	[Token(Token = "0x4000513")]
	public const string Command_playerkick = "playerkick";

	// Token: 0x04000514 RID: 1300
	[Token(Token = "0x4000514")]
	public const string Command_playerban = "playerban";

	// Token: 0x04000515 RID: 1301
	[Token(Token = "0x4000515")]
	public const string Command_setplayeradmin = "setplayeradmin";

	// Token: 0x04000516 RID: 1302
	[Token(Token = "0x4000516")]
	public const string Command_setplayerguest = "setplayerguest";

	// Token: 0x04000517 RID: 1303
	[Token(Token = "0x4000517")]
	public const string Command_setplayertrusted = "setplayertrusted";
}
