using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200001F RID: 31
	[Token(Token = "0x200001F")]
	public static class SteamNetworkingUtils
	{
		// Token: 0x0600035D RID: 861 RVA: 0x0000611C File Offset: 0x0000431C
		[Token(Token = "0x600035D")]
		[Address(RVA = "0x93DAC0", Offset = "0x93C0C0", VA = "0x18093DAC0")]
		public static IntPtr AllocateMessage(int cbAllocateBuffer)
		{
			return 0;
		}

		// Token: 0x0600035E RID: 862 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600035E")]
		[Address(RVA = "0x93DB10", Offset = "0x93C110", VA = "0x18093DB10")]
		public static void InitRelayNetworkAccess()
		{
		}

		// Token: 0x0600035F RID: 863 RVA: 0x00006134 File Offset: 0x00004334
		[Token(Token = "0x600035F")]
		[Address(RVA = "0x93DB60", Offset = "0x93C160", VA = "0x18093DB60")]
		public static ESteamNetworkingAvailability GetRelayNetworkStatus(out SteamRelayNetworkStatus_t pDetails)
		{
			return ESteamNetworkingAvailability.k_ESteamNetworkingAvailability_Unknown;
		}

		// Token: 0x06000360 RID: 864 RVA: 0x0000614C File Offset: 0x0000434C
		[Token(Token = "0x6000360")]
		[Address(RVA = "0x93DBC0", Offset = "0x93C1C0", VA = "0x18093DBC0")]
		public static float GetLocalPingLocation(out SteamNetworkPingLocation_t result)
		{
			return 0f;
		}

		// Token: 0x06000361 RID: 865 RVA: 0x00006164 File Offset: 0x00004364
		[Token(Token = "0x6000361")]
		[Address(RVA = "0x93DC20", Offset = "0x93C220", VA = "0x18093DC20")]
		public static int EstimatePingTimeBetweenTwoLocations(ref SteamNetworkPingLocation_t location1, ref SteamNetworkPingLocation_t location2)
		{
			return 0;
		}

		// Token: 0x06000362 RID: 866 RVA: 0x0000617C File Offset: 0x0000437C
		[Token(Token = "0x6000362")]
		[Address(RVA = "0x93DC80", Offset = "0x93C280", VA = "0x18093DC80")]
		public static int EstimatePingTimeFromLocalHost(ref SteamNetworkPingLocation_t remoteLocation)
		{
			return 0;
		}

		// Token: 0x06000363 RID: 867 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000363")]
		[Address(RVA = "0x93DCE0", Offset = "0x93C2E0", VA = "0x18093DCE0")]
		public static void ConvertPingLocationToString(ref SteamNetworkPingLocation_t location, out string pszBuf, int cchBufSize)
		{
		}

		// Token: 0x06000364 RID: 868 RVA: 0x00006194 File Offset: 0x00004394
		[Token(Token = "0x6000364")]
		[Address(RVA = "0x93DE30", Offset = "0x93C430", VA = "0x18093DE30")]
		public static bool ParsePingLocationString(string pszString, out SteamNetworkPingLocation_t result)
		{
			return default(bool);
		}

		// Token: 0x06000365 RID: 869 RVA: 0x000061AC File Offset: 0x000043AC
		[Token(Token = "0x6000365")]
		[Address(RVA = "0x93DF50", Offset = "0x93C550", VA = "0x18093DF50")]
		public static bool CheckPingDataUpToDate(float flMaxAgeSeconds)
		{
			return default(bool);
		}

		// Token: 0x06000366 RID: 870 RVA: 0x000061C4 File Offset: 0x000043C4
		[Token(Token = "0x6000366")]
		[Address(RVA = "0x93DFB0", Offset = "0x93C5B0", VA = "0x18093DFB0")]
		public static int GetPingToDataCenter(SteamNetworkingPOPID popID, out SteamNetworkingPOPID pViaRelayPoP)
		{
			return 0;
		}

		// Token: 0x06000367 RID: 871 RVA: 0x000061DC File Offset: 0x000043DC
		[Token(Token = "0x6000367")]
		[Address(RVA = "0x93E010", Offset = "0x93C610", VA = "0x18093E010")]
		public static int GetDirectPingToPOP(SteamNetworkingPOPID popID)
		{
			return 0;
		}

		// Token: 0x06000368 RID: 872 RVA: 0x000061F4 File Offset: 0x000043F4
		[Token(Token = "0x6000368")]
		[Address(RVA = "0x93E060", Offset = "0x93C660", VA = "0x18093E060")]
		public static int GetPOPCount()
		{
			return 0;
		}

		// Token: 0x06000369 RID: 873 RVA: 0x0000620C File Offset: 0x0000440C
		[Token(Token = "0x6000369")]
		[Address(RVA = "0x93E0B0", Offset = "0x93C6B0", VA = "0x18093E0B0")]
		public static int GetPOPList(out SteamNetworkingPOPID list, int nListSz)
		{
			return 0;
		}

		// Token: 0x0600036A RID: 874 RVA: 0x00006224 File Offset: 0x00004424
		[Token(Token = "0x600036A")]
		[Address(RVA = "0x93E110", Offset = "0x93C710", VA = "0x18093E110")]
		public static SteamNetworkingMicroseconds GetLocalTimestamp()
		{
			return default(SteamNetworkingMicroseconds);
		}

		// Token: 0x0600036B RID: 875 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600036B")]
		[Address(RVA = "0x93E160", Offset = "0x93C760", VA = "0x18093E160")]
		public static void SetDebugOutputFunction(ESteamNetworkingSocketsDebugOutputType eDetailLevel, FSteamNetworkingSocketsDebugOutput pfnFunc)
		{
		}

		// Token: 0x0600036C RID: 876 RVA: 0x0000623C File Offset: 0x0000443C
		[Token(Token = "0x600036C")]
		[Address(RVA = "0x93E1C0", Offset = "0x93C7C0", VA = "0x18093E1C0")]
		public static bool IsFakeIPv4(uint nIPv4)
		{
			return default(bool);
		}

		// Token: 0x0600036D RID: 877 RVA: 0x00006254 File Offset: 0x00004454
		[Token(Token = "0x600036D")]
		[Address(RVA = "0x93E210", Offset = "0x93C810", VA = "0x18093E210")]
		public static ESteamNetworkingFakeIPType GetIPv4FakeIPType(uint nIPv4)
		{
			return ESteamNetworkingFakeIPType.k_ESteamNetworkingFakeIPType_Invalid;
		}

		// Token: 0x0600036E RID: 878 RVA: 0x0000626C File Offset: 0x0000446C
		[Token(Token = "0x600036E")]
		[Address(RVA = "0x93E260", Offset = "0x93C860", VA = "0x18093E260")]
		public static EResult GetRealIdentityForFakeIP(ref SteamNetworkingIPAddr fakeIP, out SteamNetworkingIdentity pOutRealIdentity)
		{
			return EResult.k_EResultNone;
		}

		// Token: 0x0600036F RID: 879 RVA: 0x00006284 File Offset: 0x00004484
		[Token(Token = "0x600036F")]
		[Address(RVA = "0x93E2C0", Offset = "0x93C8C0", VA = "0x18093E2C0")]
		public static bool SetConfigValue(ESteamNetworkingConfigValue eValue, ESteamNetworkingConfigScope eScopeType, IntPtr scopeObj, ESteamNetworkingConfigDataType eDataType, IntPtr pArg)
		{
			return default(bool);
		}

		// Token: 0x06000370 RID: 880 RVA: 0x0000629C File Offset: 0x0000449C
		[Token(Token = "0x6000370")]
		[Address(RVA = "0x93E350", Offset = "0x93C950", VA = "0x18093E350")]
		public static ESteamNetworkingGetConfigValueResult GetConfigValue(ESteamNetworkingConfigValue eValue, ESteamNetworkingConfigScope eScopeType, IntPtr scopeObj, out ESteamNetworkingConfigDataType pOutDataType, IntPtr pResult, ref ulong cbResult)
		{
			return (ESteamNetworkingGetConfigValueResult)0;
		}

		// Token: 0x06000371 RID: 881 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000371")]
		[Address(RVA = "0x93E3F0", Offset = "0x93C9F0", VA = "0x18093E3F0")]
		public static string GetConfigValueInfo(ESteamNetworkingConfigValue eValue, out ESteamNetworkingConfigDataType pOutDataType, out ESteamNetworkingConfigScope pOutScope)
		{
			return null;
		}

		// Token: 0x06000372 RID: 882 RVA: 0x000062B4 File Offset: 0x000044B4
		[Token(Token = "0x6000372")]
		[Address(RVA = "0x93E470", Offset = "0x93CA70", VA = "0x18093E470")]
		public static ESteamNetworkingConfigValue IterateGenericEditableConfigValues(ESteamNetworkingConfigValue eCurrent, bool bEnumerateDevVars)
		{
			return ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_Invalid;
		}

		// Token: 0x06000373 RID: 883 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000373")]
		[Address(RVA = "0x93E4D0", Offset = "0x93CAD0", VA = "0x18093E4D0")]
		public static void SteamNetworkingIPAddr_ToString(ref SteamNetworkingIPAddr addr, out string buf, uint cbBuf, bool bWithPort)
		{
		}

		// Token: 0x06000374 RID: 884 RVA: 0x000062CC File Offset: 0x000044CC
		[Token(Token = "0x6000374")]
		[Address(RVA = "0x93E640", Offset = "0x93CC40", VA = "0x18093E640")]
		public static bool SteamNetworkingIPAddr_ParseString(out SteamNetworkingIPAddr pAddr, string pszStr)
		{
			return default(bool);
		}

		// Token: 0x06000375 RID: 885 RVA: 0x000062E4 File Offset: 0x000044E4
		[Token(Token = "0x6000375")]
		[Address(RVA = "0x93E760", Offset = "0x93CD60", VA = "0x18093E760")]
		public static ESteamNetworkingFakeIPType SteamNetworkingIPAddr_GetFakeIPType(ref SteamNetworkingIPAddr addr)
		{
			return ESteamNetworkingFakeIPType.k_ESteamNetworkingFakeIPType_Invalid;
		}

		// Token: 0x06000376 RID: 886 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000376")]
		[Address(RVA = "0x93E7C0", Offset = "0x93CDC0", VA = "0x18093E7C0")]
		public static void SteamNetworkingIdentity_ToString(ref SteamNetworkingIdentity identity, out string buf, uint cbBuf)
		{
		}

		// Token: 0x06000377 RID: 887 RVA: 0x000062FC File Offset: 0x000044FC
		[Token(Token = "0x6000377")]
		[Address(RVA = "0x93E910", Offset = "0x93CF10", VA = "0x18093E910")]
		public static bool SteamNetworkingIdentity_ParseString(out SteamNetworkingIdentity pIdentity, string pszStr)
		{
			return default(bool);
		}
	}
}
