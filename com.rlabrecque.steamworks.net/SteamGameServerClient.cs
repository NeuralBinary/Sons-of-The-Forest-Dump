using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000009 RID: 9
	[Token(Token = "0x2000009")]
	public static class SteamGameServerClient
	{
		// Token: 0x060000BE RID: 190 RVA: 0x00002CCC File Offset: 0x00000ECC
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x91A8D0", Offset = "0x918ED0", VA = "0x18091A8D0")]
		public static HSteamPipe CreateSteamPipe()
		{
			return default(HSteamPipe);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00002CE4 File Offset: 0x00000EE4
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x91A920", Offset = "0x918F20", VA = "0x18091A920")]
		public static bool BReleaseSteamPipe(HSteamPipe hSteamPipe)
		{
			return default(bool);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00002CFC File Offset: 0x00000EFC
		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x91A970", Offset = "0x918F70", VA = "0x18091A970")]
		public static HSteamUser ConnectToGlobalUser(HSteamPipe hSteamPipe)
		{
			return default(HSteamUser);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00002D14 File Offset: 0x00000F14
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x91A9C0", Offset = "0x918FC0", VA = "0x18091A9C0")]
		public static HSteamUser CreateLocalUser(out HSteamPipe phSteamPipe, EAccountType eAccountType)
		{
			return default(HSteamUser);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x91AA20", Offset = "0x919020", VA = "0x18091AA20")]
		public static void ReleaseUser(HSteamPipe hSteamPipe, HSteamUser hUser)
		{
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00002D2C File Offset: 0x00000F2C
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x91AA80", Offset = "0x919080", VA = "0x18091AA80")]
		public static IntPtr GetISteamUser(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00002D44 File Offset: 0x00000F44
		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x91ABC0", Offset = "0x9191C0", VA = "0x18091ABC0")]
		public static IntPtr GetISteamGameServer(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x91AD00", Offset = "0x919300", VA = "0x18091AD00")]
		public static void SetLocalIPBinding(ref SteamIPAddress_t unIP, ushort usPort)
		{
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00002D5C File Offset: 0x00000F5C
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x91AD60", Offset = "0x919360", VA = "0x18091AD60")]
		public static IntPtr GetISteamFriends(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00002D74 File Offset: 0x00000F74
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x91AEA0", Offset = "0x9194A0", VA = "0x18091AEA0")]
		public static IntPtr GetISteamUtils(HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00002D8C File Offset: 0x00000F8C
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x91AFC0", Offset = "0x9195C0", VA = "0x18091AFC0")]
		public static IntPtr GetISteamMatchmaking(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00002DA4 File Offset: 0x00000FA4
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x91B100", Offset = "0x919700", VA = "0x18091B100")]
		public static IntPtr GetISteamMatchmakingServers(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00002DBC File Offset: 0x00000FBC
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x91B240", Offset = "0x919840", VA = "0x18091B240")]
		public static IntPtr GetISteamGenericInterface(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00002DD4 File Offset: 0x00000FD4
		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x91B380", Offset = "0x919980", VA = "0x18091B380")]
		public static IntPtr GetISteamUserStats(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00002DEC File Offset: 0x00000FEC
		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x91B4C0", Offset = "0x919AC0", VA = "0x18091B4C0")]
		public static IntPtr GetISteamGameServerStats(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00002E04 File Offset: 0x00001004
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x91B600", Offset = "0x919C00", VA = "0x18091B600")]
		public static IntPtr GetISteamApps(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00002E1C File Offset: 0x0000101C
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x91B740", Offset = "0x919D40", VA = "0x18091B740")]
		public static IntPtr GetISteamNetworking(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00002E34 File Offset: 0x00001034
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x91B880", Offset = "0x919E80", VA = "0x18091B880")]
		public static IntPtr GetISteamRemoteStorage(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00002E4C File Offset: 0x0000104C
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x91B9C0", Offset = "0x919FC0", VA = "0x18091B9C0")]
		public static IntPtr GetISteamScreenshots(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00002E64 File Offset: 0x00001064
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x91BB00", Offset = "0x91A100", VA = "0x18091BB00")]
		public static IntPtr GetISteamGameSearch(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00002E7C File Offset: 0x0000107C
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x91BC40", Offset = "0x91A240", VA = "0x18091BC40")]
		public static uint GetIPCCallCount()
		{
			return 0U;
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x91BC90", Offset = "0x91A290", VA = "0x18091BC90")]
		public static void SetWarningMessageHook(SteamAPIWarningMessageHook_t pFunction)
		{
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00002E94 File Offset: 0x00001094
		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x91BCE0", Offset = "0x91A2E0", VA = "0x18091BCE0")]
		public static bool BShutdownIfAllPipesClosed()
		{
			return default(bool);
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00002EAC File Offset: 0x000010AC
		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x91BD30", Offset = "0x91A330", VA = "0x18091BD30")]
		public static IntPtr GetISteamHTTP(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00002EC4 File Offset: 0x000010C4
		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x91BE70", Offset = "0x91A470", VA = "0x18091BE70")]
		public static IntPtr GetISteamController(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00002EDC File Offset: 0x000010DC
		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x91BFB0", Offset = "0x91A5B0", VA = "0x18091BFB0")]
		public static IntPtr GetISteamUGC(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00002EF4 File Offset: 0x000010F4
		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x91C0F0", Offset = "0x91A6F0", VA = "0x18091C0F0")]
		public static IntPtr GetISteamAppList(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00002F0C File Offset: 0x0000110C
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x91C230", Offset = "0x91A830", VA = "0x18091C230")]
		public static IntPtr GetISteamMusic(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00002F24 File Offset: 0x00001124
		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x91C370", Offset = "0x91A970", VA = "0x18091C370")]
		public static IntPtr GetISteamMusicRemote(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00002F3C File Offset: 0x0000113C
		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x91C4B0", Offset = "0x91AAB0", VA = "0x18091C4B0")]
		public static IntPtr GetISteamHTMLSurface(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00002F54 File Offset: 0x00001154
		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x91C5F0", Offset = "0x91ABF0", VA = "0x18091C5F0")]
		public static IntPtr GetISteamInventory(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00002F6C File Offset: 0x0000116C
		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x91C730", Offset = "0x91AD30", VA = "0x18091C730")]
		public static IntPtr GetISteamVideo(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00002F84 File Offset: 0x00001184
		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x91C870", Offset = "0x91AE70", VA = "0x18091C870")]
		public static IntPtr GetISteamParentalSettings(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00002F9C File Offset: 0x0000119C
		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x91C9B0", Offset = "0x91AFB0", VA = "0x18091C9B0")]
		public static IntPtr GetISteamInput(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00002FB4 File Offset: 0x000011B4
		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x91CAF0", Offset = "0x91B0F0", VA = "0x18091CAF0")]
		public static IntPtr GetISteamParties(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00002FCC File Offset: 0x000011CC
		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x91CC30", Offset = "0x91B230", VA = "0x18091CC30")]
		public static IntPtr GetISteamRemotePlay(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}
	}
}
