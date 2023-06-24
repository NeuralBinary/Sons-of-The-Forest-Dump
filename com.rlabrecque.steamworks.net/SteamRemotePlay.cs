using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000021 RID: 33
	[Token(Token = "0x2000021")]
	public static class SteamRemotePlay
	{
		// Token: 0x0600037E RID: 894 RVA: 0x000063A4 File Offset: 0x000045A4
		[Token(Token = "0x600037E")]
		[Address(RVA = "0x93EEB0", Offset = "0x93D4B0", VA = "0x18093EEB0")]
		public static uint GetSessionCount()
		{
			return 0U;
		}

		// Token: 0x0600037F RID: 895 RVA: 0x000063BC File Offset: 0x000045BC
		[Token(Token = "0x600037F")]
		[Address(RVA = "0x93EF60", Offset = "0x93D560", VA = "0x18093EF60")]
		public static RemotePlaySessionID_t GetSessionID(int iSessionIndex)
		{
			return default(RemotePlaySessionID_t);
		}

		// Token: 0x06000380 RID: 896 RVA: 0x000063D4 File Offset: 0x000045D4
		[Token(Token = "0x6000380")]
		[Address(RVA = "0x93F020", Offset = "0x93D620", VA = "0x18093F020")]
		public static CSteamID GetSessionSteamID(RemotePlaySessionID_t unSessionID)
		{
			return default(CSteamID);
		}

		// Token: 0x06000381 RID: 897 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000381")]
		[Address(RVA = "0x93F120", Offset = "0x93D720", VA = "0x18093F120")]
		public static string GetSessionClientName(RemotePlaySessionID_t unSessionID)
		{
			return null;
		}

		// Token: 0x06000382 RID: 898 RVA: 0x000063EC File Offset: 0x000045EC
		[Token(Token = "0x6000382")]
		[Address(RVA = "0x93F1F0", Offset = "0x93D7F0", VA = "0x18093F1F0")]
		public static ESteamDeviceFormFactor GetSessionClientFormFactor(RemotePlaySessionID_t unSessionID)
		{
			return ESteamDeviceFormFactor.k_ESteamDeviceFormFactorUnknown;
		}

		// Token: 0x06000383 RID: 899 RVA: 0x00006404 File Offset: 0x00004604
		[Token(Token = "0x6000383")]
		[Address(RVA = "0x93F2B0", Offset = "0x93D8B0", VA = "0x18093F2B0")]
		public static bool BGetSessionClientResolution(RemotePlaySessionID_t unSessionID, out int pnResolutionX, out int pnResolutionY)
		{
			return default(bool);
		}

		// Token: 0x06000384 RID: 900 RVA: 0x0000641C File Offset: 0x0000461C
		[Token(Token = "0x6000384")]
		[Address(RVA = "0x93F390", Offset = "0x93D990", VA = "0x18093F390")]
		public static bool BSendRemotePlayTogetherInvite(CSteamID steamIDFriend)
		{
			return default(bool);
		}
	}
}
