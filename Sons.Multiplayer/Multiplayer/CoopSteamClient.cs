using System;
using Il2CppDummyDll;
using UdpKit;

namespace Sons.Multiplayer
{
	// Token: 0x02000022 RID: 34
	[Token(Token = "0x2000022")]
	public static class CoopSteamClient
	{
		// Token: 0x0600010C RID: 268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010C")]
		[Address(RVA = "0x30E12D0", Offset = "0x30DF8D0", VA = "0x1830E12D0")]
		public static void Start()
		{
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010D")]
		[Address(RVA = "0x30E1310", Offset = "0x30DF910", VA = "0x1830E1310")]
		public static void Update()
		{
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010E")]
		[Address(RVA = "0x30E1540", Offset = "0x30DFB40", VA = "0x1830E1540")]
		public static void Shutdown()
		{
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010F")]
		[Address(RVA = "0x30E12D0", Offset = "0x30DF8D0", VA = "0x1830E12D0")]
		private static void Initialize()
		{
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000110")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		internal static void PerformReconnect()
		{
		}

		// Token: 0x0400008A RID: 138
		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0x0")]
		private static bool _hasInitialized;

		// Token: 0x0400008B RID: 139
		[Token(Token = "0x400008B")]
		[FieldOffset(Offset = "0x8")]
		private static UdpSocket socket;
	}
}
