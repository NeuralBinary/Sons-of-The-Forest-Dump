using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200000F RID: 15
	[Token(Token = "0x200000F")]
	public static class SteamGameServerStats
	{
		// Token: 0x06000181 RID: 385 RVA: 0x00003D94 File Offset: 0x00001F94
		[Token(Token = "0x6000181")]
		[Address(RVA = "0x9233A0", Offset = "0x9219A0", VA = "0x1809233A0")]
		public static SteamAPICall_t RequestUserStats(CSteamID steamIDUser)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00003DAC File Offset: 0x00001FAC
		[Token(Token = "0x6000182")]
		[Address(RVA = "0x923490", Offset = "0x921A90", VA = "0x180923490")]
		public static bool GetUserStat(CSteamID steamIDUser, string pchName, out int pData)
		{
			return default(bool);
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00003DC4 File Offset: 0x00001FC4
		[Token(Token = "0x6000183")]
		[Address(RVA = "0x923690", Offset = "0x921C90", VA = "0x180923690")]
		public static bool GetUserStat(CSteamID steamIDUser, string pchName, out float pData)
		{
			return default(bool);
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00003DDC File Offset: 0x00001FDC
		[Token(Token = "0x6000184")]
		[Address(RVA = "0x923890", Offset = "0x921E90", VA = "0x180923890")]
		public static bool GetUserAchievement(CSteamID steamIDUser, string pchName, out bool pbAchieved)
		{
			return default(bool);
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00003DF4 File Offset: 0x00001FF4
		[Token(Token = "0x6000185")]
		[Address(RVA = "0x923AA0", Offset = "0x9220A0", VA = "0x180923AA0")]
		public static bool SetUserStat(CSteamID steamIDUser, string pchName, int nData)
		{
			return default(bool);
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00003E0C File Offset: 0x0000200C
		[Token(Token = "0x6000186")]
		[Address(RVA = "0x923CA0", Offset = "0x9222A0", VA = "0x180923CA0")]
		public static bool SetUserStat(CSteamID steamIDUser, string pchName, float fData)
		{
			return default(bool);
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00003E24 File Offset: 0x00002024
		[Token(Token = "0x6000187")]
		[Address(RVA = "0x923EA0", Offset = "0x9224A0", VA = "0x180923EA0")]
		public static bool UpdateUserAvgRateStat(CSteamID steamIDUser, string pchName, float flCountThisSession, double dSessionLength)
		{
			return default(bool);
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00003E3C File Offset: 0x0000203C
		[Token(Token = "0x6000188")]
		[Address(RVA = "0x9240B0", Offset = "0x9226B0", VA = "0x1809240B0")]
		public static bool SetUserAchievement(CSteamID steamIDUser, string pchName)
		{
			return default(bool);
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00003E54 File Offset: 0x00002054
		[Token(Token = "0x6000189")]
		[Address(RVA = "0x9242A0", Offset = "0x9228A0", VA = "0x1809242A0")]
		public static bool ClearUserAchievement(CSteamID steamIDUser, string pchName)
		{
			return default(bool);
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00003E6C File Offset: 0x0000206C
		[Token(Token = "0x600018A")]
		[Address(RVA = "0x924490", Offset = "0x922A90", VA = "0x180924490")]
		public static SteamAPICall_t StoreUserStats(CSteamID steamIDUser)
		{
			return default(SteamAPICall_t);
		}
	}
}
