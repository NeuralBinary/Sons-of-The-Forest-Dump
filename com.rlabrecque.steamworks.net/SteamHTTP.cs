using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000013 RID: 19
	[Token(Token = "0x2000013")]
	public static class SteamHTTP
	{
		// Token: 0x0600022A RID: 554 RVA: 0x00004964 File Offset: 0x00002B64
		[Token(Token = "0x600022A")]
		[Address(RVA = "0x92C690", Offset = "0x92AC90", VA = "0x18092C690")]
		public static HTTPRequestHandle CreateHTTPRequest(EHTTPMethod eHTTPRequestMethod, string pchAbsoluteURL)
		{
			return default(HTTPRequestHandle);
		}

		// Token: 0x0600022B RID: 555 RVA: 0x0000497C File Offset: 0x00002B7C
		[Token(Token = "0x600022B")]
		[Address(RVA = "0x92C7D0", Offset = "0x92ADD0", VA = "0x18092C7D0")]
		public static bool SetHTTPRequestContextValue(HTTPRequestHandle hRequest, ulong ulContextValue)
		{
			return default(bool);
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00004994 File Offset: 0x00002B94
		[Token(Token = "0x600022C")]
		[Address(RVA = "0x92C830", Offset = "0x92AE30", VA = "0x18092C830")]
		public static bool SetHTTPRequestNetworkActivityTimeout(HTTPRequestHandle hRequest, uint unTimeoutSeconds)
		{
			return default(bool);
		}

		// Token: 0x0600022D RID: 557 RVA: 0x000049AC File Offset: 0x00002BAC
		[Token(Token = "0x600022D")]
		[Address(RVA = "0x92C890", Offset = "0x92AE90", VA = "0x18092C890")]
		public static bool SetHTTPRequestHeaderValue(HTTPRequestHandle hRequest, string pchHeaderName, string pchHeaderValue)
		{
			return default(bool);
		}

		// Token: 0x0600022E RID: 558 RVA: 0x000049C4 File Offset: 0x00002BC4
		[Token(Token = "0x600022E")]
		[Address(RVA = "0x92CA50", Offset = "0x92B050", VA = "0x18092CA50")]
		public static bool SetHTTPRequestGetOrPostParameter(HTTPRequestHandle hRequest, string pchParamName, string pchParamValue)
		{
			return default(bool);
		}

		// Token: 0x0600022F RID: 559 RVA: 0x000049DC File Offset: 0x00002BDC
		[Token(Token = "0x600022F")]
		[Address(RVA = "0x92CC10", Offset = "0x92B210", VA = "0x18092CC10")]
		public static bool SendHTTPRequest(HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle)
		{
			return default(bool);
		}

		// Token: 0x06000230 RID: 560 RVA: 0x000049F4 File Offset: 0x00002BF4
		[Token(Token = "0x6000230")]
		[Address(RVA = "0x92CC70", Offset = "0x92B270", VA = "0x18092CC70")]
		public static bool SendHTTPRequestAndStreamResponse(HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle)
		{
			return default(bool);
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00004A0C File Offset: 0x00002C0C
		[Token(Token = "0x6000231")]
		[Address(RVA = "0x92CCD0", Offset = "0x92B2D0", VA = "0x18092CCD0")]
		public static bool DeferHTTPRequest(HTTPRequestHandle hRequest)
		{
			return default(bool);
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00004A24 File Offset: 0x00002C24
		[Token(Token = "0x6000232")]
		[Address(RVA = "0x92CD20", Offset = "0x92B320", VA = "0x18092CD20")]
		public static bool PrioritizeHTTPRequest(HTTPRequestHandle hRequest)
		{
			return default(bool);
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00004A3C File Offset: 0x00002C3C
		[Token(Token = "0x6000233")]
		[Address(RVA = "0x92CD70", Offset = "0x92B370", VA = "0x18092CD70")]
		public static bool GetHTTPResponseHeaderSize(HTTPRequestHandle hRequest, string pchHeaderName, out uint unResponseHeaderSize)
		{
			return default(bool);
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00004A54 File Offset: 0x00002C54
		[Token(Token = "0x6000234")]
		[Address(RVA = "0x92CEA0", Offset = "0x92B4A0", VA = "0x18092CEA0")]
		public static bool GetHTTPResponseHeaderValue(HTTPRequestHandle hRequest, string pchHeaderName, byte[] pHeaderValueBuffer, uint unBufferSize)
		{
			return default(bool);
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00004A6C File Offset: 0x00002C6C
		[Token(Token = "0x6000235")]
		[Address(RVA = "0x92CFE0", Offset = "0x92B5E0", VA = "0x18092CFE0")]
		public static bool GetHTTPResponseBodySize(HTTPRequestHandle hRequest, out uint unBodySize)
		{
			return default(bool);
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00004A84 File Offset: 0x00002C84
		[Token(Token = "0x6000236")]
		[Address(RVA = "0x92D040", Offset = "0x92B640", VA = "0x18092D040")]
		public static bool GetHTTPResponseBodyData(HTTPRequestHandle hRequest, byte[] pBodyDataBuffer, uint unBufferSize)
		{
			return default(bool);
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00004A9C File Offset: 0x00002C9C
		[Token(Token = "0x6000237")]
		[Address(RVA = "0x92D0C0", Offset = "0x92B6C0", VA = "0x18092D0C0")]
		public static bool GetHTTPStreamingResponseBodyData(HTTPRequestHandle hRequest, uint cOffset, byte[] pBodyDataBuffer, uint unBufferSize)
		{
			return default(bool);
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00004AB4 File Offset: 0x00002CB4
		[Token(Token = "0x6000238")]
		[Address(RVA = "0x92D150", Offset = "0x92B750", VA = "0x18092D150")]
		public static bool ReleaseHTTPRequest(HTTPRequestHandle hRequest)
		{
			return default(bool);
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00004ACC File Offset: 0x00002CCC
		[Token(Token = "0x6000239")]
		[Address(RVA = "0x92D1A0", Offset = "0x92B7A0", VA = "0x18092D1A0")]
		public static bool GetHTTPDownloadProgressPct(HTTPRequestHandle hRequest, out float pflPercentOut)
		{
			return default(bool);
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00004AE4 File Offset: 0x00002CE4
		[Token(Token = "0x600023A")]
		[Address(RVA = "0x92D200", Offset = "0x92B800", VA = "0x18092D200")]
		public static bool SetHTTPRequestRawPostBody(HTTPRequestHandle hRequest, string pchContentType, byte[] pubBody, uint unBodyLen)
		{
			return default(bool);
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00004AFC File Offset: 0x00002CFC
		[Token(Token = "0x600023B")]
		[Address(RVA = "0x92D340", Offset = "0x92B940", VA = "0x18092D340")]
		public static HTTPCookieContainerHandle CreateCookieContainer(bool bAllowResponsesToModify)
		{
			return default(HTTPCookieContainerHandle);
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00004B14 File Offset: 0x00002D14
		[Token(Token = "0x600023C")]
		[Address(RVA = "0x92D3D0", Offset = "0x92B9D0", VA = "0x18092D3D0")]
		public static bool ReleaseCookieContainer(HTTPCookieContainerHandle hCookieContainer)
		{
			return default(bool);
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00004B2C File Offset: 0x00002D2C
		[Token(Token = "0x600023D")]
		[Address(RVA = "0x92D420", Offset = "0x92BA20", VA = "0x18092D420")]
		public static bool SetCookie(HTTPCookieContainerHandle hCookieContainer, string pchHost, string pchUrl, string pchCookie)
		{
			return default(bool);
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00004B44 File Offset: 0x00002D44
		[Token(Token = "0x600023E")]
		[Address(RVA = "0x92D670", Offset = "0x92BC70", VA = "0x18092D670")]
		public static bool SetHTTPRequestCookieContainer(HTTPRequestHandle hRequest, HTTPCookieContainerHandle hCookieContainer)
		{
			return default(bool);
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00004B5C File Offset: 0x00002D5C
		[Token(Token = "0x600023F")]
		[Address(RVA = "0x92D6D0", Offset = "0x92BCD0", VA = "0x18092D6D0")]
		public static bool SetHTTPRequestUserAgentInfo(HTTPRequestHandle hRequest, string pchUserAgentInfo)
		{
			return default(bool);
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00004B74 File Offset: 0x00002D74
		[Token(Token = "0x6000240")]
		[Address(RVA = "0x92D7F0", Offset = "0x92BDF0", VA = "0x18092D7F0")]
		public static bool SetHTTPRequestRequiresVerifiedCertificate(HTTPRequestHandle hRequest, bool bRequireVerifiedCertificate)
		{
			return default(bool);
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00004B8C File Offset: 0x00002D8C
		[Token(Token = "0x6000241")]
		[Address(RVA = "0x92D850", Offset = "0x92BE50", VA = "0x18092D850")]
		public static bool SetHTTPRequestAbsoluteTimeoutMS(HTTPRequestHandle hRequest, uint unMilliseconds)
		{
			return default(bool);
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00004BA4 File Offset: 0x00002DA4
		[Token(Token = "0x6000242")]
		[Address(RVA = "0x92D8B0", Offset = "0x92BEB0", VA = "0x18092D8B0")]
		public static bool GetHTTPRequestWasTimedOut(HTTPRequestHandle hRequest, out bool pbWasTimedOut)
		{
			return default(bool);
		}
	}
}
