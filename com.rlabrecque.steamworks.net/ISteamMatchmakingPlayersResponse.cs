using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000194 RID: 404
	[Token(Token = "0x2000194")]
	public class ISteamMatchmakingPlayersResponse
	{
		// Token: 0x06000903 RID: 2307 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000903")]
		[Address(RVA = "0x984AE0", Offset = "0x9830E0", VA = "0x180984AE0")]
		public ISteamMatchmakingPlayersResponse(ISteamMatchmakingPlayersResponse.AddPlayerToList onAddPlayerToList, ISteamMatchmakingPlayersResponse.PlayersFailedToRespond onPlayersFailedToRespond, ISteamMatchmakingPlayersResponse.PlayersRefreshComplete onPlayersRefreshComplete)
		{
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000904")]
		[Address(RVA = "0x984F60", Offset = "0x983560", VA = "0x180984F60", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x06000905 RID: 2309 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000905")]
		[Address(RVA = "0x985050", Offset = "0x983650", VA = "0x180985050")]
		private void InternalOnAddPlayerToList(IntPtr thisptr, IntPtr pchName, int nScore, float flTimePlayed)
		{
		}

		// Token: 0x06000906 RID: 2310 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000906")]
		[Address(RVA = "0x9850A0", Offset = "0x9836A0", VA = "0x1809850A0")]
		private void InternalOnPlayersFailedToRespond(IntPtr thisptr)
		{
		}

		// Token: 0x06000907 RID: 2311 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000907")]
		[Address(RVA = "0x9850D0", Offset = "0x9836D0", VA = "0x1809850D0")]
		private void InternalOnPlayersRefreshComplete(IntPtr thisptr)
		{
		}

		// Token: 0x06000908 RID: 2312 RVA: 0x00007C4C File Offset: 0x00005E4C
		[Token(Token = "0x6000908")]
		[Address(RVA = "0x9836C0", Offset = "0x981CC0", VA = "0x1809836C0")]
		public static explicit operator IntPtr(ISteamMatchmakingPlayersResponse that)
		{
			return 0;
		}

		// Token: 0x04000A0D RID: 2573
		[Token(Token = "0x4000A0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private ISteamMatchmakingPlayersResponse.VTable m_VTable;

		// Token: 0x04000A0E RID: 2574
		[Token(Token = "0x4000A0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IntPtr m_pVTable;

		// Token: 0x04000A0F RID: 2575
		[Token(Token = "0x4000A0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GCHandle m_pGCHandle;

		// Token: 0x04000A10 RID: 2576
		[Token(Token = "0x4000A10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ISteamMatchmakingPlayersResponse.AddPlayerToList m_AddPlayerToList;

		// Token: 0x04000A11 RID: 2577
		[Token(Token = "0x4000A11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ISteamMatchmakingPlayersResponse.PlayersFailedToRespond m_PlayersFailedToRespond;

		// Token: 0x04000A12 RID: 2578
		[Token(Token = "0x4000A12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ISteamMatchmakingPlayersResponse.PlayersRefreshComplete m_PlayersRefreshComplete;

		// Token: 0x02000195 RID: 405
		// (Invoke) Token: 0x0600090A RID: 2314
		[Token(Token = "0x2000195")]
		public delegate void AddPlayerToList(string pchName, int nScore, float flTimePlayed);

		// Token: 0x02000196 RID: 406
		// (Invoke) Token: 0x0600090E RID: 2318
		[Token(Token = "0x2000196")]
		public delegate void PlayersFailedToRespond();

		// Token: 0x02000197 RID: 407
		// (Invoke) Token: 0x06000912 RID: 2322
		[Token(Token = "0x2000197")]
		public delegate void PlayersRefreshComplete();

		// Token: 0x02000198 RID: 408
		// (Invoke) Token: 0x06000916 RID: 2326
		[Token(Token = "0x2000198")]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		public delegate void InternalAddPlayerToList(IntPtr thisptr, IntPtr pchName, int nScore, float flTimePlayed);

		// Token: 0x02000199 RID: 409
		// (Invoke) Token: 0x0600091A RID: 2330
		[Token(Token = "0x2000199")]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		public delegate void InternalPlayersFailedToRespond(IntPtr thisptr);

		// Token: 0x0200019A RID: 410
		// (Invoke) Token: 0x0600091E RID: 2334
		[Token(Token = "0x200019A")]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		public delegate void InternalPlayersRefreshComplete(IntPtr thisptr);

		// Token: 0x0200019B RID: 411
		[Token(Token = "0x200019B")]
		[StructLayout(0)]
		private class VTable
		{
			// Token: 0x06000921 RID: 2337 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000921")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public VTable()
			{
			}

			// Token: 0x04000A13 RID: 2579
			[Token(Token = "0x4000A13")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[NonSerialized]
			public ISteamMatchmakingPlayersResponse.InternalAddPlayerToList m_VTAddPlayerToList;

			// Token: 0x04000A14 RID: 2580
			[Token(Token = "0x4000A14")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[NonSerialized]
			public ISteamMatchmakingPlayersResponse.InternalPlayersFailedToRespond m_VTPlayersFailedToRespond;

			// Token: 0x04000A15 RID: 2581
			[Token(Token = "0x4000A15")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[NonSerialized]
			public ISteamMatchmakingPlayersResponse.InternalPlayersRefreshComplete m_VTPlayersRefreshComplete;
		}
	}
}
