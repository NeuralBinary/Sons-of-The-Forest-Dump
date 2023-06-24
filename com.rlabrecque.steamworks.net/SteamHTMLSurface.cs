using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000012 RID: 18
	[Token(Token = "0x2000012")]
	public static class SteamHTMLSurface
	{
		// Token: 0x06000205 RID: 517 RVA: 0x0000491C File Offset: 0x00002B1C
		[Token(Token = "0x6000205")]
		[Address(RVA = "0x929E60", Offset = "0x928460", VA = "0x180929E60")]
		public static bool Init()
		{
			return default(bool);
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00004934 File Offset: 0x00002B34
		[Token(Token = "0x6000206")]
		[Address(RVA = "0x929F20", Offset = "0x928520", VA = "0x180929F20")]
		public static bool Shutdown()
		{
			return default(bool);
		}

		// Token: 0x06000207 RID: 519 RVA: 0x0000494C File Offset: 0x00002B4C
		[Token(Token = "0x6000207")]
		[Address(RVA = "0x929FE0", Offset = "0x9285E0", VA = "0x180929FE0")]
		public static SteamAPICall_t CreateBrowser(string pchUserAgent, string pchUserCSS)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000208")]
		[Address(RVA = "0x92A2D0", Offset = "0x9288D0", VA = "0x18092A2D0")]
		public static void RemoveBrowser(HHTMLBrowser unBrowserHandle)
		{
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000209")]
		[Address(RVA = "0x92A390", Offset = "0x928990", VA = "0x18092A390")]
		public static void LoadURL(HHTMLBrowser unBrowserHandle, string pchURL, string pchPostData)
		{
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600020A")]
		[Address(RVA = "0x92A640", Offset = "0x928C40", VA = "0x18092A640")]
		public static void SetSize(HHTMLBrowser unBrowserHandle, uint unWidth, uint unHeight)
		{
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600020B")]
		[Address(RVA = "0x92A720", Offset = "0x928D20", VA = "0x18092A720")]
		public static void StopLoad(HHTMLBrowser unBrowserHandle)
		{
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600020C")]
		[Address(RVA = "0x92A7E0", Offset = "0x928DE0", VA = "0x18092A7E0")]
		public static void Reload(HHTMLBrowser unBrowserHandle)
		{
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600020D")]
		[Address(RVA = "0x92A8A0", Offset = "0x928EA0", VA = "0x18092A8A0")]
		public static void GoBack(HHTMLBrowser unBrowserHandle)
		{
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600020E")]
		[Address(RVA = "0x92A960", Offset = "0x928F60", VA = "0x18092A960")]
		public static void GoForward(HHTMLBrowser unBrowserHandle)
		{
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600020F")]
		[Address(RVA = "0x92AA20", Offset = "0x929020", VA = "0x18092AA20")]
		public static void AddHeader(HHTMLBrowser unBrowserHandle, string pchKey, string pchValue)
		{
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000210")]
		[Address(RVA = "0x92ACD0", Offset = "0x9292D0", VA = "0x18092ACD0")]
		public static void ExecuteJavascript(HHTMLBrowser unBrowserHandle, string pchScript)
		{
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000211")]
		[Address(RVA = "0x92AEB0", Offset = "0x9294B0", VA = "0x18092AEB0")]
		public static void MouseUp(HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton)
		{
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000212")]
		[Address(RVA = "0x92AF80", Offset = "0x929580", VA = "0x18092AF80")]
		public static void MouseDown(HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton)
		{
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000213")]
		[Address(RVA = "0x92B050", Offset = "0x929650", VA = "0x18092B050")]
		public static void MouseDoubleClick(HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton)
		{
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000214")]
		[Address(RVA = "0x92B120", Offset = "0x929720", VA = "0x18092B120")]
		public static void MouseMove(HHTMLBrowser unBrowserHandle, int x, int y)
		{
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000215")]
		[Address(RVA = "0x92B200", Offset = "0x929800", VA = "0x18092B200")]
		public static void MouseWheel(HHTMLBrowser unBrowserHandle, int nDelta)
		{
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000216")]
		[Address(RVA = "0x92B2D0", Offset = "0x9298D0", VA = "0x18092B2D0")]
		public static void KeyDown(HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, EHTMLKeyModifiers eHTMLKeyModifiers, bool bIsSystemKey = false)
		{
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000217")]
		[Address(RVA = "0x92B3D0", Offset = "0x9299D0", VA = "0x18092B3D0")]
		public static void KeyUp(HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, EHTMLKeyModifiers eHTMLKeyModifiers)
		{
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000218")]
		[Address(RVA = "0x92B4B0", Offset = "0x929AB0", VA = "0x18092B4B0")]
		public static void KeyChar(HHTMLBrowser unBrowserHandle, uint cUnicodeChar, EHTMLKeyModifiers eHTMLKeyModifiers)
		{
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000219")]
		[Address(RVA = "0x92B590", Offset = "0x929B90", VA = "0x18092B590")]
		public static void SetHorizontalScroll(HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll)
		{
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600021A")]
		[Address(RVA = "0x92B660", Offset = "0x929C60", VA = "0x18092B660")]
		public static void SetVerticalScroll(HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll)
		{
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600021B")]
		[Address(RVA = "0x92B730", Offset = "0x929D30", VA = "0x18092B730")]
		public static void SetKeyFocus(HHTMLBrowser unBrowserHandle, bool bHasKeyFocus)
		{
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600021C")]
		[Address(RVA = "0x92B800", Offset = "0x929E00", VA = "0x18092B800")]
		public static void ViewSource(HHTMLBrowser unBrowserHandle)
		{
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600021D")]
		[Address(RVA = "0x92B8C0", Offset = "0x929EC0", VA = "0x18092B8C0")]
		public static void CopyToClipboard(HHTMLBrowser unBrowserHandle)
		{
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600021E")]
		[Address(RVA = "0x92B980", Offset = "0x929F80", VA = "0x18092B980")]
		public static void PasteFromClipboard(HHTMLBrowser unBrowserHandle)
		{
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600021F")]
		[Address(RVA = "0x92BA40", Offset = "0x92A040", VA = "0x18092BA40")]
		public static void Find(HHTMLBrowser unBrowserHandle, string pchSearchStr, bool bCurrentlyInFind, bool bReverse)
		{
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000220")]
		[Address(RVA = "0x92BC30", Offset = "0x92A230", VA = "0x18092BC30")]
		public static void StopFind(HHTMLBrowser unBrowserHandle)
		{
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000221")]
		[Address(RVA = "0x92BCF0", Offset = "0x92A2F0", VA = "0x18092BCF0")]
		public static void GetLinkAtPosition(HHTMLBrowser unBrowserHandle, int x, int y)
		{
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000222")]
		[Address(RVA = "0x92BDD0", Offset = "0x92A3D0", VA = "0x18092BDD0")]
		public static void SetCookie(string pchHostname, string pchKey, string pchValue, string pchPath = "/", uint nExpires = 0U, bool bSecure = false, bool bHTTPOnly = false)
		{
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000223")]
		[Address(RVA = "0x92C0D0", Offset = "0x92A6D0", VA = "0x18092C0D0")]
		public static void SetPageScaleFactor(HHTMLBrowser unBrowserHandle, float flZoom, int nPointX, int nPointY)
		{
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000224")]
		[Address(RVA = "0x92C1C0", Offset = "0x92A7C0", VA = "0x18092C1C0")]
		public static void SetBackgroundMode(HHTMLBrowser unBrowserHandle, bool bBackgroundMode)
		{
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000225")]
		[Address(RVA = "0x92C290", Offset = "0x92A890", VA = "0x18092C290")]
		public static void SetDPIScalingFactor(HHTMLBrowser unBrowserHandle, float flDPIScaling)
		{
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000226")]
		[Address(RVA = "0x92C360", Offset = "0x92A960", VA = "0x18092C360")]
		public static void OpenDeveloperTools(HHTMLBrowser unBrowserHandle)
		{
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000227")]
		[Address(RVA = "0x92C420", Offset = "0x92AA20", VA = "0x18092C420")]
		public static void AllowStartRequest(HHTMLBrowser unBrowserHandle, bool bAllowed)
		{
		}

		// Token: 0x06000228 RID: 552 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000228")]
		[Address(RVA = "0x92C4F0", Offset = "0x92AAF0", VA = "0x18092C4F0")]
		public static void JSDialogResponse(HHTMLBrowser unBrowserHandle, bool bResult)
		{
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000229")]
		[Address(RVA = "0x92C5C0", Offset = "0x92ABC0", VA = "0x18092C5C0")]
		public static void FileLoadDialogResponse(HHTMLBrowser unBrowserHandle, IntPtr pchSelectedFiles)
		{
		}
	}
}
