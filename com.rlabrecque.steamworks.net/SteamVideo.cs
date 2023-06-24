using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000028 RID: 40
	[Token(Token = "0x2000028")]
	public static class SteamVideo
	{
		// Token: 0x06000490 RID: 1168 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000490")]
		[Address(RVA = "0x951020", Offset = "0x94F620", VA = "0x180951020")]
		public static void GetVideoURL(AppId_t unVideoAppID)
		{
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x00007AFC File Offset: 0x00005CFC
		[Token(Token = "0x6000491")]
		[Address(RVA = "0x9510E0", Offset = "0x94F6E0", VA = "0x1809510E0")]
		public static bool IsBroadcasting(out int pnNumViewers)
		{
			return default(bool);
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000492")]
		[Address(RVA = "0x9511B0", Offset = "0x94F7B0", VA = "0x1809511B0")]
		public static void GetOPFSettings(AppId_t unVideoAppID)
		{
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x00007B14 File Offset: 0x00005D14
		[Token(Token = "0x6000493")]
		[Address(RVA = "0x951270", Offset = "0x94F870", VA = "0x180951270")]
		public static bool GetOPFStringForApp(AppId_t unVideoAppID, out string pchBuffer, ref int pnBufferSize)
		{
			return default(bool);
		}
	}
}
