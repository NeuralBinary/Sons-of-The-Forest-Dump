using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200001C RID: 28
	[Token(Token = "0x200001C")]
	public static class SteamNetworking
	{
		// Token: 0x06000312 RID: 786 RVA: 0x00005A8C File Offset: 0x00003C8C
		[Token(Token = "0x6000312")]
		[Address(RVA = "0x93ADC0", Offset = "0x9393C0", VA = "0x18093ADC0")]
		public static bool SendP2PPacket(CSteamID steamIDRemote, byte[] pubData, uint cubData, EP2PSend eP2PSendType, int nChannel = 0)
		{
			return default(bool);
		}

		// Token: 0x06000313 RID: 787 RVA: 0x00005AA4 File Offset: 0x00003CA4
		[Token(Token = "0x6000313")]
		[Address(RVA = "0x93AE50", Offset = "0x939450", VA = "0x18093AE50")]
		public static bool IsP2PPacketAvailable(out uint pcubMsgSize, int nChannel = 0)
		{
			return default(bool);
		}

		// Token: 0x06000314 RID: 788 RVA: 0x00005ABC File Offset: 0x00003CBC
		[Token(Token = "0x6000314")]
		[Address(RVA = "0x93AEB0", Offset = "0x9394B0", VA = "0x18093AEB0")]
		public static bool ReadP2PPacket(byte[] pubDest, uint cubDest, out uint pcubMsgSize, out CSteamID psteamIDRemote, int nChannel = 0)
		{
			return default(bool);
		}

		// Token: 0x06000315 RID: 789 RVA: 0x00005AD4 File Offset: 0x00003CD4
		[Token(Token = "0x6000315")]
		[Address(RVA = "0x93AF40", Offset = "0x939540", VA = "0x18093AF40")]
		public static bool AcceptP2PSessionWithUser(CSteamID steamIDRemote)
		{
			return default(bool);
		}

		// Token: 0x06000316 RID: 790 RVA: 0x00005AEC File Offset: 0x00003CEC
		[Token(Token = "0x6000316")]
		[Address(RVA = "0x93AF90", Offset = "0x939590", VA = "0x18093AF90")]
		public static bool CloseP2PSessionWithUser(CSteamID steamIDRemote)
		{
			return default(bool);
		}

		// Token: 0x06000317 RID: 791 RVA: 0x00005B04 File Offset: 0x00003D04
		[Token(Token = "0x6000317")]
		[Address(RVA = "0x93AFE0", Offset = "0x9395E0", VA = "0x18093AFE0")]
		public static bool CloseP2PChannelWithUser(CSteamID steamIDRemote, int nChannel)
		{
			return default(bool);
		}

		// Token: 0x06000318 RID: 792 RVA: 0x00005B1C File Offset: 0x00003D1C
		[Token(Token = "0x6000318")]
		[Address(RVA = "0x93B040", Offset = "0x939640", VA = "0x18093B040")]
		public static bool GetP2PSessionState(CSteamID steamIDRemote, out P2PSessionState_t pConnectionState)
		{
			return default(bool);
		}

		// Token: 0x06000319 RID: 793 RVA: 0x00005B34 File Offset: 0x00003D34
		[Token(Token = "0x6000319")]
		[Address(RVA = "0x93B0A0", Offset = "0x9396A0", VA = "0x18093B0A0")]
		public static bool AllowP2PPacketRelay(bool bAllow)
		{
			return default(bool);
		}

		// Token: 0x0600031A RID: 794 RVA: 0x00005B4C File Offset: 0x00003D4C
		[Token(Token = "0x600031A")]
		[Address(RVA = "0x93B0F0", Offset = "0x9396F0", VA = "0x18093B0F0")]
		public static SNetListenSocket_t CreateListenSocket(int nVirtualP2PPort, SteamIPAddress_t nIP, ushort nPort, bool bAllowUseOfPacketRelay)
		{
			return default(SNetListenSocket_t);
		}

		// Token: 0x0600031B RID: 795 RVA: 0x00005B64 File Offset: 0x00003D64
		[Token(Token = "0x600031B")]
		[Address(RVA = "0x93B190", Offset = "0x939790", VA = "0x18093B190")]
		public static SNetSocket_t CreateP2PConnectionSocket(CSteamID steamIDTarget, int nVirtualPort, int nTimeoutSec, bool bAllowUseOfPacketRelay)
		{
			return default(SNetSocket_t);
		}

		// Token: 0x0600031C RID: 796 RVA: 0x00005B7C File Offset: 0x00003D7C
		[Token(Token = "0x600031C")]
		[Address(RVA = "0x93B220", Offset = "0x939820", VA = "0x18093B220")]
		public static SNetSocket_t CreateConnectionSocket(SteamIPAddress_t nIP, ushort nPort, int nTimeoutSec)
		{
			return default(SNetSocket_t);
		}

		// Token: 0x0600031D RID: 797 RVA: 0x00005B94 File Offset: 0x00003D94
		[Token(Token = "0x600031D")]
		[Address(RVA = "0x93B2B0", Offset = "0x9398B0", VA = "0x18093B2B0")]
		public static bool DestroySocket(SNetSocket_t hSocket, bool bNotifyRemoteEnd)
		{
			return default(bool);
		}

		// Token: 0x0600031E RID: 798 RVA: 0x00005BAC File Offset: 0x00003DAC
		[Token(Token = "0x600031E")]
		[Address(RVA = "0x93B310", Offset = "0x939910", VA = "0x18093B310")]
		public static bool DestroyListenSocket(SNetListenSocket_t hSocket, bool bNotifyRemoteEnd)
		{
			return default(bool);
		}

		// Token: 0x0600031F RID: 799 RVA: 0x00005BC4 File Offset: 0x00003DC4
		[Token(Token = "0x600031F")]
		[Address(RVA = "0x93B370", Offset = "0x939970", VA = "0x18093B370")]
		public static bool SendDataOnSocket(SNetSocket_t hSocket, byte[] pubData, uint cubData, bool bReliable)
		{
			return default(bool);
		}

		// Token: 0x06000320 RID: 800 RVA: 0x00005BDC File Offset: 0x00003DDC
		[Token(Token = "0x6000320")]
		[Address(RVA = "0x93B400", Offset = "0x939A00", VA = "0x18093B400")]
		public static bool IsDataAvailableOnSocket(SNetSocket_t hSocket, out uint pcubMsgSize)
		{
			return default(bool);
		}

		// Token: 0x06000321 RID: 801 RVA: 0x00005BF4 File Offset: 0x00003DF4
		[Token(Token = "0x6000321")]
		[Address(RVA = "0x93B460", Offset = "0x939A60", VA = "0x18093B460")]
		public static bool RetrieveDataFromSocket(SNetSocket_t hSocket, byte[] pubDest, uint cubDest, out uint pcubMsgSize)
		{
			return default(bool);
		}

		// Token: 0x06000322 RID: 802 RVA: 0x00005C0C File Offset: 0x00003E0C
		[Token(Token = "0x6000322")]
		[Address(RVA = "0x93B4F0", Offset = "0x939AF0", VA = "0x18093B4F0")]
		public static bool IsDataAvailable(SNetListenSocket_t hListenSocket, out uint pcubMsgSize, out SNetSocket_t phSocket)
		{
			return default(bool);
		}

		// Token: 0x06000323 RID: 803 RVA: 0x00005C24 File Offset: 0x00003E24
		[Token(Token = "0x6000323")]
		[Address(RVA = "0x93B570", Offset = "0x939B70", VA = "0x18093B570")]
		public static bool RetrieveData(SNetListenSocket_t hListenSocket, byte[] pubDest, uint cubDest, out uint pcubMsgSize, out SNetSocket_t phSocket)
		{
			return default(bool);
		}

		// Token: 0x06000324 RID: 804 RVA: 0x00005C3C File Offset: 0x00003E3C
		[Token(Token = "0x6000324")]
		[Address(RVA = "0x93B600", Offset = "0x939C00", VA = "0x18093B600")]
		public static bool GetSocketInfo(SNetSocket_t hSocket, out CSteamID pSteamIDRemote, out int peSocketStatus, out SteamIPAddress_t punIPRemote, out ushort punPortRemote)
		{
			return default(bool);
		}

		// Token: 0x06000325 RID: 805 RVA: 0x00005C54 File Offset: 0x00003E54
		[Token(Token = "0x6000325")]
		[Address(RVA = "0x93B690", Offset = "0x939C90", VA = "0x18093B690")]
		public static bool GetListenSocketInfo(SNetListenSocket_t hListenSocket, out SteamIPAddress_t pnIP, out ushort pnPort)
		{
			return default(bool);
		}

		// Token: 0x06000326 RID: 806 RVA: 0x00005C6C File Offset: 0x00003E6C
		[Token(Token = "0x6000326")]
		[Address(RVA = "0x93B710", Offset = "0x939D10", VA = "0x18093B710")]
		public static ESNetSocketConnectionType GetSocketConnectionType(SNetSocket_t hSocket)
		{
			return ESNetSocketConnectionType.k_ESNetSocketConnectionTypeNotConnected;
		}

		// Token: 0x06000327 RID: 807 RVA: 0x00005C84 File Offset: 0x00003E84
		[Token(Token = "0x6000327")]
		[Address(RVA = "0x93B760", Offset = "0x939D60", VA = "0x18093B760")]
		public static int GetMaxPacketSize(SNetSocket_t hSocket)
		{
			return 0;
		}
	}
}
