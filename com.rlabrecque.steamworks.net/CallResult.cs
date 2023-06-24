using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200017C RID: 380
	[Token(Token = "0x200017C")]
	public abstract class CallResult
	{
		// Token: 0x060008A1 RID: 2209
		[Token(Token = "0x60008A1")]
		internal abstract Type GetCallbackType();

		// Token: 0x060008A2 RID: 2210
		[Token(Token = "0x60008A2")]
		internal abstract void OnRunCallResult(IntPtr pvParam, bool bFailed, ulong hSteamAPICall);

		// Token: 0x060008A3 RID: 2211
		[Token(Token = "0x60008A3")]
		internal abstract void SetUnregistered();

		// Token: 0x060008A4 RID: 2212 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008A4")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		protected CallResult()
		{
		}
	}
}
