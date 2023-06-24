using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200000E RID: 14
	[Token(Token = "0x200000E")]
	public static class SteamGameServerNetworkingUtils
	{
		// Token: 0x06000166 RID: 358 RVA: 0x00003B9C File Offset: 0x00001D9C
		[Token(Token = "0x6000166")]
		[Address(RVA = "0x9224A0", Offset = "0x920AA0", VA = "0x1809224A0")]
		public static IntPtr AllocateMessage(int cbAllocateBuffer)
		{
			return 0;
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000167")]
		[Address(RVA = "0x9224F0", Offset = "0x920AF0", VA = "0x1809224F0")]
		public static void InitRelayNetworkAccess()
		{
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00003BB4 File Offset: 0x00001DB4
		[Token(Token = "0x6000168")]
		[Address(RVA = "0x922540", Offset = "0x920B40", VA = "0x180922540")]
		public static ESteamNetworkingAvailability GetRelayNetworkStatus(out SteamRelayNetworkStatus_t pDetails)
		{
			return ESteamNetworkingAvailability.k_ESteamNetworkingAvailability_Unknown;
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00003BCC File Offset: 0x00001DCC
		[Token(Token = "0x6000169")]
		[Address(RVA = "0x922590", Offset = "0x920B90", VA = "0x180922590")]
		public static float GetLocalPingLocation(out SteamNetworkPingLocation_t result)
		{
			return 0f;
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00003BE4 File Offset: 0x00001DE4
		[Token(Token = "0x600016A")]
		[Address(RVA = "0x9225E0", Offset = "0x920BE0", VA = "0x1809225E0")]
		public static int EstimatePingTimeBetweenTwoLocations(ref SteamNetworkPingLocation_t location1, ref SteamNetworkPingLocation_t location2)
		{
			return 0;
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00003BFC File Offset: 0x00001DFC
		[Token(Token = "0x600016B")]
		[Address(RVA = "0x922640", Offset = "0x920C40", VA = "0x180922640")]
		public static int EstimatePingTimeFromLocalHost(ref SteamNetworkPingLocation_t remoteLocation)
		{
			return 0;
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600016C")]
		[Address(RVA = "0x922690", Offset = "0x920C90", VA = "0x180922690")]
		public static void ConvertPingLocationToString(ref SteamNetworkPingLocation_t location, out string pszBuf, int cchBufSize)
		{
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00003C14 File Offset: 0x00001E14
		[Token(Token = "0x600016D")]
		[Address(RVA = "0x9227D0", Offset = "0x920DD0", VA = "0x1809227D0")]
		public static bool ParsePingLocationString(string pszString, out SteamNetworkPingLocation_t result)
		{
			return default(bool);
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00003C2C File Offset: 0x00001E2C
		[Token(Token = "0x600016E")]
		[Address(RVA = "0x9228F0", Offset = "0x920EF0", VA = "0x1809228F0")]
		public static bool CheckPingDataUpToDate(float flMaxAgeSeconds)
		{
			return default(bool);
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00003C44 File Offset: 0x00001E44
		[Token(Token = "0x600016F")]
		[Address(RVA = "0x922950", Offset = "0x920F50", VA = "0x180922950")]
		public static int GetPingToDataCenter(SteamNetworkingPOPID popID, out SteamNetworkingPOPID pViaRelayPoP)
		{
			return 0;
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00003C5C File Offset: 0x00001E5C
		[Token(Token = "0x6000170")]
		[Address(RVA = "0x9229B0", Offset = "0x920FB0", VA = "0x1809229B0")]
		public static int GetDirectPingToPOP(SteamNetworkingPOPID popID)
		{
			return 0;
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00003C74 File Offset: 0x00001E74
		[Token(Token = "0x6000171")]
		[Address(RVA = "0x922A00", Offset = "0x921000", VA = "0x180922A00")]
		public static int GetPOPCount()
		{
			return 0;
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00003C8C File Offset: 0x00001E8C
		[Token(Token = "0x6000172")]
		[Address(RVA = "0x922A50", Offset = "0x921050", VA = "0x180922A50")]
		public static int GetPOPList(out SteamNetworkingPOPID list, int nListSz)
		{
			return 0;
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00003CA4 File Offset: 0x00001EA4
		[Token(Token = "0x6000173")]
		[Address(RVA = "0x922AB0", Offset = "0x9210B0", VA = "0x180922AB0")]
		public static SteamNetworkingMicroseconds GetLocalTimestamp()
		{
			return default(SteamNetworkingMicroseconds);
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000174")]
		[Address(RVA = "0x922B00", Offset = "0x921100", VA = "0x180922B00")]
		public static void SetDebugOutputFunction(ESteamNetworkingSocketsDebugOutputType eDetailLevel, FSteamNetworkingSocketsDebugOutput pfnFunc)
		{
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00003CBC File Offset: 0x00001EBC
		[Token(Token = "0x6000175")]
		[Address(RVA = "0x922B60", Offset = "0x921160", VA = "0x180922B60")]
		public static bool IsFakeIPv4(uint nIPv4)
		{
			return default(bool);
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00003CD4 File Offset: 0x00001ED4
		[Token(Token = "0x6000176")]
		[Address(RVA = "0x922BB0", Offset = "0x9211B0", VA = "0x180922BB0")]
		public static ESteamNetworkingFakeIPType GetIPv4FakeIPType(uint nIPv4)
		{
			return ESteamNetworkingFakeIPType.k_ESteamNetworkingFakeIPType_Invalid;
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00003CEC File Offset: 0x00001EEC
		[Token(Token = "0x6000177")]
		[Address(RVA = "0x922C00", Offset = "0x921200", VA = "0x180922C00")]
		public static EResult GetRealIdentityForFakeIP(ref SteamNetworkingIPAddr fakeIP, out SteamNetworkingIdentity pOutRealIdentity)
		{
			return EResult.k_EResultNone;
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00003D04 File Offset: 0x00001F04
		[Token(Token = "0x6000178")]
		[Address(RVA = "0x922C60", Offset = "0x921260", VA = "0x180922C60")]
		public static bool SetConfigValue(ESteamNetworkingConfigValue eValue, ESteamNetworkingConfigScope eScopeType, IntPtr scopeObj, ESteamNetworkingConfigDataType eDataType, IntPtr pArg)
		{
			return default(bool);
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00003D1C File Offset: 0x00001F1C
		[Token(Token = "0x6000179")]
		[Address(RVA = "0x922CF0", Offset = "0x9212F0", VA = "0x180922CF0")]
		public static ESteamNetworkingGetConfigValueResult GetConfigValue(ESteamNetworkingConfigValue eValue, ESteamNetworkingConfigScope eScopeType, IntPtr scopeObj, out ESteamNetworkingConfigDataType pOutDataType, IntPtr pResult, ref ulong cbResult)
		{
			return (ESteamNetworkingGetConfigValueResult)0;
		}

		// Token: 0x0600017A RID: 378 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x600017A")]
		[Address(RVA = "0x922D90", Offset = "0x921390", VA = "0x180922D90")]
		public static string GetConfigValueInfo(ESteamNetworkingConfigValue eValue, out ESteamNetworkingConfigDataType pOutDataType, out ESteamNetworkingConfigScope pOutScope)
		{
			return null;
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00003D34 File Offset: 0x00001F34
		[Token(Token = "0x600017B")]
		[Address(RVA = "0x922E10", Offset = "0x921410", VA = "0x180922E10")]
		public static ESteamNetworkingConfigValue IterateGenericEditableConfigValues(ESteamNetworkingConfigValue eCurrent, bool bEnumerateDevVars)
		{
			return ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_Invalid;
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600017C")]
		[Address(RVA = "0x922E70", Offset = "0x921470", VA = "0x180922E70")]
		public static void SteamNetworkingIPAddr_ToString(ref SteamNetworkingIPAddr addr, out string buf, uint cbBuf, bool bWithPort)
		{
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00003D4C File Offset: 0x00001F4C
		[Token(Token = "0x600017D")]
		[Address(RVA = "0x922FD0", Offset = "0x9215D0", VA = "0x180922FD0")]
		public static bool SteamNetworkingIPAddr_ParseString(out SteamNetworkingIPAddr pAddr, string pszStr)
		{
			return default(bool);
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00003D64 File Offset: 0x00001F64
		[Token(Token = "0x600017E")]
		[Address(RVA = "0x9230F0", Offset = "0x9216F0", VA = "0x1809230F0")]
		public static ESteamNetworkingFakeIPType SteamNetworkingIPAddr_GetFakeIPType(ref SteamNetworkingIPAddr addr)
		{
			return ESteamNetworkingFakeIPType.k_ESteamNetworkingFakeIPType_Invalid;
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600017F")]
		[Address(RVA = "0x923140", Offset = "0x921740", VA = "0x180923140")]
		public static void SteamNetworkingIdentity_ToString(ref SteamNetworkingIdentity identity, out string buf, uint cbBuf)
		{
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00003D7C File Offset: 0x00001F7C
		[Token(Token = "0x6000180")]
		[Address(RVA = "0x923280", Offset = "0x921880", VA = "0x180923280")]
		public static bool SteamNetworkingIdentity_ParseString(out SteamNetworkingIdentity pIdentity, string pszStr)
		{
			return default(bool);
		}
	}
}
