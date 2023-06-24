using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using AOT;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000186 RID: 390
	[Token(Token = "0x2000186")]
	public class ISteamMatchmakingServerListResponse
	{
		// Token: 0x060008CC RID: 2252 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008CC")]
		[Address(RVA = "0x982C70", Offset = "0x981270", VA = "0x180982C70")]
		public ISteamMatchmakingServerListResponse(ISteamMatchmakingServerListResponse.ServerResponded onServerResponded, ISteamMatchmakingServerListResponse.ServerFailedToRespond onServerFailedToRespond, ISteamMatchmakingServerListResponse.RefreshComplete onRefreshComplete)
		{
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008CD")]
		[Address(RVA = "0x9831E0", Offset = "0x9817E0", VA = "0x1809831E0", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008CE")]
		[Address(RVA = "0x9833C0", Offset = "0x9819C0", VA = "0x1809833C0")]
		[MonoPInvokeCallback(typeof(ISteamMatchmakingServerListResponse.InternalServerResponded))]
		private static void InternalOnServerResponded(IntPtr thisptr, HServerListRequest hRequest, int iServer)
		{
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008CF")]
		[Address(RVA = "0x9834C0", Offset = "0x981AC0", VA = "0x1809834C0")]
		[MonoPInvokeCallback(typeof(ISteamMatchmakingServerListResponse.InternalServerFailedToRespond))]
		private static void InternalOnServerFailedToRespond(IntPtr thisptr, HServerListRequest hRequest, int iServer)
		{
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008D0")]
		[Address(RVA = "0x9835C0", Offset = "0x981BC0", VA = "0x1809835C0")]
		[MonoPInvokeCallback(typeof(ISteamMatchmakingServerListResponse.InternalRefreshComplete))]
		private static void InternalOnRefreshComplete(IntPtr thisptr, HServerListRequest hRequest, EMatchMakingServerResponse response)
		{
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x00007C1C File Offset: 0x00005E1C
		[Token(Token = "0x60008D1")]
		[Address(RVA = "0x9836C0", Offset = "0x981CC0", VA = "0x1809836C0")]
		public static explicit operator IntPtr(ISteamMatchmakingServerListResponse that)
		{
			return 0;
		}

		// Token: 0x040009FB RID: 2555
		[Token(Token = "0x40009FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private ISteamMatchmakingServerListResponse.VTable m_VTable;

		// Token: 0x040009FC RID: 2556
		[Token(Token = "0x40009FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IntPtr m_pVTable;

		// Token: 0x040009FD RID: 2557
		[Token(Token = "0x40009FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GCHandle m_pGCHandle;

		// Token: 0x040009FE RID: 2558
		[Token(Token = "0x40009FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ISteamMatchmakingServerListResponse.ServerResponded m_ServerResponded;

		// Token: 0x040009FF RID: 2559
		[Token(Token = "0x40009FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ISteamMatchmakingServerListResponse.ServerFailedToRespond m_ServerFailedToRespond;

		// Token: 0x04000A00 RID: 2560
		[Token(Token = "0x4000A00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ISteamMatchmakingServerListResponse.RefreshComplete m_RefreshComplete;

		// Token: 0x04000A01 RID: 2561
		[Token(Token = "0x4000A01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<IntPtr, ISteamMatchmakingServerListResponse> m_vTablesMap;

		// Token: 0x02000187 RID: 391
		// (Invoke) Token: 0x060008D4 RID: 2260
		[Token(Token = "0x2000187")]
		public delegate void ServerResponded(HServerListRequest hRequest, int iServer);

		// Token: 0x02000188 RID: 392
		// (Invoke) Token: 0x060008D8 RID: 2264
		[Token(Token = "0x2000188")]
		public delegate void ServerFailedToRespond(HServerListRequest hRequest, int iServer);

		// Token: 0x02000189 RID: 393
		// (Invoke) Token: 0x060008DC RID: 2268
		[Token(Token = "0x2000189")]
		public delegate void RefreshComplete(HServerListRequest hRequest, EMatchMakingServerResponse response);

		// Token: 0x0200018A RID: 394
		// (Invoke) Token: 0x060008E0 RID: 2272
		[Token(Token = "0x200018A")]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		private delegate void InternalServerResponded(IntPtr thisptr, HServerListRequest hRequest, int iServer);

		// Token: 0x0200018B RID: 395
		// (Invoke) Token: 0x060008E4 RID: 2276
		[Token(Token = "0x200018B")]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		private delegate void InternalServerFailedToRespond(IntPtr thisptr, HServerListRequest hRequest, int iServer);

		// Token: 0x0200018C RID: 396
		// (Invoke) Token: 0x060008E8 RID: 2280
		[Token(Token = "0x200018C")]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		private delegate void InternalRefreshComplete(IntPtr thisptr, HServerListRequest hRequest, EMatchMakingServerResponse response);

		// Token: 0x0200018D RID: 397
		[Token(Token = "0x200018D")]
		[StructLayout(0)]
		private class VTable
		{
			// Token: 0x060008EB RID: 2283 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60008EB")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public VTable()
			{
			}

			// Token: 0x04000A02 RID: 2562
			[Token(Token = "0x4000A02")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[NonSerialized]
			public ISteamMatchmakingServerListResponse.InternalServerResponded m_VTServerResponded;

			// Token: 0x04000A03 RID: 2563
			[Token(Token = "0x4000A03")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[NonSerialized]
			public ISteamMatchmakingServerListResponse.InternalServerFailedToRespond m_VTServerFailedToRespond;

			// Token: 0x04000A04 RID: 2564
			[Token(Token = "0x4000A04")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[NonSerialized]
			public ISteamMatchmakingServerListResponse.InternalRefreshComplete m_VTRefreshComplete;
		}
	}
}
