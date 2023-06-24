using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200015B RID: 347
	[Token(Token = "0x200015B")]
	public enum EHTTPStatusCode
	{
		// Token: 0x040008A5 RID: 2213
		[Token(Token = "0x40008A5")]
		k_EHTTPStatusCodeInvalid,
		// Token: 0x040008A6 RID: 2214
		[Token(Token = "0x40008A6")]
		k_EHTTPStatusCode100Continue = 100,
		// Token: 0x040008A7 RID: 2215
		[Token(Token = "0x40008A7")]
		k_EHTTPStatusCode101SwitchingProtocols,
		// Token: 0x040008A8 RID: 2216
		[Token(Token = "0x40008A8")]
		k_EHTTPStatusCode200OK = 200,
		// Token: 0x040008A9 RID: 2217
		[Token(Token = "0x40008A9")]
		k_EHTTPStatusCode201Created,
		// Token: 0x040008AA RID: 2218
		[Token(Token = "0x40008AA")]
		k_EHTTPStatusCode202Accepted,
		// Token: 0x040008AB RID: 2219
		[Token(Token = "0x40008AB")]
		k_EHTTPStatusCode203NonAuthoritative,
		// Token: 0x040008AC RID: 2220
		[Token(Token = "0x40008AC")]
		k_EHTTPStatusCode204NoContent,
		// Token: 0x040008AD RID: 2221
		[Token(Token = "0x40008AD")]
		k_EHTTPStatusCode205ResetContent,
		// Token: 0x040008AE RID: 2222
		[Token(Token = "0x40008AE")]
		k_EHTTPStatusCode206PartialContent,
		// Token: 0x040008AF RID: 2223
		[Token(Token = "0x40008AF")]
		k_EHTTPStatusCode300MultipleChoices = 300,
		// Token: 0x040008B0 RID: 2224
		[Token(Token = "0x40008B0")]
		k_EHTTPStatusCode301MovedPermanently,
		// Token: 0x040008B1 RID: 2225
		[Token(Token = "0x40008B1")]
		k_EHTTPStatusCode302Found,
		// Token: 0x040008B2 RID: 2226
		[Token(Token = "0x40008B2")]
		k_EHTTPStatusCode303SeeOther,
		// Token: 0x040008B3 RID: 2227
		[Token(Token = "0x40008B3")]
		k_EHTTPStatusCode304NotModified,
		// Token: 0x040008B4 RID: 2228
		[Token(Token = "0x40008B4")]
		k_EHTTPStatusCode305UseProxy,
		// Token: 0x040008B5 RID: 2229
		[Token(Token = "0x40008B5")]
		k_EHTTPStatusCode307TemporaryRedirect = 307,
		// Token: 0x040008B6 RID: 2230
		[Token(Token = "0x40008B6")]
		k_EHTTPStatusCode400BadRequest = 400,
		// Token: 0x040008B7 RID: 2231
		[Token(Token = "0x40008B7")]
		k_EHTTPStatusCode401Unauthorized,
		// Token: 0x040008B8 RID: 2232
		[Token(Token = "0x40008B8")]
		k_EHTTPStatusCode402PaymentRequired,
		// Token: 0x040008B9 RID: 2233
		[Token(Token = "0x40008B9")]
		k_EHTTPStatusCode403Forbidden,
		// Token: 0x040008BA RID: 2234
		[Token(Token = "0x40008BA")]
		k_EHTTPStatusCode404NotFound,
		// Token: 0x040008BB RID: 2235
		[Token(Token = "0x40008BB")]
		k_EHTTPStatusCode405MethodNotAllowed,
		// Token: 0x040008BC RID: 2236
		[Token(Token = "0x40008BC")]
		k_EHTTPStatusCode406NotAcceptable,
		// Token: 0x040008BD RID: 2237
		[Token(Token = "0x40008BD")]
		k_EHTTPStatusCode407ProxyAuthRequired,
		// Token: 0x040008BE RID: 2238
		[Token(Token = "0x40008BE")]
		k_EHTTPStatusCode408RequestTimeout,
		// Token: 0x040008BF RID: 2239
		[Token(Token = "0x40008BF")]
		k_EHTTPStatusCode409Conflict,
		// Token: 0x040008C0 RID: 2240
		[Token(Token = "0x40008C0")]
		k_EHTTPStatusCode410Gone,
		// Token: 0x040008C1 RID: 2241
		[Token(Token = "0x40008C1")]
		k_EHTTPStatusCode411LengthRequired,
		// Token: 0x040008C2 RID: 2242
		[Token(Token = "0x40008C2")]
		k_EHTTPStatusCode412PreconditionFailed,
		// Token: 0x040008C3 RID: 2243
		[Token(Token = "0x40008C3")]
		k_EHTTPStatusCode413RequestEntityTooLarge,
		// Token: 0x040008C4 RID: 2244
		[Token(Token = "0x40008C4")]
		k_EHTTPStatusCode414RequestURITooLong,
		// Token: 0x040008C5 RID: 2245
		[Token(Token = "0x40008C5")]
		k_EHTTPStatusCode415UnsupportedMediaType,
		// Token: 0x040008C6 RID: 2246
		[Token(Token = "0x40008C6")]
		k_EHTTPStatusCode416RequestedRangeNotSatisfiable,
		// Token: 0x040008C7 RID: 2247
		[Token(Token = "0x40008C7")]
		k_EHTTPStatusCode417ExpectationFailed,
		// Token: 0x040008C8 RID: 2248
		[Token(Token = "0x40008C8")]
		k_EHTTPStatusCode4xxUnknown,
		// Token: 0x040008C9 RID: 2249
		[Token(Token = "0x40008C9")]
		k_EHTTPStatusCode429TooManyRequests = 429,
		// Token: 0x040008CA RID: 2250
		[Token(Token = "0x40008CA")]
		k_EHTTPStatusCode444ConnectionClosed = 444,
		// Token: 0x040008CB RID: 2251
		[Token(Token = "0x40008CB")]
		k_EHTTPStatusCode500InternalServerError = 500,
		// Token: 0x040008CC RID: 2252
		[Token(Token = "0x40008CC")]
		k_EHTTPStatusCode501NotImplemented,
		// Token: 0x040008CD RID: 2253
		[Token(Token = "0x40008CD")]
		k_EHTTPStatusCode502BadGateway,
		// Token: 0x040008CE RID: 2254
		[Token(Token = "0x40008CE")]
		k_EHTTPStatusCode503ServiceUnavailable,
		// Token: 0x040008CF RID: 2255
		[Token(Token = "0x40008CF")]
		k_EHTTPStatusCode504GatewayTimeout,
		// Token: 0x040008D0 RID: 2256
		[Token(Token = "0x40008D0")]
		k_EHTTPStatusCode505HTTPVersionNotSupported,
		// Token: 0x040008D1 RID: 2257
		[Token(Token = "0x40008D1")]
		k_EHTTPStatusCode5xxUnknown = 599
	}
}
