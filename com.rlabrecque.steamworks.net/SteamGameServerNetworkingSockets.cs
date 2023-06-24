using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200000D RID: 13
	[Token(Token = "0x200000D")]
	public static class SteamGameServerNetworkingSockets
	{
		// Token: 0x06000137 RID: 311 RVA: 0x000037AC File Offset: 0x000019AC
		[Token(Token = "0x6000137")]
		[Address(RVA = "0x920940", Offset = "0x91EF40", VA = "0x180920940")]
		public static HSteamListenSocket CreateListenSocketIP(ref SteamNetworkingIPAddr localAddress, int nOptions, SteamNetworkingConfigValue_t[] pOptions)
		{
			return default(HSteamListenSocket);
		}

		// Token: 0x06000138 RID: 312 RVA: 0x000037C4 File Offset: 0x000019C4
		[Token(Token = "0x6000138")]
		[Address(RVA = "0x9209F0", Offset = "0x91EFF0", VA = "0x1809209F0")]
		public static HSteamNetConnection ConnectByIPAddress(ref SteamNetworkingIPAddr address, int nOptions, SteamNetworkingConfigValue_t[] pOptions)
		{
			return default(HSteamNetConnection);
		}

		// Token: 0x06000139 RID: 313 RVA: 0x000037DC File Offset: 0x000019DC
		[Token(Token = "0x6000139")]
		[Address(RVA = "0x920AA0", Offset = "0x91F0A0", VA = "0x180920AA0")]
		public static HSteamListenSocket CreateListenSocketP2P(int nLocalVirtualPort, int nOptions, SteamNetworkingConfigValue_t[] pOptions)
		{
			return default(HSteamListenSocket);
		}

		// Token: 0x0600013A RID: 314 RVA: 0x000037F4 File Offset: 0x000019F4
		[Token(Token = "0x600013A")]
		[Address(RVA = "0x920BC0", Offset = "0x91F1C0", VA = "0x180920BC0")]
		public static HSteamNetConnection ConnectP2P(ref SteamNetworkingIdentity identityRemote, int nRemoteVirtualPort, int nOptions, SteamNetworkingConfigValue_t[] pOptions)
		{
			return default(HSteamNetConnection);
		}

		// Token: 0x0600013B RID: 315 RVA: 0x0000380C File Offset: 0x00001A0C
		[Token(Token = "0x600013B")]
		[Address(RVA = "0x920C80", Offset = "0x91F280", VA = "0x180920C80")]
		public static EResult AcceptConnection(HSteamNetConnection hConn)
		{
			return EResult.k_EResultNone;
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00003824 File Offset: 0x00001A24
		[Token(Token = "0x600013C")]
		[Address(RVA = "0x920CD0", Offset = "0x91F2D0", VA = "0x180920CD0")]
		public static bool CloseConnection(HSteamNetConnection hPeer, int nReason, string pszDebug, bool bEnableLinger)
		{
			return default(bool);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x0000383C File Offset: 0x00001A3C
		[Token(Token = "0x600013D")]
		[Address(RVA = "0x920E10", Offset = "0x91F410", VA = "0x180920E10")]
		public static bool CloseListenSocket(HSteamListenSocket hSocket)
		{
			return default(bool);
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00003854 File Offset: 0x00001A54
		[Token(Token = "0x600013E")]
		[Address(RVA = "0x920E60", Offset = "0x91F460", VA = "0x180920E60")]
		public static bool SetConnectionUserData(HSteamNetConnection hPeer, long nUserData)
		{
			return default(bool);
		}

		// Token: 0x0600013F RID: 319 RVA: 0x0000386C File Offset: 0x00001A6C
		[Token(Token = "0x600013F")]
		[Address(RVA = "0x920EC0", Offset = "0x91F4C0", VA = "0x180920EC0")]
		public static long GetConnectionUserData(HSteamNetConnection hPeer)
		{
			return 0L;
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000140")]
		[Address(RVA = "0x920F10", Offset = "0x91F510", VA = "0x180920F10")]
		public static void SetConnectionName(HSteamNetConnection hPeer, string pszName)
		{
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00003884 File Offset: 0x00001A84
		[Token(Token = "0x6000141")]
		[Address(RVA = "0x921020", Offset = "0x91F620", VA = "0x180921020")]
		public static bool GetConnectionName(HSteamNetConnection hPeer, out string pszName, int nMaxLen)
		{
			return default(bool);
		}

		// Token: 0x06000142 RID: 322 RVA: 0x0000389C File Offset: 0x00001A9C
		[Token(Token = "0x6000142")]
		[Address(RVA = "0x921190", Offset = "0x91F790", VA = "0x180921190")]
		public static EResult SendMessageToConnection(HSteamNetConnection hConn, IntPtr pData, uint cbData, int nSendFlags, out long pOutMessageNumber)
		{
			return EResult.k_EResultNone;
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000143")]
		[Address(RVA = "0x921220", Offset = "0x91F820", VA = "0x180921220")]
		public static void SendMessages(int nMessages, SteamNetworkingMessage_t[] pMessages, long[] pOutMessageNumberOrResult)
		{
		}

		// Token: 0x06000144 RID: 324 RVA: 0x000038B4 File Offset: 0x00001AB4
		[Token(Token = "0x6000144")]
		[Address(RVA = "0x9212A0", Offset = "0x91F8A0", VA = "0x1809212A0")]
		public static EResult FlushMessagesOnConnection(HSteamNetConnection hConn)
		{
			return EResult.k_EResultNone;
		}

		// Token: 0x06000145 RID: 325 RVA: 0x000038CC File Offset: 0x00001ACC
		[Token(Token = "0x6000145")]
		[Address(RVA = "0x9212F0", Offset = "0x91F8F0", VA = "0x1809212F0")]
		public static int ReceiveMessagesOnConnection(HSteamNetConnection hConn, IntPtr[] ppOutMessages, int nMaxMessages)
		{
			return 0;
		}

		// Token: 0x06000146 RID: 326 RVA: 0x000038E4 File Offset: 0x00001AE4
		[Token(Token = "0x6000146")]
		[Address(RVA = "0x9213E0", Offset = "0x91F9E0", VA = "0x1809213E0")]
		public static bool GetConnectionInfo(HSteamNetConnection hConn, out SteamNetConnectionInfo_t pInfo)
		{
			return default(bool);
		}

		// Token: 0x06000147 RID: 327 RVA: 0x000038FC File Offset: 0x00001AFC
		[Token(Token = "0x6000147")]
		[Address(RVA = "0x921440", Offset = "0x91FA40", VA = "0x180921440")]
		public static EResult GetConnectionRealTimeStatus(HSteamNetConnection hConn, ref SteamNetConnectionRealTimeStatus_t pStatus, int nLanes, ref SteamNetConnectionRealTimeLaneStatus_t pLanes)
		{
			return EResult.k_EResultNone;
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00003914 File Offset: 0x00001B14
		[Token(Token = "0x6000148")]
		[Address(RVA = "0x9214D0", Offset = "0x91FAD0", VA = "0x1809214D0")]
		public static int GetDetailedConnectionStatus(HSteamNetConnection hConn, out string pszBuf, int cbBuf)
		{
			return 0;
		}

		// Token: 0x06000149 RID: 329 RVA: 0x0000392C File Offset: 0x00001B2C
		[Token(Token = "0x6000149")]
		[Address(RVA = "0x921640", Offset = "0x91FC40", VA = "0x180921640")]
		public static bool GetListenSocketAddress(HSteamListenSocket hSocket, out SteamNetworkingIPAddr address)
		{
			return default(bool);
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00003944 File Offset: 0x00001B44
		[Token(Token = "0x600014A")]
		[Address(RVA = "0x9216A0", Offset = "0x91FCA0", VA = "0x1809216A0")]
		public static bool CreateSocketPair(out HSteamNetConnection pOutConnection1, out HSteamNetConnection pOutConnection2, bool bUseNetworkLoopback, ref SteamNetworkingIdentity pIdentity1, ref SteamNetworkingIdentity pIdentity2)
		{
			return default(bool);
		}

		// Token: 0x0600014B RID: 331 RVA: 0x0000395C File Offset: 0x00001B5C
		[Token(Token = "0x600014B")]
		[Address(RVA = "0x921740", Offset = "0x91FD40", VA = "0x180921740")]
		public static EResult ConfigureConnectionLanes(HSteamNetConnection hConn, int nNumLanes, out int pLanePriorities, out ushort pLaneWeights)
		{
			return EResult.k_EResultNone;
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00003974 File Offset: 0x00001B74
		[Token(Token = "0x600014C")]
		[Address(RVA = "0x9217D0", Offset = "0x91FDD0", VA = "0x1809217D0")]
		public static bool GetIdentity(out SteamNetworkingIdentity pIdentity)
		{
			return default(bool);
		}

		// Token: 0x0600014D RID: 333 RVA: 0x0000398C File Offset: 0x00001B8C
		[Token(Token = "0x600014D")]
		[Address(RVA = "0x921820", Offset = "0x91FE20", VA = "0x180921820")]
		public static ESteamNetworkingAvailability InitAuthentication()
		{
			return ESteamNetworkingAvailability.k_ESteamNetworkingAvailability_Unknown;
		}

		// Token: 0x0600014E RID: 334 RVA: 0x000039A4 File Offset: 0x00001BA4
		[Token(Token = "0x600014E")]
		[Address(RVA = "0x921870", Offset = "0x91FE70", VA = "0x180921870")]
		public static ESteamNetworkingAvailability GetAuthenticationStatus(out SteamNetAuthenticationStatus_t pDetails)
		{
			return ESteamNetworkingAvailability.k_ESteamNetworkingAvailability_Unknown;
		}

		// Token: 0x0600014F RID: 335 RVA: 0x000039BC File Offset: 0x00001BBC
		[Token(Token = "0x600014F")]
		[Address(RVA = "0x9218C0", Offset = "0x91FEC0", VA = "0x1809218C0")]
		public static HSteamNetPollGroup CreatePollGroup()
		{
			return default(HSteamNetPollGroup);
		}

		// Token: 0x06000150 RID: 336 RVA: 0x000039D4 File Offset: 0x00001BD4
		[Token(Token = "0x6000150")]
		[Address(RVA = "0x921940", Offset = "0x91FF40", VA = "0x180921940")]
		public static bool DestroyPollGroup(HSteamNetPollGroup hPollGroup)
		{
			return default(bool);
		}

		// Token: 0x06000151 RID: 337 RVA: 0x000039EC File Offset: 0x00001BEC
		[Token(Token = "0x6000151")]
		[Address(RVA = "0x921990", Offset = "0x91FF90", VA = "0x180921990")]
		public static bool SetConnectionPollGroup(HSteamNetConnection hConn, HSteamNetPollGroup hPollGroup)
		{
			return default(bool);
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00003A04 File Offset: 0x00001C04
		[Token(Token = "0x6000152")]
		[Address(RVA = "0x9219F0", Offset = "0x91FFF0", VA = "0x1809219F0")]
		public static int ReceiveMessagesOnPollGroup(HSteamNetPollGroup hPollGroup, IntPtr[] ppOutMessages, int nMaxMessages)
		{
			return 0;
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00003A1C File Offset: 0x00001C1C
		[Token(Token = "0x6000153")]
		[Address(RVA = "0x921AE0", Offset = "0x9200E0", VA = "0x180921AE0")]
		public static bool ReceivedRelayAuthTicket(IntPtr pvTicket, int cbTicket, out SteamDatagramRelayAuthTicket pOutParsedTicket)
		{
			return default(bool);
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00003A34 File Offset: 0x00001C34
		[Token(Token = "0x6000154")]
		[Address(RVA = "0x921B60", Offset = "0x920160", VA = "0x180921B60")]
		public static int FindRelayAuthTicketForServer(ref SteamNetworkingIdentity identityGameServer, int nRemoteVirtualPort, out SteamDatagramRelayAuthTicket pOutParsedTicket)
		{
			return 0;
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00003A4C File Offset: 0x00001C4C
		[Token(Token = "0x6000155")]
		[Address(RVA = "0x921BE0", Offset = "0x9201E0", VA = "0x180921BE0")]
		public static HSteamNetConnection ConnectToHostedDedicatedServer(ref SteamNetworkingIdentity identityTarget, int nRemoteVirtualPort, int nOptions, SteamNetworkingConfigValue_t[] pOptions)
		{
			return default(HSteamNetConnection);
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00003A64 File Offset: 0x00001C64
		[Token(Token = "0x6000156")]
		[Address(RVA = "0x921CA0", Offset = "0x9202A0", VA = "0x180921CA0")]
		public static ushort GetHostedDedicatedServerPort()
		{
			return 0;
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00003A7C File Offset: 0x00001C7C
		[Token(Token = "0x6000157")]
		[Address(RVA = "0x921CF0", Offset = "0x9202F0", VA = "0x180921CF0")]
		public static SteamNetworkingPOPID GetHostedDedicatedServerPOPID()
		{
			return default(SteamNetworkingPOPID);
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00003A94 File Offset: 0x00001C94
		[Token(Token = "0x6000158")]
		[Address(RVA = "0x921D40", Offset = "0x920340", VA = "0x180921D40")]
		public static EResult GetHostedDedicatedServerAddress(out SteamDatagramHostedAddress pRouting)
		{
			return EResult.k_EResultNone;
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00003AAC File Offset: 0x00001CAC
		[Token(Token = "0x6000159")]
		[Address(RVA = "0x921D90", Offset = "0x920390", VA = "0x180921D90")]
		public static HSteamListenSocket CreateHostedDedicatedServerListenSocket(int nLocalVirtualPort, int nOptions, SteamNetworkingConfigValue_t[] pOptions)
		{
			return default(HSteamListenSocket);
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00003AC4 File Offset: 0x00001CC4
		[Token(Token = "0x600015A")]
		[Address(RVA = "0x921EB0", Offset = "0x9204B0", VA = "0x180921EB0")]
		public static EResult GetGameCoordinatorServerLogin(IntPtr pLoginInfo, out int pcbSignedBlob, IntPtr pBlob)
		{
			return EResult.k_EResultNone;
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00003ADC File Offset: 0x00001CDC
		[Token(Token = "0x600015B")]
		[Address(RVA = "0x921F30", Offset = "0x920530", VA = "0x180921F30")]
		public static HSteamNetConnection ConnectP2PCustomSignaling(out ISteamNetworkingConnectionSignaling pSignaling, ref SteamNetworkingIdentity pPeerIdentity, int nRemoteVirtualPort, int nOptions, SteamNetworkingConfigValue_t[] pOptions)
		{
			return default(HSteamNetConnection);
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00003AF4 File Offset: 0x00001CF4
		[Token(Token = "0x600015C")]
		[Address(RVA = "0x922000", Offset = "0x920600", VA = "0x180922000")]
		public static bool ReceivedP2PCustomSignal(IntPtr pMsg, int cbMsg, out ISteamNetworkingSignalingRecvContext pContext)
		{
			return default(bool);
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00003B0C File Offset: 0x00001D0C
		[Token(Token = "0x600015D")]
		[Address(RVA = "0x922080", Offset = "0x920680", VA = "0x180922080")]
		public static bool GetCertificateRequest(out int pcbBlob, IntPtr pBlob, out SteamNetworkingErrMsg errMsg)
		{
			return default(bool);
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00003B24 File Offset: 0x00001D24
		[Token(Token = "0x600015E")]
		[Address(RVA = "0x922100", Offset = "0x920700", VA = "0x180922100")]
		public static bool SetCertificate(IntPtr pCertificate, int cbCertificate, out SteamNetworkingErrMsg errMsg)
		{
			return default(bool);
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600015F")]
		[Address(RVA = "0x922180", Offset = "0x920780", VA = "0x180922180")]
		public static void ResetIdentity(ref SteamNetworkingIdentity pIdentity)
		{
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000160")]
		[Address(RVA = "0x9221D0", Offset = "0x9207D0", VA = "0x1809221D0")]
		public static void RunCallbacks()
		{
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00003B3C File Offset: 0x00001D3C
		[Token(Token = "0x6000161")]
		[Address(RVA = "0x922220", Offset = "0x920820", VA = "0x180922220")]
		public static bool BeginAsyncRequestFakeIP(int nNumPorts)
		{
			return default(bool);
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000162")]
		[Address(RVA = "0x922270", Offset = "0x920870", VA = "0x180922270")]
		public static void GetFakeIP(int idxFirstPort, out SteamNetworkingFakeIPResult_t pInfo)
		{
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00003B54 File Offset: 0x00001D54
		[Token(Token = "0x6000163")]
		[Address(RVA = "0x9222D0", Offset = "0x9208D0", VA = "0x1809222D0")]
		public static HSteamListenSocket CreateListenSocketP2PFakeIP(int idxFakePort, int nOptions, SteamNetworkingConfigValue_t[] pOptions)
		{
			return default(HSteamListenSocket);
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00003B6C File Offset: 0x00001D6C
		[Token(Token = "0x6000164")]
		[Address(RVA = "0x9223F0", Offset = "0x9209F0", VA = "0x1809223F0")]
		public static EResult GetRemoteFakeIPForConnection(HSteamNetConnection hConn, out SteamNetworkingIPAddr pOutAddr)
		{
			return EResult.k_EResultNone;
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00003B84 File Offset: 0x00001D84
		[Token(Token = "0x6000165")]
		[Address(RVA = "0x922450", Offset = "0x920A50", VA = "0x180922450")]
		public static IntPtr CreateFakeUDPPort(int idxFakeServerPort)
		{
			return 0;
		}
	}
}
