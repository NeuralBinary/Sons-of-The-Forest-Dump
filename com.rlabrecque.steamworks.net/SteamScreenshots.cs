using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000023 RID: 35
	[Token(Token = "0x2000023")]
	public static class SteamScreenshots
	{
		// Token: 0x060003C0 RID: 960 RVA: 0x00006974 File Offset: 0x00004B74
		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x944620", Offset = "0x942C20", VA = "0x180944620")]
		public static ScreenshotHandle WriteScreenshot(byte[] pubRGB, uint cubRGB, int nWidth, int nHeight)
		{
			return default(ScreenshotHandle);
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x0000698C File Offset: 0x00004B8C
		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x944750", Offset = "0x942D50", VA = "0x180944750")]
		public static ScreenshotHandle AddScreenshotToLibrary(string pchFilename, string pchThumbnailFilename, int nWidth, int nHeight)
		{
			return default(ScreenshotHandle);
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x944A40", Offset = "0x943040", VA = "0x180944A40")]
		public static void TriggerScreenshot()
		{
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x944AF0", Offset = "0x9430F0", VA = "0x180944AF0")]
		public static void HookScreenshots(bool bHook)
		{
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x000069A4 File Offset: 0x00004BA4
		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x944BB0", Offset = "0x9431B0", VA = "0x180944BB0")]
		public static bool SetLocation(ScreenshotHandle hScreenshot, string pchLocation)
		{
			return default(bool);
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x000069BC File Offset: 0x00004BBC
		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x944DA0", Offset = "0x9433A0", VA = "0x180944DA0")]
		public static bool TagUser(ScreenshotHandle hScreenshot, CSteamID steamID)
		{
			return default(bool);
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x000069D4 File Offset: 0x00004BD4
		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x944E70", Offset = "0x943470", VA = "0x180944E70")]
		public static bool TagPublishedFile(ScreenshotHandle hScreenshot, PublishedFileId_t unPublishedFileID)
		{
			return default(bool);
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x000069EC File Offset: 0x00004BEC
		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x944F40", Offset = "0x943540", VA = "0x180944F40")]
		public static bool IsScreenshotsHooked()
		{
			return default(bool);
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x00006A04 File Offset: 0x00004C04
		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x944FF0", Offset = "0x9435F0", VA = "0x180944FF0")]
		public static ScreenshotHandle AddVRScreenshotToLibrary(EVRScreenshotType eType, string pchFilename, string pchVRFilename)
		{
			return default(ScreenshotHandle);
		}
	}
}
