using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	public static class SteamAppList
	{
		// Token: 0x06000003 RID: 3 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x90E5C0", Offset = "0x90CBC0", VA = "0x18090E5C0")]
		public static uint GetNumInstalledApps()
		{
			return 0U;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002080 File Offset: 0x00000280
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x90E670", Offset = "0x90CC70", VA = "0x18090E670")]
		public static uint GetInstalledApps(AppId_t[] pvecAppID, uint unMaxAppIDs)
		{
			return 0U;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002098 File Offset: 0x00000298
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x90E750", Offset = "0x90CD50", VA = "0x18090E750")]
		public static int GetAppName(AppId_t nAppID, out string pchName, int cchNameMax)
		{
			return 0;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000020B0 File Offset: 0x000002B0
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x90E920", Offset = "0x90CF20", VA = "0x18090E920")]
		public static int GetAppInstallDir(AppId_t nAppID, out string pchDirectory, int cchNameMax)
		{
			return 0;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000020C8 File Offset: 0x000002C8
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x90EAF0", Offset = "0x90D0F0", VA = "0x18090EAF0")]
		public static int GetAppBuildId(AppId_t nAppID)
		{
			return 0;
		}
	}
}
