using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using AOT;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200018E RID: 398
	[Token(Token = "0x200018E")]
	public class ISteamMatchmakingPingResponse
	{
		// Token: 0x060008EC RID: 2284 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008EC")]
		[Address(RVA = "0x983D70", Offset = "0x982370", VA = "0x180983D70")]
		public ISteamMatchmakingPingResponse(ISteamMatchmakingPingResponse.ServerResponded onServerResponded, ISteamMatchmakingPingResponse.ServerFailedToRespond onServerFailedToRespond)
		{
		}

		// Token: 0x060008ED RID: 2285 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008ED")]
		[Address(RVA = "0x9843B0", Offset = "0x9829B0", VA = "0x1809843B0", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x060008EE RID: 2286 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008EE")]
		[Address(RVA = "0x984590", Offset = "0x982B90", VA = "0x180984590")]
		[MonoPInvokeCallback(typeof(ISteamMatchmakingPingResponse.InternalServerResponded))]
		private static void InternalOnServerResponded(IntPtr thisptr, gameserveritem_t server)
		{
		}

		// Token: 0x060008EF RID: 2287 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008EF")]
		[Address(RVA = "0x984680", Offset = "0x982C80", VA = "0x180984680")]
		[MonoPInvokeCallback(typeof(ISteamMatchmakingPingResponse.InternalServerFailedToRespond))]
		private static void InternalOnServerFailedToRespond(IntPtr thisptr)
		{
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x00007C34 File Offset: 0x00005E34
		[Token(Token = "0x60008F0")]
		[Address(RVA = "0x9836C0", Offset = "0x981CC0", VA = "0x1809836C0")]
		public static explicit operator IntPtr(ISteamMatchmakingPingResponse that)
		{
			return 0;
		}

		// Token: 0x04000A05 RID: 2565
		[Token(Token = "0x4000A05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private ISteamMatchmakingPingResponse.VTable m_VTable;

		// Token: 0x04000A06 RID: 2566
		[Token(Token = "0x4000A06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IntPtr m_pVTable;

		// Token: 0x04000A07 RID: 2567
		[Token(Token = "0x4000A07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GCHandle m_pGCHandle;

		// Token: 0x04000A08 RID: 2568
		[Token(Token = "0x4000A08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ISteamMatchmakingPingResponse.ServerResponded m_ServerResponded;

		// Token: 0x04000A09 RID: 2569
		[Token(Token = "0x4000A09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ISteamMatchmakingPingResponse.ServerFailedToRespond m_ServerFailedToRespond;

		// Token: 0x04000A0A RID: 2570
		[Token(Token = "0x4000A0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<IntPtr, ISteamMatchmakingPingResponse> m_vTablesMap;

		// Token: 0x0200018F RID: 399
		// (Invoke) Token: 0x060008F3 RID: 2291
		[Token(Token = "0x200018F")]
		public delegate void ServerResponded(gameserveritem_t server);

		// Token: 0x02000190 RID: 400
		// (Invoke) Token: 0x060008F7 RID: 2295
		[Token(Token = "0x2000190")]
		public delegate void ServerFailedToRespond();

		// Token: 0x02000191 RID: 401
		// (Invoke) Token: 0x060008FB RID: 2299
		[Token(Token = "0x2000191")]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		private delegate void InternalServerResponded(IntPtr thisptr, gameserveritem_t server);

		// Token: 0x02000192 RID: 402
		// (Invoke) Token: 0x060008FF RID: 2303
		[Token(Token = "0x2000192")]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		private delegate void InternalServerFailedToRespond(IntPtr thisptr);

		// Token: 0x02000193 RID: 403
		[Token(Token = "0x2000193")]
		[StructLayout(0)]
		private class VTable
		{
			// Token: 0x06000902 RID: 2306 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000902")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public VTable()
			{
			}

			// Token: 0x04000A0B RID: 2571
			[Token(Token = "0x4000A0B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[NonSerialized]
			public ISteamMatchmakingPingResponse.InternalServerResponded m_VTServerResponded;

			// Token: 0x04000A0C RID: 2572
			[Token(Token = "0x4000A0C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[NonSerialized]
			public ISteamMatchmakingPingResponse.InternalServerFailedToRespond m_VTServerFailedToRespond;
		}
	}
}
