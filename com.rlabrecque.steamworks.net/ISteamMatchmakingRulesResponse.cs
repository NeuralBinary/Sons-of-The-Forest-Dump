using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200019C RID: 412
	[Token(Token = "0x200019C")]
	public class ISteamMatchmakingRulesResponse
	{
		// Token: 0x06000922 RID: 2338 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000922")]
		[Address(RVA = "0x985570", Offset = "0x983B70", VA = "0x180985570")]
		public ISteamMatchmakingRulesResponse(ISteamMatchmakingRulesResponse.RulesResponded onRulesResponded, ISteamMatchmakingRulesResponse.RulesFailedToRespond onRulesFailedToRespond, ISteamMatchmakingRulesResponse.RulesRefreshComplete onRulesRefreshComplete)
		{
		}

		// Token: 0x06000923 RID: 2339 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000923")]
		[Address(RVA = "0x9859F0", Offset = "0x983FF0", VA = "0x1809859F0", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x06000924 RID: 2340 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000924")]
		[Address(RVA = "0x985AE0", Offset = "0x9840E0", VA = "0x180985AE0")]
		private void InternalOnRulesResponded(IntPtr thisptr, IntPtr pchRule, IntPtr pchValue)
		{
		}

		// Token: 0x06000925 RID: 2341 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000925")]
		[Address(RVA = "0x9850A0", Offset = "0x9836A0", VA = "0x1809850A0")]
		private void InternalOnRulesFailedToRespond(IntPtr thisptr)
		{
		}

		// Token: 0x06000926 RID: 2342 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000926")]
		[Address(RVA = "0x9850D0", Offset = "0x9836D0", VA = "0x1809850D0")]
		private void InternalOnRulesRefreshComplete(IntPtr thisptr)
		{
		}

		// Token: 0x06000927 RID: 2343 RVA: 0x00007C64 File Offset: 0x00005E64
		[Token(Token = "0x6000927")]
		[Address(RVA = "0x9836C0", Offset = "0x981CC0", VA = "0x1809836C0")]
		public static explicit operator IntPtr(ISteamMatchmakingRulesResponse that)
		{
			return 0;
		}

		// Token: 0x04000A16 RID: 2582
		[Token(Token = "0x4000A16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private ISteamMatchmakingRulesResponse.VTable m_VTable;

		// Token: 0x04000A17 RID: 2583
		[Token(Token = "0x4000A17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IntPtr m_pVTable;

		// Token: 0x04000A18 RID: 2584
		[Token(Token = "0x4000A18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GCHandle m_pGCHandle;

		// Token: 0x04000A19 RID: 2585
		[Token(Token = "0x4000A19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ISteamMatchmakingRulesResponse.RulesResponded m_RulesResponded;

		// Token: 0x04000A1A RID: 2586
		[Token(Token = "0x4000A1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ISteamMatchmakingRulesResponse.RulesFailedToRespond m_RulesFailedToRespond;

		// Token: 0x04000A1B RID: 2587
		[Token(Token = "0x4000A1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ISteamMatchmakingRulesResponse.RulesRefreshComplete m_RulesRefreshComplete;

		// Token: 0x0200019D RID: 413
		// (Invoke) Token: 0x06000929 RID: 2345
		[Token(Token = "0x200019D")]
		public delegate void RulesResponded(string pchRule, string pchValue);

		// Token: 0x0200019E RID: 414
		// (Invoke) Token: 0x0600092D RID: 2349
		[Token(Token = "0x200019E")]
		public delegate void RulesFailedToRespond();

		// Token: 0x0200019F RID: 415
		// (Invoke) Token: 0x06000931 RID: 2353
		[Token(Token = "0x200019F")]
		public delegate void RulesRefreshComplete();

		// Token: 0x020001A0 RID: 416
		// (Invoke) Token: 0x06000935 RID: 2357
		[Token(Token = "0x20001A0")]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		public delegate void InternalRulesResponded(IntPtr thisptr, IntPtr pchRule, IntPtr pchValue);

		// Token: 0x020001A1 RID: 417
		// (Invoke) Token: 0x06000939 RID: 2361
		[Token(Token = "0x20001A1")]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		public delegate void InternalRulesFailedToRespond(IntPtr thisptr);

		// Token: 0x020001A2 RID: 418
		// (Invoke) Token: 0x0600093D RID: 2365
		[Token(Token = "0x20001A2")]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		public delegate void InternalRulesRefreshComplete(IntPtr thisptr);

		// Token: 0x020001A3 RID: 419
		[Token(Token = "0x20001A3")]
		[StructLayout(0)]
		private class VTable
		{
			// Token: 0x06000940 RID: 2368 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000940")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public VTable()
			{
			}

			// Token: 0x04000A1C RID: 2588
			[Token(Token = "0x4000A1C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[NonSerialized]
			public ISteamMatchmakingRulesResponse.InternalRulesResponded m_VTRulesResponded;

			// Token: 0x04000A1D RID: 2589
			[Token(Token = "0x4000A1D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[NonSerialized]
			public ISteamMatchmakingRulesResponse.InternalRulesFailedToRespond m_VTRulesFailedToRespond;

			// Token: 0x04000A1E RID: 2590
			[Token(Token = "0x4000A1E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[NonSerialized]
			public ISteamMatchmakingRulesResponse.InternalRulesRefreshComplete m_VTRulesRefreshComplete;
		}
	}
}
