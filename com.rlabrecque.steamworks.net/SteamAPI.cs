using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001A6 RID: 422
	[Token(Token = "0x20001A6")]
	public static class SteamAPI
	{
		// Token: 0x06000942 RID: 2370 RVA: 0x00007C94 File Offset: 0x00005E94
		[Token(Token = "0x6000942")]
		[Address(RVA = "0x986000", Offset = "0x984600", VA = "0x180986000")]
		public static bool Init()
		{
			return default(bool);
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000943")]
		[Address(RVA = "0x9860C0", Offset = "0x9846C0", VA = "0x1809860C0")]
		public static void Shutdown()
		{
		}

		// Token: 0x06000944 RID: 2372 RVA: 0x00007CAC File Offset: 0x00005EAC
		[Token(Token = "0x6000944")]
		[Address(RVA = "0x951530", Offset = "0x94FB30", VA = "0x180951530")]
		public static bool RestartAppIfNecessary(AppId_t unOwnAppID)
		{
			return default(bool);
		}

		// Token: 0x06000945 RID: 2373 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000945")]
		[Address(RVA = "0x9515B0", Offset = "0x94FBB0", VA = "0x1809515B0")]
		public static void ReleaseCurrentThreadMemory()
		{
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000946")]
		[Address(RVA = "0x986540", Offset = "0x984B40", VA = "0x180986540")]
		public static void RunCallbacks()
		{
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x00007CC4 File Offset: 0x00005EC4
		[Token(Token = "0x6000947")]
		[Address(RVA = "0x951A20", Offset = "0x950020", VA = "0x180951A20")]
		public static bool IsSteamRunning()
		{
			return default(bool);
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x00007CDC File Offset: 0x00005EDC
		[Token(Token = "0x6000948")]
		[Address(RVA = "0x986590", Offset = "0x984B90", VA = "0x180986590")]
		public static HSteamPipe GetHSteamPipe()
		{
			return default(HSteamPipe);
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x00007CF4 File Offset: 0x00005EF4
		[Token(Token = "0x6000949")]
		[Address(RVA = "0x951BF0", Offset = "0x9501F0", VA = "0x180951BF0")]
		public static HSteamUser GetHSteamUser()
		{
			return default(HSteamUser);
		}

		// Token: 0x04000A24 RID: 2596
		[Token(Token = "0x4000A24")]
		[FieldOffset(Offset = "0x0")]
		public static readonly object P2PTransportInUseLock;
	}
}
