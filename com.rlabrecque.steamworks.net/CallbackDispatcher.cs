using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000178 RID: 376
	[Token(Token = "0x2000178")]
	public static class CallbackDispatcher
	{
		// Token: 0x06000880 RID: 2176 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000880")]
		[Address(RVA = "0x97E2F0", Offset = "0x97C8F0", VA = "0x18097E2F0")]
		public static void ExceptionHandler(Exception e)
		{
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000881 RID: 2177 RVA: 0x00007B2C File Offset: 0x00005D2C
		[Token(Token = "0x17000020")]
		public static bool IsInitialized
		{
			[Token(Token = "0x6000881")]
			[Address(RVA = "0x97E340", Offset = "0x97C940", VA = "0x18097E340")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000882")]
		[Address(RVA = "0x97E3A0", Offset = "0x97C9A0", VA = "0x18097E3A0")]
		internal static void Initialize()
		{
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000883")]
		[Address(RVA = "0x97E6E0", Offset = "0x97CCE0", VA = "0x18097E6E0")]
		internal static void Shutdown()
		{
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000884")]
		[Address(RVA = "0x97E910", Offset = "0x97CF10", VA = "0x18097E910")]
		internal static void Register(Callback cb)
		{
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000885")]
		[Address(RVA = "0x97EC80", Offset = "0x97D280", VA = "0x18097EC80")]
		internal static void Register(SteamAPICall_t asyncCall, CallResult cr)
		{
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000886")]
		[Address(RVA = "0x97F000", Offset = "0x97D600", VA = "0x18097F000")]
		internal static void Unregister(Callback cb)
		{
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000887")]
		[Address(RVA = "0x97F2E0", Offset = "0x97D8E0", VA = "0x18097F2E0")]
		internal static void Unregister(SteamAPICall_t asyncCall, CallResult cr)
		{
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000888")]
		[Address(RVA = "0x97F5D0", Offset = "0x97DBD0", VA = "0x18097F5D0")]
		private static void UnregisterAll()
		{
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000889")]
		[Address(RVA = "0x9801D0", Offset = "0x97E7D0", VA = "0x1809801D0")]
		internal static void RunFrame(bool isGameServer)
		{
		}

		// Token: 0x040009E8 RID: 2536
		[Token(Token = "0x40009E8")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<int, List<Callback>> m_registeredCallbacks;

		// Token: 0x040009E9 RID: 2537
		[Token(Token = "0x40009E9")]
		[FieldOffset(Offset = "0x8")]
		private static Dictionary<int, List<Callback>> m_registeredGameServerCallbacks;

		// Token: 0x040009EA RID: 2538
		[Token(Token = "0x40009EA")]
		[FieldOffset(Offset = "0x10")]
		private static Dictionary<ulong, List<CallResult>> m_registeredCallResults;

		// Token: 0x040009EB RID: 2539
		[Token(Token = "0x40009EB")]
		[FieldOffset(Offset = "0x18")]
		private static object m_sync;

		// Token: 0x040009EC RID: 2540
		[Token(Token = "0x40009EC")]
		[FieldOffset(Offset = "0x20")]
		private static IntPtr m_pCallbackMsg;

		// Token: 0x040009ED RID: 2541
		[Token(Token = "0x40009ED")]
		[FieldOffset(Offset = "0x28")]
		private static int m_initCount;
	}
}
