using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Steamworks;

// Token: 0x020000E6 RID: 230
[Token(Token = "0x20000E6")]
internal static class CoopSteamServer
{
	// Token: 0x170000E8 RID: 232
	// (get) Token: 0x060006F0 RID: 1776 RVA: 0x00003FC0 File Offset: 0x000021C0
	// (set) Token: 0x060006F1 RID: 1777 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170000E8")]
	public static bool IsConnectedToSteam
	{
		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x3529500", Offset = "0x3527B00", VA = "0x183529500")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x3529550", Offset = "0x3527B50", VA = "0x183529550")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x170000E9 RID: 233
	// (get) Token: 0x060006F2 RID: 1778 RVA: 0x00003FD8 File Offset: 0x000021D8
	[Token(Token = "0x170000E9")]
	public static CSteamID SteamId
	{
		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x35295B0", Offset = "0x3527BB0", VA = "0x1835295B0")]
		get
		{
			return default(CSteamID);
		}
	}

	// Token: 0x060006F3 RID: 1779 RVA: 0x00003FF0 File Offset: 0x000021F0
	[Token(Token = "0x60006F3")]
	[Address(RVA = "0x3529640", Offset = "0x3527C40", VA = "0x183529640")]
	public static bool Start(Action connected, Action failed)
	{
		return default(bool);
	}

	// Token: 0x060006F4 RID: 1780 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006F4")]
	[Address(RVA = "0x35298B0", Offset = "0x3527EB0", VA = "0x1835298B0")]
	public static void Update()
	{
	}

	// Token: 0x060006F5 RID: 1781 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006F5")]
	[Address(RVA = "0x3529A50", Offset = "0x3528050", VA = "0x183529A50")]
	public static void Shutdown()
	{
	}

	// Token: 0x060006F6 RID: 1782 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006F6")]
	[Address(RVA = "0x352A080", Offset = "0x3528680", VA = "0x18352A080")]
	private static void Initialize()
	{
	}

	// Token: 0x060006F7 RID: 1783 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006F7")]
	[Address(RVA = "0x352A400", Offset = "0x3528A00", VA = "0x18352A400")]
	private static void P2PSessionState(P2PSessionState_t param)
	{
	}

	// Token: 0x060006F8 RID: 1784 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006F8")]
	[Address(RVA = "0x352A480", Offset = "0x3528A80", VA = "0x18352A480")]
	private static void P2PSessionRequest(P2PSessionRequest_t param)
	{
	}

	// Token: 0x060006F9 RID: 1785 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006F9")]
	[Address(RVA = "0x352A660", Offset = "0x3528C60", VA = "0x18352A660")]
	private static void SteamServerConnectFailure(SteamServerConnectFailure_t param)
	{
	}

	// Token: 0x060006FA RID: 1786 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006FA")]
	[Address(RVA = "0x352A840", Offset = "0x3528E40", VA = "0x18352A840")]
	private static void SteamServersDisconnected(SteamServersDisconnected_t param)
	{
	}

	// Token: 0x060006FB RID: 1787 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006FB")]
	[Address(RVA = "0x352AA50", Offset = "0x3529050", VA = "0x18352AA50")]
	private static void SteamServersConnected(SteamServersConnected_t param)
	{
	}

	// Token: 0x040005BE RID: 1470
	[Token(Token = "0x40005BE")]
	[FieldOffset(Offset = "0x0")]
	private static bool runInit;

	// Token: 0x040005BF RID: 1471
	[Token(Token = "0x40005BF")]
	[FieldOffset(Offset = "0x8")]
	private static Action Connected;

	// Token: 0x040005C0 RID: 1472
	[Token(Token = "0x40005C0")]
	[FieldOffset(Offset = "0x10")]
	private static Action Failed;

	// Token: 0x040005C1 RID: 1473
	[Token(Token = "0x40005C1")]
	[FieldOffset(Offset = "0x18")]
	private static Callback<P2PSessionRequest_t> P2PSessionRequest_Callback;

	// Token: 0x040005C2 RID: 1474
	[Token(Token = "0x40005C2")]
	[FieldOffset(Offset = "0x20")]
	private static Callback<SteamServersConnected_t> SteamServersConnected_Callback;

	// Token: 0x040005C3 RID: 1475
	[Token(Token = "0x40005C3")]
	[FieldOffset(Offset = "0x28")]
	private static Callback<SteamServersDisconnected_t> SteamServersDisconnected_Callback;

	// Token: 0x040005C4 RID: 1476
	[Token(Token = "0x40005C4")]
	[FieldOffset(Offset = "0x30")]
	private static Callback<SteamServerConnectFailure_t> SteamServerConnectFailure_Callback;
}
