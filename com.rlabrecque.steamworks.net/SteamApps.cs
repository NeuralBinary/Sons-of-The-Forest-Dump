using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	public static class SteamApps
	{
		// Token: 0x06000008 RID: 8 RVA: 0x000020E0 File Offset: 0x000002E0
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x90EBB0", Offset = "0x90D1B0", VA = "0x18090EBB0")]
		public static bool BIsSubscribed()
		{
			return default(bool);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000020F8 File Offset: 0x000002F8
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x90EC60", Offset = "0x90D260", VA = "0x18090EC60")]
		public static bool BIsLowViolence()
		{
			return default(bool);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002110 File Offset: 0x00000310
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x90ED10", Offset = "0x90D310", VA = "0x18090ED10")]
		public static bool BIsCybercafe()
		{
			return default(bool);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002128 File Offset: 0x00000328
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x90EDC0", Offset = "0x90D3C0", VA = "0x18090EDC0")]
		public static bool BIsVACBanned()
		{
			return default(bool);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x90EE70", Offset = "0x90D470", VA = "0x18090EE70")]
		public static string GetCurrentGameLanguage()
		{
			return null;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x90EF30", Offset = "0x90D530", VA = "0x18090EF30")]
		public static string GetAvailableGameLanguages()
		{
			return null;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002144 File Offset: 0x00000344
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x90EFF0", Offset = "0x90D5F0", VA = "0x18090EFF0")]
		public static bool BIsSubscribedApp(AppId_t appID)
		{
			return default(bool);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x0000215C File Offset: 0x0000035C
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x90F0B0", Offset = "0x90D6B0", VA = "0x18090F0B0")]
		public static bool BIsDlcInstalled(AppId_t appID)
		{
			return default(bool);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002174 File Offset: 0x00000374
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x90F170", Offset = "0x90D770", VA = "0x18090F170")]
		public static uint GetEarliestPurchaseUnixTime(AppId_t nAppID)
		{
			return 0U;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x0000218C File Offset: 0x0000038C
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x90F230", Offset = "0x90D830", VA = "0x18090F230")]
		public static bool BIsSubscribedFromFreeWeekend()
		{
			return default(bool);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000021A4 File Offset: 0x000003A4
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x90F2E0", Offset = "0x90D8E0", VA = "0x18090F2E0")]
		public static int GetDLCCount()
		{
			return 0;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000021BC File Offset: 0x000003BC
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x90F390", Offset = "0x90D990", VA = "0x18090F390")]
		public static bool BGetDLCDataByIndex(int iDLC, out AppId_t pAppID, out bool pbAvailable, out string pchName, int cchNameBufferSize)
		{
			return default(bool);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x90F5A0", Offset = "0x90DBA0", VA = "0x18090F5A0")]
		public static void InstallDLC(AppId_t nAppID)
		{
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x90F660", Offset = "0x90DC60", VA = "0x18090F660")]
		public static void UninstallDLC(AppId_t nAppID)
		{
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x90F720", Offset = "0x90DD20", VA = "0x18090F720")]
		public static void RequestAppProofOfPurchaseKey(AppId_t nAppID)
		{
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000021D4 File Offset: 0x000003D4
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x90F7E0", Offset = "0x90DDE0", VA = "0x18090F7E0")]
		public static bool GetCurrentBetaName(out string pchName, int cchNameBufferSize)
		{
			return default(bool);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000021EC File Offset: 0x000003EC
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x90F9B0", Offset = "0x90DFB0", VA = "0x18090F9B0")]
		public static bool MarkContentCorrupt(bool bMissingFilesOnly)
		{
			return default(bool);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002204 File Offset: 0x00000404
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x90FA70", Offset = "0x90E070", VA = "0x18090FA70")]
		public static uint GetInstalledDepots(AppId_t appID, DepotId_t[] pvecDepots, uint cMaxDepots)
		{
			return 0U;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x0000221C File Offset: 0x0000041C
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x90FB60", Offset = "0x90E160", VA = "0x18090FB60")]
		public static uint GetAppInstallDir(AppId_t appID, out string pchFolder, uint cchFolderBufferSize)
		{
			return 0U;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002234 File Offset: 0x00000434
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x90FD30", Offset = "0x90E330", VA = "0x18090FD30")]
		public static bool BIsAppInstalled(AppId_t appID)
		{
			return default(bool);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x0000224C File Offset: 0x0000044C
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x90FDF0", Offset = "0x90E3F0", VA = "0x18090FDF0")]
		public static CSteamID GetAppOwner()
		{
			return default(CSteamID);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x90FEE0", Offset = "0x90E4E0", VA = "0x18090FEE0")]
		public static string GetLaunchQueryParam(string pchKey)
		{
			return null;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002264 File Offset: 0x00000464
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x9100E0", Offset = "0x90E6E0", VA = "0x1809100E0")]
		public static bool GetDlcDownloadProgress(AppId_t nAppID, out ulong punBytesDownloaded, out ulong punBytesTotal)
		{
			return default(bool);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x0000227C File Offset: 0x0000047C
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x9101C0", Offset = "0x90E7C0", VA = "0x1809101C0")]
		public static int GetAppBuildId()
		{
			return 0;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x910270", Offset = "0x90E870", VA = "0x180910270")]
		public static void RequestAllProofOfPurchaseKeys()
		{
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002294 File Offset: 0x00000494
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x910320", Offset = "0x90E920", VA = "0x180910320")]
		public static SteamAPICall_t GetFileDetails(string pszFileName)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000022AC File Offset: 0x000004AC
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x910530", Offset = "0x90EB30", VA = "0x180910530")]
		public static int GetLaunchCommandLine(out string pszCommandLine, int cubCommandLine)
		{
			return 0;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000022C4 File Offset: 0x000004C4
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x9106F0", Offset = "0x90ECF0", VA = "0x1809106F0")]
		public static bool BIsSubscribedFromFamilySharing()
		{
			return default(bool);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000022DC File Offset: 0x000004DC
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x9107A0", Offset = "0x90EDA0", VA = "0x1809107A0")]
		public static bool BIsTimedTrial(out uint punSecondsAllowed, out uint punSecondsPlayed)
		{
			return default(bool);
		}
	}
}
