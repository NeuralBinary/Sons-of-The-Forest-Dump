using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	public static class SteamClient
	{
		// Token: 0x06000025 RID: 37 RVA: 0x000022F4 File Offset: 0x000004F4
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x910870", Offset = "0x90EE70", VA = "0x180910870")]
		public static HSteamPipe CreateSteamPipe()
		{
			return default(HSteamPipe);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0000230C File Offset: 0x0000050C
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x9108C0", Offset = "0x90EEC0", VA = "0x1809108C0")]
		public static bool BReleaseSteamPipe(HSteamPipe hSteamPipe)
		{
			return default(bool);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002324 File Offset: 0x00000524
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x910910", Offset = "0x90EF10", VA = "0x180910910")]
		public static HSteamUser ConnectToGlobalUser(HSteamPipe hSteamPipe)
		{
			return default(HSteamUser);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000233C File Offset: 0x0000053C
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x910960", Offset = "0x90EF60", VA = "0x180910960")]
		public static HSteamUser CreateLocalUser(out HSteamPipe phSteamPipe, EAccountType eAccountType)
		{
			return default(HSteamUser);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x9109C0", Offset = "0x90EFC0", VA = "0x1809109C0")]
		public static void ReleaseUser(HSteamPipe hSteamPipe, HSteamUser hUser)
		{
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002354 File Offset: 0x00000554
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x910A20", Offset = "0x90F020", VA = "0x180910A20")]
		public static IntPtr GetISteamUser(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x0000236C File Offset: 0x0000056C
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x910B60", Offset = "0x90F160", VA = "0x180910B60")]
		public static IntPtr GetISteamGameServer(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x910CA0", Offset = "0x90F2A0", VA = "0x180910CA0")]
		public static void SetLocalIPBinding(ref SteamIPAddress_t unIP, ushort usPort)
		{
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002384 File Offset: 0x00000584
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x910D00", Offset = "0x90F300", VA = "0x180910D00")]
		public static IntPtr GetISteamFriends(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x0000239C File Offset: 0x0000059C
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x910E40", Offset = "0x90F440", VA = "0x180910E40")]
		public static IntPtr GetISteamUtils(HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000023B4 File Offset: 0x000005B4
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x910F60", Offset = "0x90F560", VA = "0x180910F60")]
		public static IntPtr GetISteamMatchmaking(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000023CC File Offset: 0x000005CC
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x9110A0", Offset = "0x90F6A0", VA = "0x1809110A0")]
		public static IntPtr GetISteamMatchmakingServers(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000023E4 File Offset: 0x000005E4
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x9111E0", Offset = "0x90F7E0", VA = "0x1809111E0")]
		public static IntPtr GetISteamGenericInterface(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000023FC File Offset: 0x000005FC
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x911320", Offset = "0x90F920", VA = "0x180911320")]
		public static IntPtr GetISteamUserStats(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002414 File Offset: 0x00000614
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x911460", Offset = "0x90FA60", VA = "0x180911460")]
		public static IntPtr GetISteamGameServerStats(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x0000242C File Offset: 0x0000062C
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x9115A0", Offset = "0x90FBA0", VA = "0x1809115A0")]
		public static IntPtr GetISteamApps(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002444 File Offset: 0x00000644
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x9116E0", Offset = "0x90FCE0", VA = "0x1809116E0")]
		public static IntPtr GetISteamNetworking(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x0000245C File Offset: 0x0000065C
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x911820", Offset = "0x90FE20", VA = "0x180911820")]
		public static IntPtr GetISteamRemoteStorage(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002474 File Offset: 0x00000674
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x911960", Offset = "0x90FF60", VA = "0x180911960")]
		public static IntPtr GetISteamScreenshots(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x0000248C File Offset: 0x0000068C
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x911AA0", Offset = "0x9100A0", VA = "0x180911AA0")]
		public static IntPtr GetISteamGameSearch(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000024A4 File Offset: 0x000006A4
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x911BE0", Offset = "0x9101E0", VA = "0x180911BE0")]
		public static uint GetIPCCallCount()
		{
			return 0U;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x911C30", Offset = "0x910230", VA = "0x180911C30")]
		public static void SetWarningMessageHook(SteamAPIWarningMessageHook_t pFunction)
		{
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000024BC File Offset: 0x000006BC
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x911C80", Offset = "0x910280", VA = "0x180911C80")]
		public static bool BShutdownIfAllPipesClosed()
		{
			return default(bool);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000024D4 File Offset: 0x000006D4
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x911CD0", Offset = "0x9102D0", VA = "0x180911CD0")]
		public static IntPtr GetISteamHTTP(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000024EC File Offset: 0x000006EC
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x911E10", Offset = "0x910410", VA = "0x180911E10")]
		public static IntPtr GetISteamController(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002504 File Offset: 0x00000704
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x911F50", Offset = "0x910550", VA = "0x180911F50")]
		public static IntPtr GetISteamUGC(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x0000251C File Offset: 0x0000071C
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x912090", Offset = "0x910690", VA = "0x180912090")]
		public static IntPtr GetISteamAppList(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002534 File Offset: 0x00000734
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x9121D0", Offset = "0x9107D0", VA = "0x1809121D0")]
		public static IntPtr GetISteamMusic(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x0000254C File Offset: 0x0000074C
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x912310", Offset = "0x910910", VA = "0x180912310")]
		public static IntPtr GetISteamMusicRemote(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002564 File Offset: 0x00000764
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x912450", Offset = "0x910A50", VA = "0x180912450")]
		public static IntPtr GetISteamHTMLSurface(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x0000257C File Offset: 0x0000077C
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x912590", Offset = "0x910B90", VA = "0x180912590")]
		public static IntPtr GetISteamInventory(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002594 File Offset: 0x00000794
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x9126D0", Offset = "0x910CD0", VA = "0x1809126D0")]
		public static IntPtr GetISteamVideo(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x000025AC File Offset: 0x000007AC
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x912810", Offset = "0x910E10", VA = "0x180912810")]
		public static IntPtr GetISteamParentalSettings(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000025C4 File Offset: 0x000007C4
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x912950", Offset = "0x910F50", VA = "0x180912950")]
		public static IntPtr GetISteamInput(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000025DC File Offset: 0x000007DC
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x912A90", Offset = "0x911090", VA = "0x180912A90")]
		public static IntPtr GetISteamParties(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x000025F4 File Offset: 0x000007F4
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x912BD0", Offset = "0x9111D0", VA = "0x180912BD0")]
		public static IntPtr GetISteamRemotePlay(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}
	}
}
