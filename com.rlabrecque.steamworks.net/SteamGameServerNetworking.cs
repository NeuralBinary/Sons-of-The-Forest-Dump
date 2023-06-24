using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200000C RID: 12
	[Token(Token = "0x200000C")]
	public static class SteamGameServerNetworking
	{
		// Token: 0x06000121 RID: 289 RVA: 0x0000359C File Offset: 0x0000179C
		[Token(Token = "0x6000121")]
		[Address(RVA = "0x91FF50", Offset = "0x91E550", VA = "0x18091FF50")]
		public static bool SendP2PPacket(CSteamID steamIDRemote, byte[] pubData, uint cubData, EP2PSend eP2PSendType, int nChannel = 0)
		{
			return default(bool);
		}

		// Token: 0x06000122 RID: 290 RVA: 0x000035B4 File Offset: 0x000017B4
		[Token(Token = "0x6000122")]
		[Address(RVA = "0x91FFE0", Offset = "0x91E5E0", VA = "0x18091FFE0")]
		public static bool IsP2PPacketAvailable(out uint pcubMsgSize, int nChannel = 0)
		{
			return default(bool);
		}

		// Token: 0x06000123 RID: 291 RVA: 0x000035CC File Offset: 0x000017CC
		[Token(Token = "0x6000123")]
		[Address(RVA = "0x920040", Offset = "0x91E640", VA = "0x180920040")]
		public static bool ReadP2PPacket(byte[] pubDest, uint cubDest, out uint pcubMsgSize, out CSteamID psteamIDRemote, int nChannel = 0)
		{
			return default(bool);
		}

		// Token: 0x06000124 RID: 292 RVA: 0x000035E4 File Offset: 0x000017E4
		[Token(Token = "0x6000124")]
		[Address(RVA = "0x9200D0", Offset = "0x91E6D0", VA = "0x1809200D0")]
		public static bool AcceptP2PSessionWithUser(CSteamID steamIDRemote)
		{
			return default(bool);
		}

		// Token: 0x06000125 RID: 293 RVA: 0x000035FC File Offset: 0x000017FC
		[Token(Token = "0x6000125")]
		[Address(RVA = "0x920120", Offset = "0x91E720", VA = "0x180920120")]
		public static bool CloseP2PSessionWithUser(CSteamID steamIDRemote)
		{
			return default(bool);
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00003614 File Offset: 0x00001814
		[Token(Token = "0x6000126")]
		[Address(RVA = "0x920170", Offset = "0x91E770", VA = "0x180920170")]
		public static bool CloseP2PChannelWithUser(CSteamID steamIDRemote, int nChannel)
		{
			return default(bool);
		}

		// Token: 0x06000127 RID: 295 RVA: 0x0000362C File Offset: 0x0000182C
		[Token(Token = "0x6000127")]
		[Address(RVA = "0x9201D0", Offset = "0x91E7D0", VA = "0x1809201D0")]
		public static bool GetP2PSessionState(CSteamID steamIDRemote, out P2PSessionState_t pConnectionState)
		{
			return default(bool);
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00003644 File Offset: 0x00001844
		[Token(Token = "0x6000128")]
		[Address(RVA = "0x920230", Offset = "0x91E830", VA = "0x180920230")]
		public static bool AllowP2PPacketRelay(bool bAllow)
		{
			return default(bool);
		}

		// Token: 0x06000129 RID: 297 RVA: 0x0000365C File Offset: 0x0000185C
		[Token(Token = "0x6000129")]
		[Address(RVA = "0x920280", Offset = "0x91E880", VA = "0x180920280")]
		public static SNetListenSocket_t CreateListenSocket(int nVirtualP2PPort, SteamIPAddress_t nIP, ushort nPort, bool bAllowUseOfPacketRelay)
		{
			return default(SNetListenSocket_t);
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00003674 File Offset: 0x00001874
		[Token(Token = "0x600012A")]
		[Address(RVA = "0x920320", Offset = "0x91E920", VA = "0x180920320")]
		public static SNetSocket_t CreateP2PConnectionSocket(CSteamID steamIDTarget, int nVirtualPort, int nTimeoutSec, bool bAllowUseOfPacketRelay)
		{
			return default(SNetSocket_t);
		}

		// Token: 0x0600012B RID: 299 RVA: 0x0000368C File Offset: 0x0000188C
		[Token(Token = "0x600012B")]
		[Address(RVA = "0x9203B0", Offset = "0x91E9B0", VA = "0x1809203B0")]
		public static SNetSocket_t CreateConnectionSocket(SteamIPAddress_t nIP, ushort nPort, int nTimeoutSec)
		{
			return default(SNetSocket_t);
		}

		// Token: 0x0600012C RID: 300 RVA: 0x000036A4 File Offset: 0x000018A4
		[Token(Token = "0x600012C")]
		[Address(RVA = "0x920440", Offset = "0x91EA40", VA = "0x180920440")]
		public static bool DestroySocket(SNetSocket_t hSocket, bool bNotifyRemoteEnd)
		{
			return default(bool);
		}

		// Token: 0x0600012D RID: 301 RVA: 0x000036BC File Offset: 0x000018BC
		[Token(Token = "0x600012D")]
		[Address(RVA = "0x9204A0", Offset = "0x91EAA0", VA = "0x1809204A0")]
		public static bool DestroyListenSocket(SNetListenSocket_t hSocket, bool bNotifyRemoteEnd)
		{
			return default(bool);
		}

		// Token: 0x0600012E RID: 302 RVA: 0x000036D4 File Offset: 0x000018D4
		[Token(Token = "0x600012E")]
		[Address(RVA = "0x920500", Offset = "0x91EB00", VA = "0x180920500")]
		public static bool SendDataOnSocket(SNetSocket_t hSocket, byte[] pubData, uint cubData, bool bReliable)
		{
			return default(bool);
		}

		// Token: 0x0600012F RID: 303 RVA: 0x000036EC File Offset: 0x000018EC
		[Token(Token = "0x600012F")]
		[Address(RVA = "0x920590", Offset = "0x91EB90", VA = "0x180920590")]
		public static bool IsDataAvailableOnSocket(SNetSocket_t hSocket, out uint pcubMsgSize)
		{
			return default(bool);
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00003704 File Offset: 0x00001904
		[Token(Token = "0x6000130")]
		[Address(RVA = "0x9205F0", Offset = "0x91EBF0", VA = "0x1809205F0")]
		public static bool RetrieveDataFromSocket(SNetSocket_t hSocket, byte[] pubDest, uint cubDest, out uint pcubMsgSize)
		{
			return default(bool);
		}

		// Token: 0x06000131 RID: 305 RVA: 0x0000371C File Offset: 0x0000191C
		[Token(Token = "0x6000131")]
		[Address(RVA = "0x920680", Offset = "0x91EC80", VA = "0x180920680")]
		public static bool IsDataAvailable(SNetListenSocket_t hListenSocket, out uint pcubMsgSize, out SNetSocket_t phSocket)
		{
			return default(bool);
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00003734 File Offset: 0x00001934
		[Token(Token = "0x6000132")]
		[Address(RVA = "0x920700", Offset = "0x91ED00", VA = "0x180920700")]
		public static bool RetrieveData(SNetListenSocket_t hListenSocket, byte[] pubDest, uint cubDest, out uint pcubMsgSize, out SNetSocket_t phSocket)
		{
			return default(bool);
		}

		// Token: 0x06000133 RID: 307 RVA: 0x0000374C File Offset: 0x0000194C
		[Token(Token = "0x6000133")]
		[Address(RVA = "0x920790", Offset = "0x91ED90", VA = "0x180920790")]
		public static bool GetSocketInfo(SNetSocket_t hSocket, out CSteamID pSteamIDRemote, out int peSocketStatus, out SteamIPAddress_t punIPRemote, out ushort punPortRemote)
		{
			return default(bool);
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00003764 File Offset: 0x00001964
		[Token(Token = "0x6000134")]
		[Address(RVA = "0x920820", Offset = "0x91EE20", VA = "0x180920820")]
		public static bool GetListenSocketInfo(SNetListenSocket_t hListenSocket, out SteamIPAddress_t pnIP, out ushort pnPort)
		{
			return default(bool);
		}

		// Token: 0x06000135 RID: 309 RVA: 0x0000377C File Offset: 0x0000197C
		[Token(Token = "0x6000135")]
		[Address(RVA = "0x9208A0", Offset = "0x91EEA0", VA = "0x1809208A0")]
		public static ESNetSocketConnectionType GetSocketConnectionType(SNetSocket_t hSocket)
		{
			return ESNetSocketConnectionType.k_ESNetSocketConnectionTypeNotConnected;
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00003794 File Offset: 0x00001994
		[Token(Token = "0x6000136")]
		[Address(RVA = "0x9208F0", Offset = "0x91EEF0", VA = "0x1809208F0")]
		public static int GetMaxPacketSize(SNetSocket_t hSocket)
		{
			return 0;
		}
	}
}
