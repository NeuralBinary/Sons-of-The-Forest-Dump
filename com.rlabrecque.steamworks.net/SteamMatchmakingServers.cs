using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000017 RID: 23
	[Token(Token = "0x2000017")]
	public static class SteamMatchmakingServers
	{
		// Token: 0x060002BE RID: 702 RVA: 0x000053E4 File Offset: 0x000035E4
		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x935470", Offset = "0x933A70", VA = "0x180935470")]
		public static HServerListRequest RequestInternetServerList(AppId_t iApp, MatchMakingKeyValuePair_t[] ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse)
		{
			return default(HServerListRequest);
		}

		// Token: 0x060002BF RID: 703 RVA: 0x000053FC File Offset: 0x000035FC
		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x935610", Offset = "0x933C10", VA = "0x180935610")]
		public static HServerListRequest RequestLANServerList(AppId_t iApp, ISteamMatchmakingServerListResponse pRequestServersResponse)
		{
			return default(HServerListRequest);
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x00005414 File Offset: 0x00003614
		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x935750", Offset = "0x933D50", VA = "0x180935750")]
		public static HServerListRequest RequestFriendsServerList(AppId_t iApp, MatchMakingKeyValuePair_t[] ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse)
		{
			return default(HServerListRequest);
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x0000542C File Offset: 0x0000362C
		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x9358F0", Offset = "0x933EF0", VA = "0x1809358F0")]
		public static HServerListRequest RequestFavoritesServerList(AppId_t iApp, MatchMakingKeyValuePair_t[] ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse)
		{
			return default(HServerListRequest);
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00005444 File Offset: 0x00003644
		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x935A90", Offset = "0x934090", VA = "0x180935A90")]
		public static HServerListRequest RequestHistoryServerList(AppId_t iApp, MatchMakingKeyValuePair_t[] ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse)
		{
			return default(HServerListRequest);
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x0000545C File Offset: 0x0000365C
		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x935C30", Offset = "0x934230", VA = "0x180935C30")]
		public static HServerListRequest RequestSpectatorServerList(AppId_t iApp, MatchMakingKeyValuePair_t[] ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse)
		{
			return default(HServerListRequest);
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x935DD0", Offset = "0x9343D0", VA = "0x180935DD0")]
		public static void ReleaseRequest(HServerListRequest hServerListRequest)
		{
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x935E90", Offset = "0x934490", VA = "0x180935E90")]
		public static gameserveritem_t GetServerDetails(HServerListRequest hRequest, int iServer)
		{
			return null;
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x936070", Offset = "0x934670", VA = "0x180936070")]
		public static void CancelQuery(HServerListRequest hRequest)
		{
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x936130", Offset = "0x934730", VA = "0x180936130")]
		public static void RefreshQuery(HServerListRequest hRequest)
		{
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00005474 File Offset: 0x00003674
		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x9361F0", Offset = "0x9347F0", VA = "0x1809361F0")]
		public static bool IsRefreshing(HServerListRequest hRequest)
		{
			return default(bool);
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x0000548C File Offset: 0x0000368C
		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x9362B0", Offset = "0x9348B0", VA = "0x1809362B0")]
		public static int GetServerCount(HServerListRequest hRequest)
		{
			return 0;
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x936370", Offset = "0x934970", VA = "0x180936370")]
		public static void RefreshServer(HServerListRequest hRequest, int iServer)
		{
		}

		// Token: 0x060002CB RID: 715 RVA: 0x000054A4 File Offset: 0x000036A4
		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x936440", Offset = "0x934A40", VA = "0x180936440")]
		public static HServerQuery PingServer(uint unIP, ushort usPort, ISteamMatchmakingPingResponse pRequestServersResponse)
		{
			return default(HServerQuery);
		}

		// Token: 0x060002CC RID: 716 RVA: 0x000054BC File Offset: 0x000036BC
		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x936590", Offset = "0x934B90", VA = "0x180936590")]
		public static HServerQuery PlayerDetails(uint unIP, ushort usPort, ISteamMatchmakingPlayersResponse pRequestServersResponse)
		{
			return default(HServerQuery);
		}

		// Token: 0x060002CD RID: 717 RVA: 0x000054D4 File Offset: 0x000036D4
		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x9366C0", Offset = "0x934CC0", VA = "0x1809366C0")]
		public static HServerQuery ServerRules(uint unIP, ushort usPort, ISteamMatchmakingRulesResponse pRequestServersResponse)
		{
			return default(HServerQuery);
		}

		// Token: 0x060002CE RID: 718 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x9367F0", Offset = "0x934DF0", VA = "0x1809367F0")]
		public static void CancelServerQuery(HServerQuery hServerQuery)
		{
		}
	}
}
