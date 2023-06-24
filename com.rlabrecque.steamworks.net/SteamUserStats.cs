using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000026 RID: 38
	[Token(Token = "0x2000026")]
	public static class SteamUserStats
	{
		// Token: 0x0600043F RID: 1087 RVA: 0x0000746C File Offset: 0x0000566C
		[Token(Token = "0x600043F")]
		[Address(RVA = "0x94B7C0", Offset = "0x949DC0", VA = "0x18094B7C0")]
		public static bool RequestCurrentStats()
		{
			return default(bool);
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x00007484 File Offset: 0x00005684
		[Token(Token = "0x6000440")]
		[Address(RVA = "0x94B870", Offset = "0x949E70", VA = "0x18094B870")]
		public static bool GetStat(string pchName, out int pData)
		{
			return default(bool);
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x0000749C File Offset: 0x0000569C
		[Token(Token = "0x6000441")]
		[Address(RVA = "0x94BA60", Offset = "0x94A060", VA = "0x18094BA60")]
		public static bool GetStat(string pchName, out float pData)
		{
			return default(bool);
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x000074B4 File Offset: 0x000056B4
		[Token(Token = "0x6000442")]
		[Address(RVA = "0x94BC50", Offset = "0x94A250", VA = "0x18094BC50")]
		public static bool SetStat(string pchName, int nData)
		{
			return default(bool);
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x000074CC File Offset: 0x000056CC
		[Token(Token = "0x6000443")]
		[Address(RVA = "0x94BE40", Offset = "0x94A440", VA = "0x18094BE40")]
		public static bool SetStat(string pchName, float fData)
		{
			return default(bool);
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x000074E4 File Offset: 0x000056E4
		[Token(Token = "0x6000444")]
		[Address(RVA = "0x94C030", Offset = "0x94A630", VA = "0x18094C030")]
		public static bool UpdateAvgRateStat(string pchName, float flCountThisSession, double dSessionLength)
		{
			return default(bool);
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x000074FC File Offset: 0x000056FC
		[Token(Token = "0x6000445")]
		[Address(RVA = "0x94C230", Offset = "0x94A830", VA = "0x18094C230")]
		public static bool GetAchievement(string pchName, out bool pbAchieved)
		{
			return default(bool);
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x00007514 File Offset: 0x00005714
		[Token(Token = "0x6000446")]
		[Address(RVA = "0x94C440", Offset = "0x94AA40", VA = "0x18094C440")]
		public static bool SetAchievement(string pchName)
		{
			return default(bool);
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x0000752C File Offset: 0x0000572C
		[Token(Token = "0x6000447")]
		[Address(RVA = "0x94C630", Offset = "0x94AC30", VA = "0x18094C630")]
		public static bool ClearAchievement(string pchName)
		{
			return default(bool);
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x00007544 File Offset: 0x00005744
		[Token(Token = "0x6000448")]
		[Address(RVA = "0x94C820", Offset = "0x94AE20", VA = "0x18094C820")]
		public static bool GetAchievementAndUnlockTime(string pchName, out bool pbAchieved, out uint punUnlockTime)
		{
			return default(bool);
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x0000755C File Offset: 0x0000575C
		[Token(Token = "0x6000449")]
		[Address(RVA = "0x94CA30", Offset = "0x94B030", VA = "0x18094CA30")]
		public static bool StoreStats()
		{
			return default(bool);
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x00007574 File Offset: 0x00005774
		[Token(Token = "0x600044A")]
		[Address(RVA = "0x94CAE0", Offset = "0x94B0E0", VA = "0x18094CAE0")]
		public static int GetAchievementIcon(string pchName)
		{
			return 0;
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x600044B")]
		[Address(RVA = "0x94CCD0", Offset = "0x94B2D0", VA = "0x18094CCD0")]
		public static string GetAchievementDisplayAttribute(string pchName, string pchKey)
		{
			return null;
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x0000758C File Offset: 0x0000578C
		[Token(Token = "0x600044C")]
		[Address(RVA = "0x94CFA0", Offset = "0x94B5A0", VA = "0x18094CFA0")]
		public static bool IndicateAchievementProgress(string pchName, uint nCurProgress, uint nMaxProgress)
		{
			return default(bool);
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x000075A4 File Offset: 0x000057A4
		[Token(Token = "0x600044D")]
		[Address(RVA = "0x94D1A0", Offset = "0x94B7A0", VA = "0x18094D1A0")]
		public static uint GetNumAchievements()
		{
			return 0U;
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x600044E")]
		[Address(RVA = "0x94D250", Offset = "0x94B850", VA = "0x18094D250")]
		public static string GetAchievementName(uint iAchievement)
		{
			return null;
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x000075BC File Offset: 0x000057BC
		[Token(Token = "0x600044F")]
		[Address(RVA = "0x94D310", Offset = "0x94B910", VA = "0x18094D310")]
		public static SteamAPICall_t RequestUserStats(CSteamID steamIDUser)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x000075D4 File Offset: 0x000057D4
		[Token(Token = "0x6000450")]
		[Address(RVA = "0x94D400", Offset = "0x94BA00", VA = "0x18094D400")]
		public static bool GetUserStat(CSteamID steamIDUser, string pchName, out int pData)
		{
			return default(bool);
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x000075EC File Offset: 0x000057EC
		[Token(Token = "0x6000451")]
		[Address(RVA = "0x94D600", Offset = "0x94BC00", VA = "0x18094D600")]
		public static bool GetUserStat(CSteamID steamIDUser, string pchName, out float pData)
		{
			return default(bool);
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x00007604 File Offset: 0x00005804
		[Token(Token = "0x6000452")]
		[Address(RVA = "0x94D800", Offset = "0x94BE00", VA = "0x18094D800")]
		public static bool GetUserAchievement(CSteamID steamIDUser, string pchName, out bool pbAchieved)
		{
			return default(bool);
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x0000761C File Offset: 0x0000581C
		[Token(Token = "0x6000453")]
		[Address(RVA = "0x94DA10", Offset = "0x94C010", VA = "0x18094DA10")]
		public static bool GetUserAchievementAndUnlockTime(CSteamID steamIDUser, string pchName, out bool pbAchieved, out uint punUnlockTime)
		{
			return default(bool);
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x00007634 File Offset: 0x00005834
		[Token(Token = "0x6000454")]
		[Address(RVA = "0x94DC30", Offset = "0x94C230", VA = "0x18094DC30")]
		public static bool ResetAllStats(bool bAchievementsToo)
		{
			return default(bool);
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x0000764C File Offset: 0x0000584C
		[Token(Token = "0x6000455")]
		[Address(RVA = "0x94DCF0", Offset = "0x94C2F0", VA = "0x18094DCF0")]
		public static SteamAPICall_t FindOrCreateLeaderboard(string pchLeaderboardName, ELeaderboardSortMethod eLeaderboardSortMethod, ELeaderboardDisplayType eLeaderboardDisplayType)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x00007664 File Offset: 0x00005864
		[Token(Token = "0x6000456")]
		[Address(RVA = "0x94DF10", Offset = "0x94C510", VA = "0x18094DF10")]
		public static SteamAPICall_t FindLeaderboard(string pchLeaderboardName)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000457")]
		[Address(RVA = "0x94E120", Offset = "0x94C720", VA = "0x18094E120")]
		public static string GetLeaderboardName(SteamLeaderboard_t hSteamLeaderboard)
		{
			return null;
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x0000767C File Offset: 0x0000587C
		[Token(Token = "0x6000458")]
		[Address(RVA = "0x94E1F0", Offset = "0x94C7F0", VA = "0x18094E1F0")]
		public static int GetLeaderboardEntryCount(SteamLeaderboard_t hSteamLeaderboard)
		{
			return 0;
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x00007694 File Offset: 0x00005894
		[Token(Token = "0x6000459")]
		[Address(RVA = "0x94E2B0", Offset = "0x94C8B0", VA = "0x18094E2B0")]
		public static ELeaderboardSortMethod GetLeaderboardSortMethod(SteamLeaderboard_t hSteamLeaderboard)
		{
			return ELeaderboardSortMethod.k_ELeaderboardSortMethodNone;
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x000076AC File Offset: 0x000058AC
		[Token(Token = "0x600045A")]
		[Address(RVA = "0x94E370", Offset = "0x94C970", VA = "0x18094E370")]
		public static ELeaderboardDisplayType GetLeaderboardDisplayType(SteamLeaderboard_t hSteamLeaderboard)
		{
			return ELeaderboardDisplayType.k_ELeaderboardDisplayTypeNone;
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x000076C4 File Offset: 0x000058C4
		[Token(Token = "0x600045B")]
		[Address(RVA = "0x94E430", Offset = "0x94CA30", VA = "0x18094E430")]
		public static SteamAPICall_t DownloadLeaderboardEntries(SteamLeaderboard_t hSteamLeaderboard, ELeaderboardDataRequest eLeaderboardDataRequest, int nRangeStart, int nRangeEnd)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x000076DC File Offset: 0x000058DC
		[Token(Token = "0x600045C")]
		[Address(RVA = "0x94E560", Offset = "0x94CB60", VA = "0x18094E560")]
		public static SteamAPICall_t DownloadLeaderboardEntriesForUsers(SteamLeaderboard_t hSteamLeaderboard, CSteamID[] prgUsers, int cUsers)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x000076F4 File Offset: 0x000058F4
		[Token(Token = "0x600045D")]
		[Address(RVA = "0x94E680", Offset = "0x94CC80", VA = "0x18094E680")]
		public static bool GetDownloadedLeaderboardEntry(SteamLeaderboardEntries_t hSteamLeaderboardEntries, int index, out LeaderboardEntry_t pLeaderboardEntry, int[] pDetails, int cDetailsMax)
		{
			return default(bool);
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x0000770C File Offset: 0x0000590C
		[Token(Token = "0x600045E")]
		[Address(RVA = "0x94E790", Offset = "0x94CD90", VA = "0x18094E790")]
		public static SteamAPICall_t UploadLeaderboardScore(SteamLeaderboard_t hSteamLeaderboard, ELeaderboardUploadScoreMethod eLeaderboardUploadScoreMethod, int nScore, int[] pScoreDetails, int cScoreDetailsCount)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x00007724 File Offset: 0x00005924
		[Token(Token = "0x600045F")]
		[Address(RVA = "0x94E8D0", Offset = "0x94CED0", VA = "0x18094E8D0")]
		public static SteamAPICall_t AttachLeaderboardUGC(SteamLeaderboard_t hSteamLeaderboard, UGCHandle_t hUGC)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x0000773C File Offset: 0x0000593C
		[Token(Token = "0x6000460")]
		[Address(RVA = "0x94E9D0", Offset = "0x94CFD0", VA = "0x18094E9D0")]
		public static SteamAPICall_t GetNumberOfCurrentPlayers()
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x00007754 File Offset: 0x00005954
		[Token(Token = "0x6000461")]
		[Address(RVA = "0x94EAC0", Offset = "0x94D0C0", VA = "0x18094EAC0")]
		public static SteamAPICall_t RequestGlobalAchievementPercentages()
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x0000776C File Offset: 0x0000596C
		[Token(Token = "0x6000462")]
		[Address(RVA = "0x94EBB0", Offset = "0x94D1B0", VA = "0x18094EBB0")]
		public static int GetMostAchievedAchievementInfo(out string pchName, uint unNameBufLen, out float pflPercent, out bool pbAchieved)
		{
			return 0;
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x00007784 File Offset: 0x00005984
		[Token(Token = "0x6000463")]
		[Address(RVA = "0x94EDA0", Offset = "0x94D3A0", VA = "0x18094EDA0")]
		public static int GetNextMostAchievedAchievementInfo(int iIteratorPrevious, out string pchName, uint unNameBufLen, out float pflPercent, out bool pbAchieved)
		{
			return 0;
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x0000779C File Offset: 0x0000599C
		[Token(Token = "0x6000464")]
		[Address(RVA = "0x94EFA0", Offset = "0x94D5A0", VA = "0x18094EFA0")]
		public static bool GetAchievementAchievedPercent(string pchName, out float pflPercent)
		{
			return default(bool);
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x000077B4 File Offset: 0x000059B4
		[Token(Token = "0x6000465")]
		[Address(RVA = "0x94F190", Offset = "0x94D790", VA = "0x18094F190")]
		public static SteamAPICall_t RequestGlobalStats(int nHistoryDays)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x000077CC File Offset: 0x000059CC
		[Token(Token = "0x6000466")]
		[Address(RVA = "0x94F280", Offset = "0x94D880", VA = "0x18094F280")]
		public static bool GetGlobalStat(string pchStatName, out long pData)
		{
			return default(bool);
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x000077E4 File Offset: 0x000059E4
		[Token(Token = "0x6000467")]
		[Address(RVA = "0x94F470", Offset = "0x94DA70", VA = "0x18094F470")]
		public static bool GetGlobalStat(string pchStatName, out double pData)
		{
			return default(bool);
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x000077FC File Offset: 0x000059FC
		[Token(Token = "0x6000468")]
		[Address(RVA = "0x94F660", Offset = "0x94DC60", VA = "0x18094F660")]
		public static int GetGlobalStatHistory(string pchStatName, long[] pData, uint cubData)
		{
			return 0;
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x00007814 File Offset: 0x00005A14
		[Token(Token = "0x6000469")]
		[Address(RVA = "0x94F850", Offset = "0x94DE50", VA = "0x18094F850")]
		public static int GetGlobalStatHistory(string pchStatName, double[] pData, uint cubData)
		{
			return 0;
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x0000782C File Offset: 0x00005A2C
		[Token(Token = "0x600046A")]
		[Address(RVA = "0x94FA40", Offset = "0x94E040", VA = "0x18094FA40")]
		public static bool GetAchievementProgressLimits(string pchName, out int pnMinProgress, out int pnMaxProgress)
		{
			return default(bool);
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x00007844 File Offset: 0x00005A44
		[Token(Token = "0x600046B")]
		[Address(RVA = "0x94FC40", Offset = "0x94E240", VA = "0x18094FC40")]
		public static bool GetAchievementProgressLimits(string pchName, out float pfMinProgress, out float pfMaxProgress)
		{
			return default(bool);
		}
	}
}
