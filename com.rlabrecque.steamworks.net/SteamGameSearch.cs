using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000018 RID: 24
	[Token(Token = "0x2000018")]
	public static class SteamGameSearch
	{
		// Token: 0x060002CF RID: 719 RVA: 0x000054EC File Offset: 0x000036EC
		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x9368B0", Offset = "0x934EB0", VA = "0x1809368B0")]
		public static EGameSearchErrorCode_t AddGameSearchParams(string pchKeyToFind, string pchValuesToFind)
		{
			return (EGameSearchErrorCode_t)0;
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x00005504 File Offset: 0x00003704
		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x936B70", Offset = "0x935170", VA = "0x180936B70")]
		public static EGameSearchErrorCode_t SearchForGameWithLobby(CSteamID steamIDLobby, int nPlayerMin, int nPlayerMax)
		{
			return (EGameSearchErrorCode_t)0;
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x0000551C File Offset: 0x0000371C
		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x936C50", Offset = "0x935250", VA = "0x180936C50")]
		public static EGameSearchErrorCode_t SearchForGameSolo(int nPlayerMin, int nPlayerMax)
		{
			return (EGameSearchErrorCode_t)0;
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x00005534 File Offset: 0x00003734
		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x936D20", Offset = "0x935320", VA = "0x180936D20")]
		public static EGameSearchErrorCode_t AcceptGame()
		{
			return (EGameSearchErrorCode_t)0;
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x0000554C File Offset: 0x0000374C
		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x936DD0", Offset = "0x9353D0", VA = "0x180936DD0")]
		public static EGameSearchErrorCode_t DeclineGame()
		{
			return (EGameSearchErrorCode_t)0;
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x00005564 File Offset: 0x00003764
		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x936E80", Offset = "0x935480", VA = "0x180936E80")]
		public static EGameSearchErrorCode_t RetrieveConnectionDetails(CSteamID steamIDHost, out string pchConnectionDetails, int cubConnectionDetails)
		{
			return (EGameSearchErrorCode_t)0;
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x0000557C File Offset: 0x0000377C
		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x937050", Offset = "0x935650", VA = "0x180937050")]
		public static EGameSearchErrorCode_t EndGameSearch()
		{
			return (EGameSearchErrorCode_t)0;
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x00005594 File Offset: 0x00003794
		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x937100", Offset = "0x935700", VA = "0x180937100")]
		public static EGameSearchErrorCode_t SetGameHostParams(string pchKey, string pchValue)
		{
			return (EGameSearchErrorCode_t)0;
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x000055AC File Offset: 0x000037AC
		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x9373C0", Offset = "0x9359C0", VA = "0x1809373C0")]
		public static EGameSearchErrorCode_t SetConnectionDetails(string pchConnectionDetails, int cubConnectionDetails)
		{
			return (EGameSearchErrorCode_t)0;
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x000055C4 File Offset: 0x000037C4
		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x9375A0", Offset = "0x935BA0", VA = "0x1809375A0")]
		public static EGameSearchErrorCode_t RequestPlayersForGame(int nPlayerMin, int nPlayerMax, int nMaxTeamSize)
		{
			return (EGameSearchErrorCode_t)0;
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x000055DC File Offset: 0x000037DC
		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x937680", Offset = "0x935C80", VA = "0x180937680")]
		public static EGameSearchErrorCode_t HostConfirmGameStart(ulong ullUniqueGameID)
		{
			return (EGameSearchErrorCode_t)0;
		}

		// Token: 0x060002DA RID: 730 RVA: 0x000055F4 File Offset: 0x000037F4
		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x937740", Offset = "0x935D40", VA = "0x180937740")]
		public static EGameSearchErrorCode_t CancelRequestPlayersForGame()
		{
			return (EGameSearchErrorCode_t)0;
		}

		// Token: 0x060002DB RID: 731 RVA: 0x0000560C File Offset: 0x0000380C
		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x9377F0", Offset = "0x935DF0", VA = "0x1809377F0")]
		public static EGameSearchErrorCode_t SubmitPlayerResult(ulong ullUniqueGameID, CSteamID steamIDPlayer, EPlayerResult_t EPlayerResult)
		{
			return (EGameSearchErrorCode_t)0;
		}

		// Token: 0x060002DC RID: 732 RVA: 0x00005624 File Offset: 0x00003824
		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x9378D0", Offset = "0x935ED0", VA = "0x1809378D0")]
		public static EGameSearchErrorCode_t EndGame(ulong ullUniqueGameID)
		{
			return (EGameSearchErrorCode_t)0;
		}
	}
}
