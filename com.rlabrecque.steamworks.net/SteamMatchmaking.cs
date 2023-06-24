using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000016 RID: 22
	[Token(Token = "0x2000016")]
	public static class SteamMatchmaking
	{
		// Token: 0x06000298 RID: 664 RVA: 0x00005174 File Offset: 0x00003374
		[Token(Token = "0x6000298")]
		[Address(RVA = "0x932670", Offset = "0x930C70", VA = "0x180932670")]
		public static int GetFavoriteGameCount()
		{
			return 0;
		}

		// Token: 0x06000299 RID: 665 RVA: 0x0000518C File Offset: 0x0000338C
		[Token(Token = "0x6000299")]
		[Address(RVA = "0x932720", Offset = "0x930D20", VA = "0x180932720")]
		public static bool GetFavoriteGame(int iGame, out AppId_t pnAppID, out uint pnIP, out ushort pnConnPort, out ushort pnQueryPort, out uint punFlags, out uint pRTime32LastPlayedOnServer)
		{
			return default(bool);
		}

		// Token: 0x0600029A RID: 666 RVA: 0x000051A4 File Offset: 0x000033A4
		[Token(Token = "0x600029A")]
		[Address(RVA = "0x932840", Offset = "0x930E40", VA = "0x180932840")]
		public static int AddFavoriteGame(AppId_t nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags, uint rTime32LastPlayedOnServer)
		{
			return 0;
		}

		// Token: 0x0600029B RID: 667 RVA: 0x000051BC File Offset: 0x000033BC
		[Token(Token = "0x600029B")]
		[Address(RVA = "0x932950", Offset = "0x930F50", VA = "0x180932950")]
		public static bool RemoveFavoriteGame(AppId_t nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags)
		{
			return default(bool);
		}

		// Token: 0x0600029C RID: 668 RVA: 0x000051D4 File Offset: 0x000033D4
		[Token(Token = "0x600029C")]
		[Address(RVA = "0x932A50", Offset = "0x931050", VA = "0x180932A50")]
		public static SteamAPICall_t RequestLobbyList()
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x0600029D RID: 669 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600029D")]
		[Address(RVA = "0x932B40", Offset = "0x931140", VA = "0x180932B40")]
		public static void AddRequestLobbyListStringFilter(string pchKeyToMatch, string pchValueToMatch, ELobbyComparison eComparisonType)
		{
		}

		// Token: 0x0600029E RID: 670 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600029E")]
		[Address(RVA = "0x932DF0", Offset = "0x9313F0", VA = "0x180932DF0")]
		public static void AddRequestLobbyListNumericalFilter(string pchKeyToMatch, int nValueToMatch, ELobbyComparison eComparisonType)
		{
		}

		// Token: 0x0600029F RID: 671 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600029F")]
		[Address(RVA = "0x932FD0", Offset = "0x9315D0", VA = "0x180932FD0")]
		public static void AddRequestLobbyListNearValueFilter(string pchKeyToMatch, int nValueToBeCloseTo)
		{
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x9331B0", Offset = "0x9317B0", VA = "0x1809331B0")]
		public static void AddRequestLobbyListFilterSlotsAvailable(int nSlotsAvailable)
		{
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x933270", Offset = "0x931870", VA = "0x180933270")]
		public static void AddRequestLobbyListDistanceFilter(ELobbyDistanceFilter eLobbyDistanceFilter)
		{
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x933330", Offset = "0x931930", VA = "0x180933330")]
		public static void AddRequestLobbyListResultCountFilter(int cMaxResults)
		{
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x9333F0", Offset = "0x9319F0", VA = "0x1809333F0")]
		public static void AddRequestLobbyListCompatibleMembersFilter(CSteamID steamIDLobby)
		{
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x000051EC File Offset: 0x000033EC
		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x9334B0", Offset = "0x931AB0", VA = "0x1809334B0")]
		public static CSteamID GetLobbyByIndex(int iLobby)
		{
			return default(CSteamID);
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00005204 File Offset: 0x00003404
		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x9335A0", Offset = "0x931BA0", VA = "0x1809335A0")]
		public static SteamAPICall_t CreateLobby(ELobbyType eLobbyType, int cMaxMembers)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x0000521C File Offset: 0x0000341C
		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x9336A0", Offset = "0x931CA0", VA = "0x1809336A0")]
		public static SteamAPICall_t JoinLobby(CSteamID steamIDLobby)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x933790", Offset = "0x931D90", VA = "0x180933790")]
		public static void LeaveLobby(CSteamID steamIDLobby)
		{
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00005234 File Offset: 0x00003434
		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x933850", Offset = "0x931E50", VA = "0x180933850")]
		public static bool InviteUserToLobby(CSteamID steamIDLobby, CSteamID steamIDInvitee)
		{
			return default(bool);
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x0000524C File Offset: 0x0000344C
		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x933920", Offset = "0x931F20", VA = "0x180933920")]
		public static int GetNumLobbyMembers(CSteamID steamIDLobby)
		{
			return 0;
		}

		// Token: 0x060002AA RID: 682 RVA: 0x00005264 File Offset: 0x00003464
		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x9339E0", Offset = "0x931FE0", VA = "0x1809339E0")]
		public static CSteamID GetLobbyMemberByIndex(CSteamID steamIDLobby, int iMember)
		{
			return default(CSteamID);
		}

		// Token: 0x060002AB RID: 683 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x933AE0", Offset = "0x9320E0", VA = "0x180933AE0")]
		public static string GetLobbyData(CSteamID steamIDLobby, string pchKey)
		{
			return null;
		}

		// Token: 0x060002AC RID: 684 RVA: 0x0000527C File Offset: 0x0000347C
		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x933CE0", Offset = "0x9322E0", VA = "0x180933CE0")]
		public static bool SetLobbyData(CSteamID steamIDLobby, string pchKey, string pchValue)
		{
			return default(bool);
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00005294 File Offset: 0x00003494
		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x933FB0", Offset = "0x9325B0", VA = "0x180933FB0")]
		public static int GetLobbyDataCount(CSteamID steamIDLobby)
		{
			return 0;
		}

		// Token: 0x060002AE RID: 686 RVA: 0x000052AC File Offset: 0x000034AC
		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x934070", Offset = "0x932670", VA = "0x180934070")]
		public static bool GetLobbyDataByIndex(CSteamID steamIDLobby, int iLobbyData, out string pchKey, int cchKeyBufferSize, out string pchValue, int cchValueBufferSize)
		{
			return default(bool);
		}

		// Token: 0x060002AF RID: 687 RVA: 0x000052C4 File Offset: 0x000034C4
		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x934330", Offset = "0x932930", VA = "0x180934330")]
		public static bool DeleteLobbyData(CSteamID steamIDLobby, string pchKey)
		{
			return default(bool);
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x934520", Offset = "0x932B20", VA = "0x180934520")]
		public static string GetLobbyMemberData(CSteamID steamIDLobby, CSteamID steamIDUser, string pchKey)
		{
			return null;
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x934730", Offset = "0x932D30", VA = "0x180934730")]
		public static void SetLobbyMemberData(CSteamID steamIDLobby, string pchKey, string pchValue)
		{
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x000052DC File Offset: 0x000034DC
		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x9349E0", Offset = "0x932FE0", VA = "0x1809349E0")]
		public static bool SendLobbyChatMsg(CSteamID steamIDLobby, byte[] pvMsgBody, int cubMsgBody)
		{
			return default(bool);
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x000052F4 File Offset: 0x000034F4
		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x934AD0", Offset = "0x9330D0", VA = "0x180934AD0")]
		public static int GetLobbyChatEntry(CSteamID steamIDLobby, int iChatID, out CSteamID pSteamIDUser, byte[] pvData, int cubData, out EChatEntryType peChatEntryType)
		{
			return 0;
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x0000530C File Offset: 0x0000350C
		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x934BF0", Offset = "0x9331F0", VA = "0x180934BF0")]
		public static bool RequestLobbyData(CSteamID steamIDLobby)
		{
			return default(bool);
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x934CB0", Offset = "0x9332B0", VA = "0x180934CB0")]
		public static void SetLobbyGameServer(CSteamID steamIDLobby, uint unGameServerIP, ushort unGameServerPort, CSteamID steamIDGameServer)
		{
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00005324 File Offset: 0x00003524
		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x934DB0", Offset = "0x9333B0", VA = "0x180934DB0")]
		public static bool GetLobbyGameServer(CSteamID steamIDLobby, out uint punGameServerIP, out ushort punGameServerPort, out CSteamID psteamIDGameServer)
		{
			return default(bool);
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x0000533C File Offset: 0x0000353C
		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x934EB0", Offset = "0x9334B0", VA = "0x180934EB0")]
		public static bool SetLobbyMemberLimit(CSteamID steamIDLobby, int cMaxMembers)
		{
			return default(bool);
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x00005354 File Offset: 0x00003554
		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x934F80", Offset = "0x933580", VA = "0x180934F80")]
		public static int GetLobbyMemberLimit(CSteamID steamIDLobby)
		{
			return 0;
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x0000536C File Offset: 0x0000356C
		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x935040", Offset = "0x933640", VA = "0x180935040")]
		public static bool SetLobbyType(CSteamID steamIDLobby, ELobbyType eLobbyType)
		{
			return default(bool);
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00005384 File Offset: 0x00003584
		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x935110", Offset = "0x933710", VA = "0x180935110")]
		public static bool SetLobbyJoinable(CSteamID steamIDLobby, bool bLobbyJoinable)
		{
			return default(bool);
		}

		// Token: 0x060002BB RID: 699 RVA: 0x0000539C File Offset: 0x0000359C
		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x9351E0", Offset = "0x9337E0", VA = "0x1809351E0")]
		public static CSteamID GetLobbyOwner(CSteamID steamIDLobby)
		{
			return default(CSteamID);
		}

		// Token: 0x060002BC RID: 700 RVA: 0x000053B4 File Offset: 0x000035B4
		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x9352D0", Offset = "0x9338D0", VA = "0x1809352D0")]
		public static bool SetLobbyOwner(CSteamID steamIDLobby, CSteamID steamIDNewOwner)
		{
			return default(bool);
		}

		// Token: 0x060002BD RID: 701 RVA: 0x000053CC File Offset: 0x000035CC
		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x9353A0", Offset = "0x9339A0", VA = "0x1809353A0")]
		public static bool SetLinkedLobby(CSteamID steamIDLobby, CSteamID steamIDLobbyDependent)
		{
			return default(bool);
		}
	}
}
