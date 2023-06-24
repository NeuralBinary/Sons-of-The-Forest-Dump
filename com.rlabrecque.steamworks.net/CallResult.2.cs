using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200017D RID: 381
	[Token(Token = "0x200017D")]
	public sealed class CallResult<T> : CallResult, IDisposable
	{
		// Token: 0x14000002 RID: 2
		// (add) Token: 0x060008A5 RID: 2213 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x060008A6 RID: 2214 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x14000002")]
		private event CallResult<T>.APIDispatchDelegate m_Func
		{
			[Token(Token = "0x60008A5")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60008A6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060008A7 RID: 2215 RVA: 0x00007B5C File Offset: 0x00005D5C
		[Token(Token = "0x17000023")]
		public SteamAPICall_t Handle
		{
			[Token(Token = "0x60008A7")]
			get
			{
				return default(SteamAPICall_t);
			}
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x60008A8")]
		public static CallResult<T> Create([Optional] CallResult<T>.APIDispatchDelegate func)
		{
			return null;
		}

		// Token: 0x060008A9 RID: 2217 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008A9")]
		public CallResult([Optional] CallResult<T>.APIDispatchDelegate func)
		{
		}

		// Token: 0x060008AA RID: 2218 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008AA")]
		protected override void Finalize()
		{
		}

		// Token: 0x060008AB RID: 2219 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008AB")]
		public void Dispose()
		{
		}

		// Token: 0x060008AC RID: 2220 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008AC")]
		public void Set(SteamAPICall_t hAPICall, [Optional] CallResult<T>.APIDispatchDelegate func)
		{
		}

		// Token: 0x060008AD RID: 2221 RVA: 0x00007B74 File Offset: 0x00005D74
		[Token(Token = "0x60008AD")]
		public bool IsActive()
		{
			return default(bool);
		}

		// Token: 0x060008AE RID: 2222 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008AE")]
		public void Cancel()
		{
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x60008AF")]
		internal override Type GetCallbackType()
		{
			return null;
		}

		// Token: 0x060008B0 RID: 2224 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008B0")]
		internal override void OnRunCallResult(IntPtr pvParam, bool bFailed, ulong hSteamAPICall_)
		{
		}

		// Token: 0x060008B1 RID: 2225 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008B1")]
		internal override void SetUnregistered()
		{
		}

		// Token: 0x040009F3 RID: 2547
		[Token(Token = "0x40009F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private SteamAPICall_t m_hAPICall;

		// Token: 0x040009F4 RID: 2548
		[Token(Token = "0x40009F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool m_bDisposed;

		// Token: 0x0200017E RID: 382
		// (Invoke) Token: 0x060008B3 RID: 2227
		[Token(Token = "0x200017E")]
		public delegate void APIDispatchDelegate(T param, bool bIOFailure);
	}
}
