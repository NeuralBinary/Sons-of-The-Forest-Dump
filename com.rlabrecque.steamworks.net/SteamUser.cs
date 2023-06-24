using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000025 RID: 37
	[Token(Token = "0x2000025")]
	public static class SteamUser
	{
		// Token: 0x0600041F RID: 1055 RVA: 0x00007214 File Offset: 0x00005414
		[Token(Token = "0x600041F")]
		[Address(RVA = "0x9499D0", Offset = "0x947FD0", VA = "0x1809499D0")]
		public static HSteamUser GetHSteamUser()
		{
			return default(HSteamUser);
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x0000722C File Offset: 0x0000542C
		[Token(Token = "0x6000420")]
		[Address(RVA = "0x949A80", Offset = "0x948080", VA = "0x180949A80")]
		public static bool BLoggedOn()
		{
			return default(bool);
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x00007244 File Offset: 0x00005444
		[Token(Token = "0x6000421")]
		[Address(RVA = "0x949B30", Offset = "0x948130", VA = "0x180949B30")]
		public static CSteamID GetSteamID()
		{
			return default(CSteamID);
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x0000725C File Offset: 0x0000545C
		[Token(Token = "0x6000422")]
		[Address(RVA = "0x949C20", Offset = "0x948220", VA = "0x180949C20")]
		public static int InitiateGameConnection_DEPRECATED(byte[] pAuthBlob, int cbMaxAuthBlob, CSteamID steamIDGameServer, uint unIPServer, ushort usPortServer, bool bSecure)
		{
			return 0;
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000423")]
		[Address(RVA = "0x949D40", Offset = "0x948340", VA = "0x180949D40")]
		public static void TerminateGameConnection_DEPRECATED(uint unIPServer, ushort usPortServer)
		{
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000424")]
		[Address(RVA = "0x949E10", Offset = "0x948410", VA = "0x180949E10")]
		public static void TrackAppUsageEvent(CGameID gameID, int eAppUsageEvent, string pchExtraInfo = "")
		{
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x00007274 File Offset: 0x00005474
		[Token(Token = "0x6000425")]
		[Address(RVA = "0x949FF0", Offset = "0x9485F0", VA = "0x180949FF0")]
		public static bool GetUserDataFolder(out string pchBuffer, int cubBuffer)
		{
			return default(bool);
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000426")]
		[Address(RVA = "0x94A1C0", Offset = "0x9487C0", VA = "0x18094A1C0")]
		public static void StartVoiceRecording()
		{
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000427")]
		[Address(RVA = "0x94A270", Offset = "0x948870", VA = "0x18094A270")]
		public static void StopVoiceRecording()
		{
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x0000728C File Offset: 0x0000548C
		[Token(Token = "0x6000428")]
		[Address(RVA = "0x94A320", Offset = "0x948920", VA = "0x18094A320")]
		public static EVoiceResult GetAvailableVoice(out uint pcbCompressed)
		{
			return EVoiceResult.k_EVoiceResultOK;
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x000072A4 File Offset: 0x000054A4
		[Token(Token = "0x6000429")]
		[Address(RVA = "0x94A3E0", Offset = "0x9489E0", VA = "0x18094A3E0")]
		public static EVoiceResult GetVoice(bool bWantCompressed, byte[] pDestBuffer, uint cbDestBufferSize, out uint nBytesWritten)
		{
			return EVoiceResult.k_EVoiceResultOK;
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x000072BC File Offset: 0x000054BC
		[Token(Token = "0x600042A")]
		[Address(RVA = "0x94A500", Offset = "0x948B00", VA = "0x18094A500")]
		public static EVoiceResult DecompressVoice(byte[] pCompressed, uint cbCompressed, byte[] pDestBuffer, uint cbDestBufferSize, out uint nBytesWritten, uint nDesiredSampleRate)
		{
			return EVoiceResult.k_EVoiceResultOK;
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x000072D4 File Offset: 0x000054D4
		[Token(Token = "0x600042B")]
		[Address(RVA = "0x94A630", Offset = "0x948C30", VA = "0x18094A630")]
		public static uint GetVoiceOptimalSampleRate()
		{
			return 0U;
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x000072EC File Offset: 0x000054EC
		[Token(Token = "0x600042C")]
		[Address(RVA = "0x94A6E0", Offset = "0x948CE0", VA = "0x18094A6E0")]
		public static HAuthTicket GetAuthSessionTicket(byte[] pTicket, int cbMaxTicket, out uint pcbTicket)
		{
			return default(HAuthTicket);
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x00007304 File Offset: 0x00005504
		[Token(Token = "0x600042D")]
		[Address(RVA = "0x94A800", Offset = "0x948E00", VA = "0x18094A800")]
		public static EBeginAuthSessionResult BeginAuthSession(byte[] pAuthTicket, int cbAuthTicket, CSteamID steamID)
		{
			return EBeginAuthSessionResult.k_EBeginAuthSessionResultOK;
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600042E")]
		[Address(RVA = "0x94A8F0", Offset = "0x948EF0", VA = "0x18094A8F0")]
		public static void EndAuthSession(CSteamID steamID)
		{
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600042F")]
		[Address(RVA = "0x94A9B0", Offset = "0x948FB0", VA = "0x18094A9B0")]
		public static void CancelAuthTicket(HAuthTicket hAuthTicket)
		{
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x0000731C File Offset: 0x0000551C
		[Token(Token = "0x6000430")]
		[Address(RVA = "0x94AA70", Offset = "0x949070", VA = "0x18094AA70")]
		public static EUserHasLicenseForAppResult UserHasLicenseForApp(CSteamID steamID, AppId_t appID)
		{
			return EUserHasLicenseForAppResult.k_EUserHasLicenseResultHasLicense;
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x00007334 File Offset: 0x00005534
		[Token(Token = "0x6000431")]
		[Address(RVA = "0x94AB40", Offset = "0x949140", VA = "0x18094AB40")]
		public static bool BIsBehindNAT()
		{
			return default(bool);
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000432")]
		[Address(RVA = "0x94ABF0", Offset = "0x9491F0", VA = "0x18094ABF0")]
		public static void AdvertiseGame(CSteamID steamIDGameServer, uint unIPServer, ushort usPortServer)
		{
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x0000734C File Offset: 0x0000554C
		[Token(Token = "0x6000433")]
		[Address(RVA = "0x94ACD0", Offset = "0x9492D0", VA = "0x18094ACD0")]
		public static SteamAPICall_t RequestEncryptedAppTicket(byte[] pDataToInclude, int cbDataToInclude)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x00007364 File Offset: 0x00005564
		[Token(Token = "0x6000434")]
		[Address(RVA = "0x94ADE0", Offset = "0x9493E0", VA = "0x18094ADE0")]
		public static bool GetEncryptedAppTicket(byte[] pTicket, int cbMaxTicket, out uint pcbTicket)
		{
			return default(bool);
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x0000737C File Offset: 0x0000557C
		[Token(Token = "0x6000435")]
		[Address(RVA = "0x94AED0", Offset = "0x9494D0", VA = "0x18094AED0")]
		public static int GetGameBadgeLevel(int nSeries, bool bFoil)
		{
			return 0;
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x00007394 File Offset: 0x00005594
		[Token(Token = "0x6000436")]
		[Address(RVA = "0x94AFA0", Offset = "0x9495A0", VA = "0x18094AFA0")]
		public static int GetPlayerSteamLevel()
		{
			return 0;
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x000073AC File Offset: 0x000055AC
		[Token(Token = "0x6000437")]
		[Address(RVA = "0x94B050", Offset = "0x949650", VA = "0x18094B050")]
		public static SteamAPICall_t RequestStoreAuthURL(string pchRedirectURL)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x000073C4 File Offset: 0x000055C4
		[Token(Token = "0x6000438")]
		[Address(RVA = "0x94B260", Offset = "0x949860", VA = "0x18094B260")]
		public static bool BIsPhoneVerified()
		{
			return default(bool);
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x000073DC File Offset: 0x000055DC
		[Token(Token = "0x6000439")]
		[Address(RVA = "0x94B310", Offset = "0x949910", VA = "0x18094B310")]
		public static bool BIsTwoFactorEnabled()
		{
			return default(bool);
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x000073F4 File Offset: 0x000055F4
		[Token(Token = "0x600043A")]
		[Address(RVA = "0x94B3C0", Offset = "0x9499C0", VA = "0x18094B3C0")]
		public static bool BIsPhoneIdentifying()
		{
			return default(bool);
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x0000740C File Offset: 0x0000560C
		[Token(Token = "0x600043B")]
		[Address(RVA = "0x94B470", Offset = "0x949A70", VA = "0x18094B470")]
		public static bool BIsPhoneRequiringVerification()
		{
			return default(bool);
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x00007424 File Offset: 0x00005624
		[Token(Token = "0x600043C")]
		[Address(RVA = "0x94B520", Offset = "0x949B20", VA = "0x18094B520")]
		public static SteamAPICall_t GetMarketEligibility()
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x0000743C File Offset: 0x0000563C
		[Token(Token = "0x600043D")]
		[Address(RVA = "0x94B610", Offset = "0x949C10", VA = "0x18094B610")]
		public static SteamAPICall_t GetDurationControl()
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x00007454 File Offset: 0x00005654
		[Token(Token = "0x600043E")]
		[Address(RVA = "0x94B700", Offset = "0x949D00", VA = "0x18094B700")]
		public static bool BSetDurationControlOnlineState(EDurationControlOnlineState eNewState)
		{
			return default(bool);
		}
	}
}
