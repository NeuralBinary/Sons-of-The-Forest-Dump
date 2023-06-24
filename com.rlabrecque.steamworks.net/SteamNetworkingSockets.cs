using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200001E RID: 30
	[Token(Token = "0x200001E")]
	public static class SteamNetworkingSockets
	{
		// Token: 0x0600032E RID: 814 RVA: 0x00005D2C File Offset: 0x00003F2C
		[Token(Token = "0x600032E")]
		[Address(RVA = "0x93BF20", Offset = "0x93A520", VA = "0x18093BF20")]
		public static HSteamListenSocket CreateListenSocketIP(ref SteamNetworkingIPAddr localAddress, int nOptions, SteamNetworkingConfigValue_t[] pOptions)
		{
			return default(HSteamListenSocket);
		}

		// Token: 0x0600032F RID: 815 RVA: 0x00005D44 File Offset: 0x00003F44
		[Token(Token = "0x600032F")]
		[Address(RVA = "0x93BFD0", Offset = "0x93A5D0", VA = "0x18093BFD0")]
		public static HSteamNetConnection ConnectByIPAddress(ref SteamNetworkingIPAddr address, int nOptions, SteamNetworkingConfigValue_t[] pOptions)
		{
			return default(HSteamNetConnection);
		}

		// Token: 0x06000330 RID: 816 RVA: 0x00005D5C File Offset: 0x00003F5C
		[Token(Token = "0x6000330")]
		[Address(RVA = "0x93C080", Offset = "0x93A680", VA = "0x18093C080")]
		public static HSteamListenSocket CreateListenSocketP2P(int nLocalVirtualPort, int nOptions, SteamNetworkingConfigValue_t[] pOptions)
		{
			return default(HSteamListenSocket);
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00005D74 File Offset: 0x00003F74
		[Token(Token = "0x6000331")]
		[Address(RVA = "0x93C1A0", Offset = "0x93A7A0", VA = "0x18093C1A0")]
		public static HSteamNetConnection ConnectP2P(ref SteamNetworkingIdentity identityRemote, int nRemoteVirtualPort, int nOptions, SteamNetworkingConfigValue_t[] pOptions)
		{
			return default(HSteamNetConnection);
		}

		// Token: 0x06000332 RID: 818 RVA: 0x00005D8C File Offset: 0x00003F8C
		[Token(Token = "0x6000332")]
		[Address(RVA = "0x93C260", Offset = "0x93A860", VA = "0x18093C260")]
		public static EResult AcceptConnection(HSteamNetConnection hConn)
		{
			return EResult.k_EResultNone;
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00005DA4 File Offset: 0x00003FA4
		[Token(Token = "0x6000333")]
		[Address(RVA = "0x93C2B0", Offset = "0x93A8B0", VA = "0x18093C2B0")]
		public static bool CloseConnection(HSteamNetConnection hPeer, int nReason, string pszDebug, bool bEnableLinger)
		{
			return default(bool);
		}

		// Token: 0x06000334 RID: 820 RVA: 0x00005DBC File Offset: 0x00003FBC
		[Token(Token = "0x6000334")]
		[Address(RVA = "0x93C3F0", Offset = "0x93A9F0", VA = "0x18093C3F0")]
		public static bool CloseListenSocket(HSteamListenSocket hSocket)
		{
			return default(bool);
		}

		// Token: 0x06000335 RID: 821 RVA: 0x00005DD4 File Offset: 0x00003FD4
		[Token(Token = "0x6000335")]
		[Address(RVA = "0x93C440", Offset = "0x93AA40", VA = "0x18093C440")]
		public static bool SetConnectionUserData(HSteamNetConnection hPeer, long nUserData)
		{
			return default(bool);
		}

		// Token: 0x06000336 RID: 822 RVA: 0x00005DEC File Offset: 0x00003FEC
		[Token(Token = "0x6000336")]
		[Address(RVA = "0x93C4A0", Offset = "0x93AAA0", VA = "0x18093C4A0")]
		public static long GetConnectionUserData(HSteamNetConnection hPeer)
		{
			return 0L;
		}

		// Token: 0x06000337 RID: 823 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000337")]
		[Address(RVA = "0x93C4F0", Offset = "0x93AAF0", VA = "0x18093C4F0")]
		public static void SetConnectionName(HSteamNetConnection hPeer, string pszName)
		{
		}

		// Token: 0x06000338 RID: 824 RVA: 0x00005E04 File Offset: 0x00004004
		[Token(Token = "0x6000338")]
		[Address(RVA = "0x93C600", Offset = "0x93AC00", VA = "0x18093C600")]
		public static bool GetConnectionName(HSteamNetConnection hPeer, out string pszName, int nMaxLen)
		{
			return default(bool);
		}

		// Token: 0x06000339 RID: 825 RVA: 0x00005E1C File Offset: 0x0000401C
		[Token(Token = "0x6000339")]
		[Address(RVA = "0x93C770", Offset = "0x93AD70", VA = "0x18093C770")]
		public static EResult SendMessageToConnection(HSteamNetConnection hConn, IntPtr pData, uint cbData, int nSendFlags, out long pOutMessageNumber)
		{
			return EResult.k_EResultNone;
		}

		// Token: 0x0600033A RID: 826 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600033A")]
		[Address(RVA = "0x93C800", Offset = "0x93AE00", VA = "0x18093C800")]
		public static void SendMessages(int nMessages, SteamNetworkingMessage_t[] pMessages, long[] pOutMessageNumberOrResult)
		{
		}

		// Token: 0x0600033B RID: 827 RVA: 0x00005E34 File Offset: 0x00004034
		[Token(Token = "0x600033B")]
		[Address(RVA = "0x93C880", Offset = "0x93AE80", VA = "0x18093C880")]
		public static EResult FlushMessagesOnConnection(HSteamNetConnection hConn)
		{
			return EResult.k_EResultNone;
		}

		// Token: 0x0600033C RID: 828 RVA: 0x00005E4C File Offset: 0x0000404C
		[Token(Token = "0x600033C")]
		[Address(RVA = "0x93C8D0", Offset = "0x93AED0", VA = "0x18093C8D0")]
		public static int ReceiveMessagesOnConnection(HSteamNetConnection hConn, IntPtr[] ppOutMessages, int nMaxMessages)
		{
			return 0;
		}

		// Token: 0x0600033D RID: 829 RVA: 0x00005E64 File Offset: 0x00004064
		[Token(Token = "0x600033D")]
		[Address(RVA = "0x93C9C0", Offset = "0x93AFC0", VA = "0x18093C9C0")]
		public static bool GetConnectionInfo(HSteamNetConnection hConn, out SteamNetConnectionInfo_t pInfo)
		{
			return default(bool);
		}

		// Token: 0x0600033E RID: 830 RVA: 0x00005E7C File Offset: 0x0000407C
		[Token(Token = "0x600033E")]
		[Address(RVA = "0x93CA20", Offset = "0x93B020", VA = "0x18093CA20")]
		public static EResult GetConnectionRealTimeStatus(HSteamNetConnection hConn, ref SteamNetConnectionRealTimeStatus_t pStatus, int nLanes, ref SteamNetConnectionRealTimeLaneStatus_t pLanes)
		{
			return EResult.k_EResultNone;
		}

		// Token: 0x0600033F RID: 831 RVA: 0x00005E94 File Offset: 0x00004094
		[Token(Token = "0x600033F")]
		[Address(RVA = "0x93CAB0", Offset = "0x93B0B0", VA = "0x18093CAB0")]
		public static int GetDetailedConnectionStatus(HSteamNetConnection hConn, out string pszBuf, int cbBuf)
		{
			return 0;
		}

		// Token: 0x06000340 RID: 832 RVA: 0x00005EAC File Offset: 0x000040AC
		[Token(Token = "0x6000340")]
		[Address(RVA = "0x93CC20", Offset = "0x93B220", VA = "0x18093CC20")]
		public static bool GetListenSocketAddress(HSteamListenSocket hSocket, out SteamNetworkingIPAddr address)
		{
			return default(bool);
		}

		// Token: 0x06000341 RID: 833 RVA: 0x00005EC4 File Offset: 0x000040C4
		[Token(Token = "0x6000341")]
		[Address(RVA = "0x93CC80", Offset = "0x93B280", VA = "0x18093CC80")]
		public static bool CreateSocketPair(out HSteamNetConnection pOutConnection1, out HSteamNetConnection pOutConnection2, bool bUseNetworkLoopback, ref SteamNetworkingIdentity pIdentity1, ref SteamNetworkingIdentity pIdentity2)
		{
			return default(bool);
		}

		// Token: 0x06000342 RID: 834 RVA: 0x00005EDC File Offset: 0x000040DC
		[Token(Token = "0x6000342")]
		[Address(RVA = "0x93CD20", Offset = "0x93B320", VA = "0x18093CD20")]
		public static EResult ConfigureConnectionLanes(HSteamNetConnection hConn, int nNumLanes, out int pLanePriorities, out ushort pLaneWeights)
		{
			return EResult.k_EResultNone;
		}

		// Token: 0x06000343 RID: 835 RVA: 0x00005EF4 File Offset: 0x000040F4
		[Token(Token = "0x6000343")]
		[Address(RVA = "0x93CDB0", Offset = "0x93B3B0", VA = "0x18093CDB0")]
		public static bool GetIdentity(out SteamNetworkingIdentity pIdentity)
		{
			return default(bool);
		}

		// Token: 0x06000344 RID: 836 RVA: 0x00005F0C File Offset: 0x0000410C
		[Token(Token = "0x6000344")]
		[Address(RVA = "0x93CE10", Offset = "0x93B410", VA = "0x18093CE10")]
		public static ESteamNetworkingAvailability InitAuthentication()
		{
			return ESteamNetworkingAvailability.k_ESteamNetworkingAvailability_Unknown;
		}

		// Token: 0x06000345 RID: 837 RVA: 0x00005F24 File Offset: 0x00004124
		[Token(Token = "0x6000345")]
		[Address(RVA = "0x93CE60", Offset = "0x93B460", VA = "0x18093CE60")]
		public static ESteamNetworkingAvailability GetAuthenticationStatus(out SteamNetAuthenticationStatus_t pDetails)
		{
			return ESteamNetworkingAvailability.k_ESteamNetworkingAvailability_Unknown;
		}

		// Token: 0x06000346 RID: 838 RVA: 0x00005F3C File Offset: 0x0000413C
		[Token(Token = "0x6000346")]
		[Address(RVA = "0x93CEC0", Offset = "0x93B4C0", VA = "0x18093CEC0")]
		public static HSteamNetPollGroup CreatePollGroup()
		{
			return default(HSteamNetPollGroup);
		}

		// Token: 0x06000347 RID: 839 RVA: 0x00005F54 File Offset: 0x00004154
		[Token(Token = "0x6000347")]
		[Address(RVA = "0x93CF40", Offset = "0x93B540", VA = "0x18093CF40")]
		public static bool DestroyPollGroup(HSteamNetPollGroup hPollGroup)
		{
			return default(bool);
		}

		// Token: 0x06000348 RID: 840 RVA: 0x00005F6C File Offset: 0x0000416C
		[Token(Token = "0x6000348")]
		[Address(RVA = "0x93CF90", Offset = "0x93B590", VA = "0x18093CF90")]
		public static bool SetConnectionPollGroup(HSteamNetConnection hConn, HSteamNetPollGroup hPollGroup)
		{
			return default(bool);
		}

		// Token: 0x06000349 RID: 841 RVA: 0x00005F84 File Offset: 0x00004184
		[Token(Token = "0x6000349")]
		[Address(RVA = "0x93CFF0", Offset = "0x93B5F0", VA = "0x18093CFF0")]
		public static int ReceiveMessagesOnPollGroup(HSteamNetPollGroup hPollGroup, IntPtr[] ppOutMessages, int nMaxMessages)
		{
			return 0;
		}

		// Token: 0x0600034A RID: 842 RVA: 0x00005F9C File Offset: 0x0000419C
		[Token(Token = "0x600034A")]
		[Address(RVA = "0x93D0E0", Offset = "0x93B6E0", VA = "0x18093D0E0")]
		public static bool ReceivedRelayAuthTicket(IntPtr pvTicket, int cbTicket, out SteamDatagramRelayAuthTicket pOutParsedTicket)
		{
			return default(bool);
		}

		// Token: 0x0600034B RID: 843 RVA: 0x00005FB4 File Offset: 0x000041B4
		[Token(Token = "0x600034B")]
		[Address(RVA = "0x93D160", Offset = "0x93B760", VA = "0x18093D160")]
		public static int FindRelayAuthTicketForServer(ref SteamNetworkingIdentity identityGameServer, int nRemoteVirtualPort, out SteamDatagramRelayAuthTicket pOutParsedTicket)
		{
			return 0;
		}

		// Token: 0x0600034C RID: 844 RVA: 0x00005FCC File Offset: 0x000041CC
		[Token(Token = "0x600034C")]
		[Address(RVA = "0x93D1E0", Offset = "0x93B7E0", VA = "0x18093D1E0")]
		public static HSteamNetConnection ConnectToHostedDedicatedServer(ref SteamNetworkingIdentity identityTarget, int nRemoteVirtualPort, int nOptions, SteamNetworkingConfigValue_t[] pOptions)
		{
			return default(HSteamNetConnection);
		}

		// Token: 0x0600034D RID: 845 RVA: 0x00005FE4 File Offset: 0x000041E4
		[Token(Token = "0x600034D")]
		[Address(RVA = "0x93D2A0", Offset = "0x93B8A0", VA = "0x18093D2A0")]
		public static ushort GetHostedDedicatedServerPort()
		{
			return 0;
		}

		// Token: 0x0600034E RID: 846 RVA: 0x00005FFC File Offset: 0x000041FC
		[Token(Token = "0x600034E")]
		[Address(RVA = "0x93D2F0", Offset = "0x93B8F0", VA = "0x18093D2F0")]
		public static SteamNetworkingPOPID GetHostedDedicatedServerPOPID()
		{
			return default(SteamNetworkingPOPID);
		}

		// Token: 0x0600034F RID: 847 RVA: 0x00006014 File Offset: 0x00004214
		[Token(Token = "0x600034F")]
		[Address(RVA = "0x93D340", Offset = "0x93B940", VA = "0x18093D340")]
		public static EResult GetHostedDedicatedServerAddress(out SteamDatagramHostedAddress pRouting)
		{
			return EResult.k_EResultNone;
		}

		// Token: 0x06000350 RID: 848 RVA: 0x0000602C File Offset: 0x0000422C
		[Token(Token = "0x6000350")]
		[Address(RVA = "0x93D3A0", Offset = "0x93B9A0", VA = "0x18093D3A0")]
		public static HSteamListenSocket CreateHostedDedicatedServerListenSocket(int nLocalVirtualPort, int nOptions, SteamNetworkingConfigValue_t[] pOptions)
		{
			return default(HSteamListenSocket);
		}

		// Token: 0x06000351 RID: 849 RVA: 0x00006044 File Offset: 0x00004244
		[Token(Token = "0x6000351")]
		[Address(RVA = "0x93D4C0", Offset = "0x93BAC0", VA = "0x18093D4C0")]
		public static EResult GetGameCoordinatorServerLogin(IntPtr pLoginInfo, out int pcbSignedBlob, IntPtr pBlob)
		{
			return EResult.k_EResultNone;
		}

		// Token: 0x06000352 RID: 850 RVA: 0x0000605C File Offset: 0x0000425C
		[Token(Token = "0x6000352")]
		[Address(RVA = "0x93D540", Offset = "0x93BB40", VA = "0x18093D540")]
		public static HSteamNetConnection ConnectP2PCustomSignaling(out ISteamNetworkingConnectionSignaling pSignaling, ref SteamNetworkingIdentity pPeerIdentity, int nRemoteVirtualPort, int nOptions, SteamNetworkingConfigValue_t[] pOptions)
		{
			return default(HSteamNetConnection);
		}

		// Token: 0x06000353 RID: 851 RVA: 0x00006074 File Offset: 0x00004274
		[Token(Token = "0x6000353")]
		[Address(RVA = "0x93D610", Offset = "0x93BC10", VA = "0x18093D610")]
		public static bool ReceivedP2PCustomSignal(IntPtr pMsg, int cbMsg, out ISteamNetworkingSignalingRecvContext pContext)
		{
			return default(bool);
		}

		// Token: 0x06000354 RID: 852 RVA: 0x0000608C File Offset: 0x0000428C
		[Token(Token = "0x6000354")]
		[Address(RVA = "0x93D690", Offset = "0x93BC90", VA = "0x18093D690")]
		public static bool GetCertificateRequest(out int pcbBlob, IntPtr pBlob, out SteamNetworkingErrMsg errMsg)
		{
			return default(bool);
		}

		// Token: 0x06000355 RID: 853 RVA: 0x000060A4 File Offset: 0x000042A4
		[Token(Token = "0x6000355")]
		[Address(RVA = "0x93D710", Offset = "0x93BD10", VA = "0x18093D710")]
		public static bool SetCertificate(IntPtr pCertificate, int cbCertificate, out SteamNetworkingErrMsg errMsg)
		{
			return default(bool);
		}

		// Token: 0x06000356 RID: 854 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000356")]
		[Address(RVA = "0x93D790", Offset = "0x93BD90", VA = "0x18093D790")]
		public static void ResetIdentity(ref SteamNetworkingIdentity pIdentity)
		{
		}

		// Token: 0x06000357 RID: 855 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000357")]
		[Address(RVA = "0x93D7F0", Offset = "0x93BDF0", VA = "0x18093D7F0")]
		public static void RunCallbacks()
		{
		}

		// Token: 0x06000358 RID: 856 RVA: 0x000060BC File Offset: 0x000042BC
		[Token(Token = "0x6000358")]
		[Address(RVA = "0x93D840", Offset = "0x93BE40", VA = "0x18093D840")]
		public static bool BeginAsyncRequestFakeIP(int nNumPorts)
		{
			return default(bool);
		}

		// Token: 0x06000359 RID: 857 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000359")]
		[Address(RVA = "0x93D890", Offset = "0x93BE90", VA = "0x18093D890")]
		public static void GetFakeIP(int idxFirstPort, out SteamNetworkingFakeIPResult_t pInfo)
		{
		}

		// Token: 0x0600035A RID: 858 RVA: 0x000060D4 File Offset: 0x000042D4
		[Token(Token = "0x600035A")]
		[Address(RVA = "0x93D8F0", Offset = "0x93BEF0", VA = "0x18093D8F0")]
		public static HSteamListenSocket CreateListenSocketP2PFakeIP(int idxFakePort, int nOptions, SteamNetworkingConfigValue_t[] pOptions)
		{
			return default(HSteamListenSocket);
		}

		// Token: 0x0600035B RID: 859 RVA: 0x000060EC File Offset: 0x000042EC
		[Token(Token = "0x600035B")]
		[Address(RVA = "0x93DA10", Offset = "0x93C010", VA = "0x18093DA10")]
		public static EResult GetRemoteFakeIPForConnection(HSteamNetConnection hConn, out SteamNetworkingIPAddr pOutAddr)
		{
			return EResult.k_EResultNone;
		}

		// Token: 0x0600035C RID: 860 RVA: 0x00006104 File Offset: 0x00004304
		[Token(Token = "0x600035C")]
		[Address(RVA = "0x93DA70", Offset = "0x93C070", VA = "0x18093DA70")]
		public static IntPtr CreateFakeUDPPort(int idxFakeServerPort)
		{
			return 0;
		}
	}
}
