using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001A8 RID: 424
	[Token(Token = "0x20001A8")]
	public static class SteamEncryptedAppTicket
	{
		// Token: 0x06000953 RID: 2387 RVA: 0x00007D84 File Offset: 0x00005F84
		[Token(Token = "0x6000953")]
		[Address(RVA = "0x955D20", Offset = "0x954320", VA = "0x180955D20")]
		public static bool BDecryptTicket(byte[] rgubTicketEncrypted, uint cubTicketEncrypted, byte[] rgubTicketDecrypted, ref uint pcubTicketDecrypted, byte[] rgubKey, int cubKey)
		{
			return default(bool);
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x00007D9C File Offset: 0x00005F9C
		[Token(Token = "0x6000954")]
		[Address(RVA = "0x955E10", Offset = "0x954410", VA = "0x180955E10")]
		public static bool BIsTicketForApp(byte[] rgubTicketDecrypted, uint cubTicketDecrypted, AppId_t nAppID)
		{
			return default(bool);
		}

		// Token: 0x06000955 RID: 2389 RVA: 0x00007DB4 File Offset: 0x00005FB4
		[Token(Token = "0x6000955")]
		[Address(RVA = "0x955EB0", Offset = "0x9544B0", VA = "0x180955EB0")]
		public static uint GetTicketIssueTime(byte[] rgubTicketDecrypted, uint cubTicketDecrypted)
		{
			return 0U;
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000956")]
		[Address(RVA = "0x955F40", Offset = "0x954540", VA = "0x180955F40")]
		public static void GetTicketSteamID(byte[] rgubTicketDecrypted, uint cubTicketDecrypted, out CSteamID psteamID)
		{
		}

		// Token: 0x06000957 RID: 2391 RVA: 0x00007DCC File Offset: 0x00005FCC
		[Token(Token = "0x6000957")]
		[Address(RVA = "0x955FE0", Offset = "0x9545E0", VA = "0x180955FE0")]
		public static uint GetTicketAppID(byte[] rgubTicketDecrypted, uint cubTicketDecrypted)
		{
			return 0U;
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x00007DE4 File Offset: 0x00005FE4
		[Token(Token = "0x6000958")]
		[Address(RVA = "0x956070", Offset = "0x954670", VA = "0x180956070")]
		public static bool BUserOwnsAppInTicket(byte[] rgubTicketDecrypted, uint cubTicketDecrypted, AppId_t nAppID)
		{
			return default(bool);
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x00007DFC File Offset: 0x00005FFC
		[Token(Token = "0x6000959")]
		[Address(RVA = "0x956110", Offset = "0x954710", VA = "0x180956110")]
		public static bool BUserIsVacBanned(byte[] rgubTicketDecrypted, uint cubTicketDecrypted)
		{
			return default(bool);
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x600095A")]
		[Address(RVA = "0x986CA0", Offset = "0x9852A0", VA = "0x180986CA0")]
		public static byte[] GetUserVariableData(byte[] rgubTicketDecrypted, uint cubTicketDecrypted, out uint pcubUserData)
		{
			return null;
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x00007E14 File Offset: 0x00006014
		[Token(Token = "0x600095B")]
		[Address(RVA = "0x956250", Offset = "0x954850", VA = "0x180956250")]
		public static bool BIsTicketSigned(byte[] rgubTicketDecrypted, uint cubTicketDecrypted, byte[] pubRSAKey, uint cubRSAKey)
		{
			return default(bool);
		}
	}
}
