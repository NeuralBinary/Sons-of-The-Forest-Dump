using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Steamworks;

// Token: 0x020000E8 RID: 232
[Token(Token = "0x20000E8")]
internal static class CoopSteamServer
{
	// Token: 0x170000E1 RID: 225
	// (get) Token: 0x060006A5 RID: 1701 RVA: 0x00003DE0 File Offset: 0x00001FE0
	// (set) Token: 0x060006A6 RID: 1702 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170000E1")]
	public static bool IsConnectedToSteam
	{
		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x2E7FF30", Offset = "0x2E7EF30", VA = "0x182E7FF30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x2E80010", Offset = "0x2E7F010", VA = "0x182E80010")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x170000E2 RID: 226
	// (get) Token: 0x060006A7 RID: 1703 RVA: 0x00003DF8 File Offset: 0x00001FF8
	[Token(Token = "0x170000E2")]
	public static CSteamID SteamId
	{
		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x2E7FF80", Offset = "0x2E7EF80", VA = "0x182E7FF80")]
		get
		{
			return default(CSteamID);
		}
	}

	// Token: 0x060006A8 RID: 1704 RVA: 0x00003E10 File Offset: 0x00002010
	[Token(Token = "0x60006A8")]
	[Address(RVA = "0x2E7F6F0", Offset = "0x2E7E6F0", VA = "0x182E7F6F0")]
	public static bool Start(Action connected, Action failed)
	{
		return default(bool);
	}

	// Token: 0x060006A9 RID: 1705 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006A9")]
	[Address(RVA = "0x2E7FD40", Offset = "0x2E7ED40", VA = "0x182E7FD40")]
	public static void Update()
	{
	}

	// Token: 0x060006AA RID: 1706 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006AA")]
	[Address(RVA = "0x2E7F520", Offset = "0x2E7E520", VA = "0x182E7F520")]
	public static void Shutdown()
	{
	}

	// Token: 0x060006AB RID: 1707 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006AB")]
	[Address(RVA = "0x2E7F0A0", Offset = "0x2E7E0A0", VA = "0x182E7F0A0")]
	private static void Initialize()
	{
	}

	// Token: 0x060006AC RID: 1708 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006AC")]
	[Address(RVA = "0x2E7F4A0", Offset = "0x2E7E4A0", VA = "0x182E7F4A0")]
	private static void P2PSessionState(P2PSessionState_t param)
	{
	}

	// Token: 0x060006AD RID: 1709 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006AD")]
	[Address(RVA = "0x2E7F330", Offset = "0x2E7E330", VA = "0x182E7F330")]
	private static void P2PSessionRequest(P2PSessionRequest_t param)
	{
	}

	// Token: 0x060006AE RID: 1710 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006AE")]
	[Address(RVA = "0x2E7F8E0", Offset = "0x2E7E8E0", VA = "0x182E7F8E0")]
	private static void SteamServerConnectFailure(SteamServerConnectFailure_t param)
	{
	}

	// Token: 0x060006AF RID: 1711 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006AF")]
	[Address(RVA = "0x2E7FBB0", Offset = "0x2E7EBB0", VA = "0x182E7FBB0")]
	private static void SteamServersDisconnected(SteamServersDisconnected_t param)
	{
	}

	// Token: 0x060006B0 RID: 1712 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006B0")]
	[Address(RVA = "0x2E7FA30", Offset = "0x2E7EA30", VA = "0x182E7FA30")]
	private static void SteamServersConnected(SteamServersConnected_t param)
	{
	}

	// Token: 0x040005A1 RID: 1441
	[Token(Token = "0x40005A1")]
	[FieldOffset(Offset = "0x0")]
	private static bool runInit;

	// Token: 0x040005A2 RID: 1442
	[Token(Token = "0x40005A2")]
	[FieldOffset(Offset = "0x8")]
	private static Action Connected;

	// Token: 0x040005A3 RID: 1443
	[Token(Token = "0x40005A3")]
	[FieldOffset(Offset = "0x10")]
	private static Action Failed;

	// Token: 0x040005A4 RID: 1444
	[Token(Token = "0x40005A4")]
	[FieldOffset(Offset = "0x18")]
	private static Callback<P2PSessionRequest_t> P2PSessionRequest_Callback;

	// Token: 0x040005A5 RID: 1445
	[Token(Token = "0x40005A5")]
	[FieldOffset(Offset = "0x20")]
	private static Callback<SteamServersConnected_t> SteamServersConnected_Callback;

	// Token: 0x040005A6 RID: 1446
	[Token(Token = "0x40005A6")]
	[FieldOffset(Offset = "0x28")]
	private static Callback<SteamServersDisconnected_t> SteamServersDisconnected_Callback;

	// Token: 0x040005A7 RID: 1447
	[Token(Token = "0x40005A7")]
	[FieldOffset(Offset = "0x30")]
	private static Callback<SteamServerConnectFailure_t> SteamServerConnectFailure_Callback;
}
