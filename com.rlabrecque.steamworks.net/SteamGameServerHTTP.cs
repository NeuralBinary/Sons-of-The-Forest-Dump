using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200000A RID: 10
	[Token(Token = "0x200000A")]
	public static class SteamGameServerHTTP
	{
		// Token: 0x060000E2 RID: 226 RVA: 0x00002FE4 File Offset: 0x000011E4
		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x91CD70", Offset = "0x91B370", VA = "0x18091CD70")]
		public static HTTPRequestHandle CreateHTTPRequest(EHTTPMethod eHTTPRequestMethod, string pchAbsoluteURL)
		{
			return default(HTTPRequestHandle);
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00002FFC File Offset: 0x000011FC
		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x91CEB0", Offset = "0x91B4B0", VA = "0x18091CEB0")]
		public static bool SetHTTPRequestContextValue(HTTPRequestHandle hRequest, ulong ulContextValue)
		{
			return default(bool);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00003014 File Offset: 0x00001214
		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x91CF10", Offset = "0x91B510", VA = "0x18091CF10")]
		public static bool SetHTTPRequestNetworkActivityTimeout(HTTPRequestHandle hRequest, uint unTimeoutSeconds)
		{
			return default(bool);
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x0000302C File Offset: 0x0000122C
		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x91CF70", Offset = "0x91B570", VA = "0x18091CF70")]
		public static bool SetHTTPRequestHeaderValue(HTTPRequestHandle hRequest, string pchHeaderName, string pchHeaderValue)
		{
			return default(bool);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00003044 File Offset: 0x00001244
		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x91D130", Offset = "0x91B730", VA = "0x18091D130")]
		public static bool SetHTTPRequestGetOrPostParameter(HTTPRequestHandle hRequest, string pchParamName, string pchParamValue)
		{
			return default(bool);
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x0000305C File Offset: 0x0000125C
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x91D2F0", Offset = "0x91B8F0", VA = "0x18091D2F0")]
		public static bool SendHTTPRequest(HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle)
		{
			return default(bool);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00003074 File Offset: 0x00001274
		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x91D350", Offset = "0x91B950", VA = "0x18091D350")]
		public static bool SendHTTPRequestAndStreamResponse(HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle)
		{
			return default(bool);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x0000308C File Offset: 0x0000128C
		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x91D3B0", Offset = "0x91B9B0", VA = "0x18091D3B0")]
		public static bool DeferHTTPRequest(HTTPRequestHandle hRequest)
		{
			return default(bool);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x000030A4 File Offset: 0x000012A4
		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x91D400", Offset = "0x91BA00", VA = "0x18091D400")]
		public static bool PrioritizeHTTPRequest(HTTPRequestHandle hRequest)
		{
			return default(bool);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x000030BC File Offset: 0x000012BC
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x91D450", Offset = "0x91BA50", VA = "0x18091D450")]
		public static bool GetHTTPResponseHeaderSize(HTTPRequestHandle hRequest, string pchHeaderName, out uint unResponseHeaderSize)
		{
			return default(bool);
		}

		// Token: 0x060000EC RID: 236 RVA: 0x000030D4 File Offset: 0x000012D4
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x91D580", Offset = "0x91BB80", VA = "0x18091D580")]
		public static bool GetHTTPResponseHeaderValue(HTTPRequestHandle hRequest, string pchHeaderName, byte[] pHeaderValueBuffer, uint unBufferSize)
		{
			return default(bool);
		}

		// Token: 0x060000ED RID: 237 RVA: 0x000030EC File Offset: 0x000012EC
		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x91D6C0", Offset = "0x91BCC0", VA = "0x18091D6C0")]
		public static bool GetHTTPResponseBodySize(HTTPRequestHandle hRequest, out uint unBodySize)
		{
			return default(bool);
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00003104 File Offset: 0x00001304
		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x91D720", Offset = "0x91BD20", VA = "0x18091D720")]
		public static bool GetHTTPResponseBodyData(HTTPRequestHandle hRequest, byte[] pBodyDataBuffer, uint unBufferSize)
		{
			return default(bool);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x0000311C File Offset: 0x0000131C
		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x91D7A0", Offset = "0x91BDA0", VA = "0x18091D7A0")]
		public static bool GetHTTPStreamingResponseBodyData(HTTPRequestHandle hRequest, uint cOffset, byte[] pBodyDataBuffer, uint unBufferSize)
		{
			return default(bool);
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00003134 File Offset: 0x00001334
		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x91D830", Offset = "0x91BE30", VA = "0x18091D830")]
		public static bool ReleaseHTTPRequest(HTTPRequestHandle hRequest)
		{
			return default(bool);
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x0000314C File Offset: 0x0000134C
		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x91D880", Offset = "0x91BE80", VA = "0x18091D880")]
		public static bool GetHTTPDownloadProgressPct(HTTPRequestHandle hRequest, out float pflPercentOut)
		{
			return default(bool);
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00003164 File Offset: 0x00001364
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x91D8E0", Offset = "0x91BEE0", VA = "0x18091D8E0")]
		public static bool SetHTTPRequestRawPostBody(HTTPRequestHandle hRequest, string pchContentType, byte[] pubBody, uint unBodyLen)
		{
			return default(bool);
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x0000317C File Offset: 0x0000137C
		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x91DA20", Offset = "0x91C020", VA = "0x18091DA20")]
		public static HTTPCookieContainerHandle CreateCookieContainer(bool bAllowResponsesToModify)
		{
			return default(HTTPCookieContainerHandle);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00003194 File Offset: 0x00001394
		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x91DAB0", Offset = "0x91C0B0", VA = "0x18091DAB0")]
		public static bool ReleaseCookieContainer(HTTPCookieContainerHandle hCookieContainer)
		{
			return default(bool);
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x000031AC File Offset: 0x000013AC
		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x91DB00", Offset = "0x91C100", VA = "0x18091DB00")]
		public static bool SetCookie(HTTPCookieContainerHandle hCookieContainer, string pchHost, string pchUrl, string pchCookie)
		{
			return default(bool);
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x000031C4 File Offset: 0x000013C4
		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x91DD50", Offset = "0x91C350", VA = "0x18091DD50")]
		public static bool SetHTTPRequestCookieContainer(HTTPRequestHandle hRequest, HTTPCookieContainerHandle hCookieContainer)
		{
			return default(bool);
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x000031DC File Offset: 0x000013DC
		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x91DDB0", Offset = "0x91C3B0", VA = "0x18091DDB0")]
		public static bool SetHTTPRequestUserAgentInfo(HTTPRequestHandle hRequest, string pchUserAgentInfo)
		{
			return default(bool);
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x000031F4 File Offset: 0x000013F4
		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x91DED0", Offset = "0x91C4D0", VA = "0x18091DED0")]
		public static bool SetHTTPRequestRequiresVerifiedCertificate(HTTPRequestHandle hRequest, bool bRequireVerifiedCertificate)
		{
			return default(bool);
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x0000320C File Offset: 0x0000140C
		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x91DF30", Offset = "0x91C530", VA = "0x18091DF30")]
		public static bool SetHTTPRequestAbsoluteTimeoutMS(HTTPRequestHandle hRequest, uint unMilliseconds)
		{
			return default(bool);
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00003224 File Offset: 0x00001424
		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x91DF90", Offset = "0x91C590", VA = "0x18091DF90")]
		public static bool GetHTTPRequestWasTimedOut(HTTPRequestHandle hRequest, out bool pbWasTimedOut)
		{
			return default(bool);
		}
	}
}
