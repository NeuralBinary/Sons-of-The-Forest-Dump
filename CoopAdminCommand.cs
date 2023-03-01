using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000A5 RID: 165
[Token(Token = "0x20000A5")]
public static class CoopAdminCommand
{
	// Token: 0x06000578 RID: 1400 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000578")]
	[Address(RVA = "0x2D50770", Offset = "0x2D4F770", VA = "0x182D50770")]
	public static void Send(string command, string data)
	{
	}

	// Token: 0x06000579 RID: 1401 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000579")]
	[Address(RVA = "0x2D4F680", Offset = "0x2D4E680", VA = "0x182D4F680")]
	public static void Recv(string command, string data, BoltConnection source)
	{
	}

	// Token: 0x0600057A RID: 1402 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600057A")]
	[Address(RVA = "0x2D4F520", Offset = "0x2D4E520", VA = "0x182D4F520")]
	private static void KickPlayerByConnectionId(int connectionId, BoltConnection source, string message)
	{
	}

	// Token: 0x0600057B RID: 1403 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600057B")]
	[Address(RVA = "0x2D4F470", Offset = "0x2D4E470", VA = "0x182D4F470")]
	private static void BanPlayerByConnectionId(int connectionId, BoltConnection source, string message)
	{
	}

	// Token: 0x0600057C RID: 1404 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600057C")]
	[Address(RVA = "0x2D4F5D0", Offset = "0x2D4E5D0", VA = "0x182D4F5D0")]
	private static void KickPlayer(ulong steamId, BoltConnection source, string message)
	{
	}

	// Token: 0x0600057D RID: 1405 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600057D")]
	[Address(RVA = "0x2D506C0", Offset = "0x2D4F6C0", VA = "0x182D506C0")]
	private static void SendNetworkMessageAll(string message)
	{
	}

	// Token: 0x0600057E RID: 1406 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600057E")]
	[Address(RVA = "0x2D50720", Offset = "0x2D4F720", VA = "0x182D50720")]
	private static void SendNetworkMessage(string message, BoltConnection source)
	{
	}

	// Token: 0x0600057F RID: 1407 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600057F")]
	[Address(RVA = "0x2D50640", Offset = "0x2D4F640", VA = "0x182D50640")]
	private static void SendLocalMessage(string message)
	{
	}

	// Token: 0x06000580 RID: 1408 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000580")]
	[Address(RVA = "0x2D50CD0", Offset = "0x2D4FCD0", VA = "0x182D50CD0")]
	private static IEnumerator ShutDownRoutine(bool restart)
	{
		return null;
	}

	// Token: 0x06000581 RID: 1409 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000581")]
	[Address(RVA = "0x2D4F2F0", Offset = "0x2D4E2F0", VA = "0x182D4F2F0")]
	public static void Application_logMessageReceived(string condition, string stackTrace, LogType type)
	{
	}

	// Token: 0x040004F5 RID: 1269
	[Token(Token = "0x40004F5")]
	private const string KickByConnectionIdCommandString = "kickbycid";

	// Token: 0x040004F6 RID: 1270
	[Token(Token = "0x40004F6")]
	private const string KickAdminCommandString = "kick";
}
