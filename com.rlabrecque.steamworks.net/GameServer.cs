using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001A7 RID: 423
	[Token(Token = "0x20001A7")]
	public static class GameServer
	{
		// Token: 0x0600094B RID: 2379 RVA: 0x00007D0C File Offset: 0x00005F0C
		[Token(Token = "0x600094B")]
		[Address(RVA = "0x986650", Offset = "0x984C50", VA = "0x180986650")]
		public static bool Init(uint unIP, ushort usGamePort, ushort usQueryPort, EServerMode eServerMode, string pchVersionString)
		{
			return default(bool);
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600094C")]
		[Address(RVA = "0x986870", Offset = "0x984E70", VA = "0x180986870")]
		public static void Shutdown()
		{
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600094D")]
		[Address(RVA = "0x986B90", Offset = "0x985190", VA = "0x180986B90")]
		public static void RunCallbacks()
		{
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600094E")]
		[Address(RVA = "0x952580", Offset = "0x950B80", VA = "0x180952580")]
		public static void ReleaseCurrentThreadMemory()
		{
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x00007D24 File Offset: 0x00005F24
		[Token(Token = "0x600094F")]
		[Address(RVA = "0x9525F0", Offset = "0x950BF0", VA = "0x1809525F0")]
		public static bool BSecure()
		{
			return default(bool);
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x00007D3C File Offset: 0x00005F3C
		[Token(Token = "0x6000950")]
		[Address(RVA = "0x986BE0", Offset = "0x9851E0", VA = "0x180986BE0")]
		public static CSteamID GetSteamID()
		{
			return default(CSteamID);
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x00007D54 File Offset: 0x00005F54
		[Token(Token = "0x6000951")]
		[Address(RVA = "0x986C90", Offset = "0x985290", VA = "0x180986C90")]
		public static HSteamPipe GetHSteamPipe()
		{
			return default(HSteamPipe);
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x00007D6C File Offset: 0x00005F6C
		[Token(Token = "0x6000952")]
		[Address(RVA = "0x952740", Offset = "0x950D40", VA = "0x180952740")]
		public static HSteamUser GetHSteamUser()
		{
			return default(HSteamUser);
		}
	}
}
